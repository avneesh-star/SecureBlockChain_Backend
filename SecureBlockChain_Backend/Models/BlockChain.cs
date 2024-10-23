using SecureBlockChain_Backend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace SecureBlockChain_Backend.Models
{
    public class BlockChain
    {
        private readonly BlockChainsDbContext _blockChainsDbContext;

        //Main Chain containing all the mined blocks
       // public List<Block> Chain { get; set; }

        //This is how many zeroes should be in front of hash
        public int Difficulty { get; set; } = 5;

        //Transactions which are to be mined in next round
       // public List<Transaction> PendingTransactions { get; set; }

        //Transactions which are being mined in this round
        //public List<Transaction> MiningTransactions { get; set; }

        public BlockChain(BlockChainsDbContext blockChainsDbContext)
        {
          //  PendingTransactions = new List<Transaction>();
           // MiningTransactions = new List<Transaction>();
            _blockChainsDbContext = blockChainsDbContext;
            //if (!blockChainsDbContext.SupplyBlocks.Any())
            //{
            //    this.AddBlock(GetGenesisBlock(1));
            //}
        }

        public Block GetGenesisBlock(int chainId)
        {
            return new Block("", new Transaction(), Difficulty, chainId);
            // return Chain[Chain.Count - 1];
        }

        public  Block GetLatestBlock()
        {
           var x = _blockChainsDbContext.SupplyBlocks.OrderByDescending(x=> x.BlockId).FirstOrDefault();
            return new Block
            {
                BlockId = x.BlockId,
                ChainId = x.ChainId,
                CurrentHash = x.CurrentHash,
                Data = x.Data,
                Nounce = x.Nounce,
                PreviousHash = x.PreviousHash,
                BlockAddedTimeStamp = x.BlockAddedTimeStamp
            };
           // return Chain[Chain.Count - 1];
        }

        //Adds mined block to chain
        public void AddBlock(Block MinedBlock)
        {
           // Chain.Add(MinedBlock);
            _blockChainsDbContext.SupplyBlocks.Add(MinedBlock.ToSupplyBlock());
            _blockChainsDbContext.SaveChanges();
            //MiningTransactions = new List<Transaction>();
        }

        //Creates a new transaction
        public async void CreateTransaction(Transaction transaction)
        {
            _blockChainsDbContext.PendingTransaction.Add(transaction);
            await _blockChainsDbContext.SaveChangesAsync();
        }

        //Checks if blockchain is valid or not
        public bool IsChainValid(int chainId=1)
        {
            var Chain = _blockChainsDbContext.SupplyBlocks
                .Where(x=> x.ChainId== chainId)
                 .Select(x => new Block
                 {
                     BlockId = x.BlockId,
                     ChainId = x.ChainId,
                     CurrentHash = x.CurrentHash,
                     Data = x.Data,
                     Nounce = x.Nounce,
                     PreviousHash = x.PreviousHash,
                     BlockAddedTimeStamp = x.BlockAddedTimeStamp
                 })
                .ToList();
            for (int i = 1; i < Chain.Count; i++)
            {
                var currentBlock = Chain[i];
                var previousBlock = Chain[i - 1];
                if(currentBlock.CurrentHash != CalculteHashOfBlock(currentBlock))
                {
                    return false;
                }
                if(currentBlock.PreviousHash != previousBlock.CurrentHash)
                {
                    return false;
                }
            }
            return true;
        }

        //Calculates hash of a block
        private string CalculteHashOfBlock(Block block)
        {
            var transactionString = String.Empty;
            transactionString += block.Transactions.ToString();
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(block.PreviousHash + transactionString + block.Nounce.ToString() + block.BlockAddedTimeStamp.Trim());
            byte[] hash = sha256.ComputeHash(bytes);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

    }
}
