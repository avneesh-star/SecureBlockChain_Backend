using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecureBlockChain_Backend.Models
{
    public class Block
    {
        [Key]
        public int BlockId { get; set; }
        //Stores the current hash of the block after mining
        public string CurrentHash { get; set; }

        //Stores the hash of the previous block
        public string PreviousHash { get; set; }

        //This is to get proof of work
        public ulong Nounce { get; set; }

        public string Data { get; set; }
        //This Contains all the transaction that are added to this block
        [NotMapped]
        public Transaction Transactions { get { return System.Text.Json.JsonSerializer.Deserialize<Transaction>(this.Data); } set { } }

        //Time and date when this block is created
        public string BlockAddedTimeStamp { get; set; }

        public int ChainId {  get; set; }


        public Block() { }
        public Block(string previousHash, Transaction transactions, int Difficulty, int chainId=1)
        {
            var now = DateTime.Now;
            BlockAddedTimeStamp = now.ToLongDateString() + " " + now.ToLongTimeString();
            Nounce = 0;
            ChainId = chainId;
            CurrentHash = CalculateHash(transactions.ToString());
            PreviousHash = previousHash;
            Transactions = transactions;
            Data = System.Text.Json.JsonSerializer.Serialize(transactions);
            
        }

        //Mining of block
        public async Task MineBlock(int Difficulty)
        {
            var tempString = String.Empty;
            await Task.Run(() =>
            {
                
                tempString += Transactions.ToString();
                CurrentHash = CalculateHash(tempString);
                //Proof of work i.e. first five characters of hash should be 0
                while (CurrentHash.Substring(0, Difficulty) != new string('0', Difficulty))
                {
                    Nounce++;
                    CurrentHash = CalculateHash(tempString);
                }
            });
        }

        //Function to calculate hash of block
        private string CalculateHash(string transactionString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(PreviousHash + transactionString + Nounce.ToString() + BlockAddedTimeStamp.Trim());
            byte[] hash = sha256.ComputeHash(bytes);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        public SupplyBlock ToSupplyBlock()
        {
            return new SupplyBlock 
            {
              
                BlockId= this.BlockId,
                ChainId = this.ChainId,
                CurrentHash =this.CurrentHash,
                Data = this.Data,
                Nounce =this.Nounce,
                PreviousHash =this.PreviousHash,
                BlockAddedTimeStamp =this.BlockAddedTimeStamp
            };
            
        }

        public Verifier_1Block ToVerifier_1Block()
        {
            return new Verifier_1Block
            {

                BlockId = this.BlockId,
                ChainId = this.ChainId,
                CurrentHash = this.CurrentHash,
                Data = this.Data,
                Nounce = this.Nounce,
                PreviousHash = this.PreviousHash,
                BlockAddedTimeStamp = this.BlockAddedTimeStamp
            };
           
        }

        public Verifier_2Block ToVerifier_2Block()
        {
            return new Verifier_2Block
            {

                BlockId = this.BlockId,
                ChainId = this.ChainId,
                CurrentHash = this.CurrentHash,
                Data = this.Data,
                Nounce = this.Nounce,
                PreviousHash = this.PreviousHash,
                BlockAddedTimeStamp = this.BlockAddedTimeStamp
            };
        }
        public Verifier_3Block ToVerifier_3Block()
        {
            return new Verifier_3Block
            {

                BlockId = this.BlockId,
                ChainId = this.ChainId,
                CurrentHash = this.CurrentHash,
                Data = this.Data,
                Nounce = this.Nounce,
                PreviousHash = this.PreviousHash,
                BlockAddedTimeStamp = this.BlockAddedTimeStamp
            };
        }
    }
}
