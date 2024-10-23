using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SecureBlockChain_Backend.Data;
using SecureBlockChain_Backend.Dtos;
using SecureBlockChain_Backend.Models;

namespace SecureBlockChain_Backend.Controllers
{
    
    public class BlockChainController : BaseApiController
    {
        private BlockChain SecureBlockChain;
        private readonly BlockChainsDbContext _dbContext;

        public BlockChainController(BlockChain blockChain, BlockChainsDbContext sdb)
        {

            _dbContext = sdb;
            SecureBlockChain = blockChain;
        }

        [HttpGet]
        public async Task<IActionResult> GetChain()
        {
            var chain =await _dbContext.SupplyBlocks.ToListAsync();
            return Ok(chain);
        }
       
        [HttpPost("transaction")]
        public async Task<IActionResult> CreateTransaction(AddTransactionDto dto)
        {
            Transaction transaction = new Transaction
            {
                Id = Guid.NewGuid(),
                UserId = dto.UserId,
                SchemeId = dto.SchemeId,
                Type = dto.Type,
                Quantity = dto.Quantity,
                Rate = dto.Rate,
                TransactionDate = dto.TransactionDate,
                CreatedBy = dto.CreatedBy,

            };
            _dbContext.PendingTransaction.Add(transaction);
            await _dbContext.SaveChangesAsync();
                        return  Ok("True");
                    
        }

        
    }
}