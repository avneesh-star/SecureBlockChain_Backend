using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecureBlockChain_Backend.Models
{
    //Class for storing blockchains in database
    public class StoreBlockChains
    {
        [Key]
        public int BlockChainID { get; set; }
        //Difficulty of blockChain
        public int Difficulty { get; set; }

    }
}
