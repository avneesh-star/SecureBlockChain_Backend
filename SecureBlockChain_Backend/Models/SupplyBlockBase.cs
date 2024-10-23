using System.ComponentModel.DataAnnotations;

namespace SecureBlockChain_Backend.Models
{
    public class SupplyBlockBase
    {
        
        [Key]
        public int BlockId { get; set; }
        public int ChainId { get; set; }
        public string CurrentHash { get; set; }
        public string Data { get; set; }
        public ulong Nounce { get; set; }
        public string PreviousHash { get; set; }
        public string BlockAddedTimeStamp { get; set; }
    }
}