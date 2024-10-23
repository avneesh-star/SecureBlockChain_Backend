using Microsoft.EntityFrameworkCore;
using SecureBlockChain_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureBlockChain_Backend.Data
{
    public class BlockChainsDbContext:DbContext
    {
        public BlockChainsDbContext(DbContextOptions<BlockChainsDbContext> options):base(options)
        {

        }

        public DbSet<StoreBlockChains> AllBlockChains { get; set; }
        public DbSet<SupplyBlock> SupplyBlocks { get; set; }
        public DbSet<Verifier_1Block> Verifier_1Blocks { get; set; }
        public DbSet<Verifier_2Block> Verifier_2Blocks { get; set; }
        public DbSet<Verifier_3Block> Verifier_3Blocks { get; set; }

        public DbSet<ProductInfo> ProductsInfos { set; get; }
        public DbSet<SchemeInfo> schemeInfos { set; get; }

        public DbSet<User> UserAccounts { get; set; }
        public DbSet<Transaction> PendingTransaction { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Map SupplyBlocks to a table called "SupplyBlocks"
                modelBuilder.Entity<SupplyBlock>()
                    .ToTable("SupplyBlocks")
                    .HasKey(b => b.BlockId);  // Assuming BlockId is the primary key

                // Map Verifier_1Blocks to a table called "Verifier_1Blocks"
                modelBuilder.Entity<Verifier_1Block>()
                    .ToTable("Verifier_1Blocks")
                    .HasKey(b => b.BlockId);

                // Map Verifier_2Blocks to a table called "Verifier_2Blocks"
                modelBuilder.Entity<Verifier_2Block>()
                    .ToTable("Verifier_2Blocks")
                    .HasKey(b => b.BlockId);

                // Map Verifier_3Blocks to a table called "Verifier_3Blocks"
                modelBuilder.Entity<Verifier_3Block>()
                    .ToTable("Verifier_3Blocks")
                    .HasKey(b => b.BlockId);

                base.OnModelCreating(modelBuilder);
            }
        }
    
}
