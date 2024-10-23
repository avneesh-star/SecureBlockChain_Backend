﻿using SecureBlockChain_Backend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecureBlockChain_Backend.Models
{
    //BlockChain of First Verifier
    public class Verifier_3BlockChain
    {
        private readonly BlockChainsDbContext _blockChainsDbContext;

       // public List<Block> Chain { get; set; }
        public int Difficulty { get; set; } = 5;

        public Verifier_3BlockChain(BlockChainsDbContext blockChainsDbContext)
        {
           
            _blockChainsDbContext = blockChainsDbContext;
        }

      
        public void AddBlock(Block MinedBlock)
        {
            _blockChainsDbContext.Verifier_3Blocks.Add(MinedBlock.ToVerifier_3Block());
            _blockChainsDbContext.SaveChanges();
        }

        public bool IsChainValid(int chainId, Block minedBlock=null)
        {
            var Chain = _blockChainsDbContext.Verifier_3Blocks
                .Where(x => x.ChainId == chainId)
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
            if (minedBlock != null)
                Chain.Add(minedBlock);
            for (int i = 1; i < Chain.Count; i++)
            {
                var currentBlock = Chain[i];
                var previousBlock = Chain[i - 1];
                if (currentBlock.CurrentHash != CalculteHashOfBlock(currentBlock))
                {
                    return false;
                }
                if (currentBlock.PreviousHash != previousBlock.CurrentHash)
                {
                    return false;
                }
            }
            return true;
        }

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
