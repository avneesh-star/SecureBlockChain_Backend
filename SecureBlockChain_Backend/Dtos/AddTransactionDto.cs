using System;

namespace SecureBlockChain_Backend.Dtos
{
    public class AddTransactionDto
    {
        
        public int UserId { get; set; }
        public int SchemeId { get; set; }
        public string Type { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CreatedBy { get; set; }
    }

    public class AddFirstTransactionDto
    {
        public string transaction { get; set; }
        public string productInfo { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
