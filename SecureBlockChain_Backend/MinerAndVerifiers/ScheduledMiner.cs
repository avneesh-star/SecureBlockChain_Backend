using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Quartz;
using SecureBlockChain_Backend.Data;
using SecureBlockChain_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureBlockChain_Backend
{

    //This class contains miner and three verifiers
    public class ScheduledMiner : IJob
    {

        private readonly IConfiguration configuration;
        private readonly ILogger<ScheduledMiner> logger;
        private readonly BlockChainsDbContext _blockChainsDbContext;

        //Global Instance of SecureBlockChain
        private BlockChain SecureBlockChain;

        //Blockchains from databse
        private StoreBlockChains tempBlockChains;

        //Blockchains of individual verifiers
        private Verifier_1BlockChain Verifier1Chain;
        private Verifier_2BlockChain Verifier2Chain;
        private Verifier_3BlockChain Verifier3Chain;

        public ScheduledMiner(IConfiguration cfg, BlockChain blockChain, BlockChainsDbContext sdb, ILogger<ScheduledMiner> log)
        {
            configuration = cfg;
            SecureBlockChain = blockChain;
            _blockChainsDbContext = sdb;
            Verifier1Chain = new Verifier_1BlockChain(sdb);
            Verifier2Chain = new Verifier_2BlockChain(sdb);
            Verifier3Chain = new Verifier_3BlockChain(sdb);
            tempBlockChains = new StoreBlockChains();
            logger = log;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            tempBlockChains = await _blockChainsDbContext.AllBlockChains.SingleOrDefaultAsync(m => m.BlockChainID == 1);
            
            //First time scheduler is running
            if(tempBlockChains==null)
            {
                //Initialize all block chains with genesis block
                var newBlockChains = new StoreBlockChains();
                newBlockChains.Difficulty = 5;
                await _blockChainsDbContext.AllBlockChains.AddAsync(newBlockChains);
                await _blockChainsDbContext.SaveChangesAsync();
                var block = SecureBlockChain.GetGenesisBlock(1);
                _blockChainsDbContext.SupplyBlocks.Add(block.ToSupplyBlock());
                await _blockChainsDbContext.SaveChangesAsync();
                _blockChainsDbContext.Verifier_1Blocks.Add(block.ToVerifier_1Block());
                await _blockChainsDbContext.SaveChangesAsync();
                _blockChainsDbContext.Verifier_2Blocks.Add(block.ToVerifier_2Block());
                await _blockChainsDbContext.SaveChangesAsync();
                _blockChainsDbContext.Verifier_3Blocks.Add(block.ToVerifier_3Block());
                await _blockChainsDbContext.SaveChangesAsync();
                newBlockChains.Difficulty = SecureBlockChain.Difficulty;

                //Initialize local blockchains to genesis block
                tempBlockChains = new StoreBlockChains();
              
                tempBlockChains.Difficulty = SecureBlockChain.Difficulty;
            }

            //Get mainBlockChain from database
         
            SecureBlockChain.Difficulty = tempBlockChains.Difficulty;

            //Get all pending transactions till now and store them in mining transactions for mining
            var PendingTransactions = await _blockChainsDbContext.PendingTransaction.ToListAsync();
            //SecureBlockChain.MiningTransactions = PendingTransactions;

            foreach (var transaction in PendingTransactions)
            {
                try
                {


                    Block tempBlock = new Block(SecureBlockChain.GetLatestBlock().CurrentHash, transaction, SecureBlockChain.Difficulty);
                    await tempBlock.MineBlock(SecureBlockChain.Difficulty);
                    //Fire up first verifier to verify if new block is okay
                    if (await Verifier1(tempBlock) == true)
                    {
                        _blockChainsDbContext.PendingTransaction.Remove(transaction);
                        await _blockChainsDbContext.SaveChangesAsync();
                        logger.LogInformation($"Block mined with hash : {tempBlock.CurrentHash}. Log Timestamp : {DateTime.Now.ToLongTimeString()}.");
                    }
                    else
                    {
                        //In Case block is not okay, restore all transactions to pending transactions
                        
                        logger.LogError($"Block can't be mined or verified. Log Timestamp : {DateTime.Now.ToLongDateString()}.");
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, ex.Message);
                }

            }
        }

        private async Task<bool> Verifier1(Block MinedBlock)
        {
          
            //Check if block is genuine
            if(Verifier1Chain.IsChainValid(MinedBlock.ChainId, MinedBlock) ==false)
            {
                return false;
            }

            //Fire up second verifier to verify if new block is okay
            return await Verifier2(MinedBlock);
        }

        private async Task<bool> Verifier2(Block MinedBlock)
        {
            
          
            //Check if block is genuine
            if (Verifier2Chain.IsChainValid(MinedBlock.ChainId, MinedBlock) == false)
            {
                return false;
            }
            

            //Fire up third verifier to verify if new block is okay
            return await Verifier3(MinedBlock);
        }

        private async Task<bool> Verifier3(Block MinedBlock)
        {

            //Check if block is genuine
            if (Verifier3Chain.IsChainValid(MinedBlock.ChainId, MinedBlock) == false)
            {
                return false;
            }

            //Add this block to all blockchains permanently and store in database
            return await AddBlockToChain(MinedBlock);
        }

        private async Task<bool> AddBlockToChain(Block MinedBlock)
        {
            //Adding block to main SupplyChain
            Verifier1Chain.AddBlock(MinedBlock);
            Verifier2Chain.AddBlock(MinedBlock);
            Verifier3Chain.AddBlock(MinedBlock);
            SecureBlockChain.AddBlock(MinedBlock);

            return true;
        }
    }
}
