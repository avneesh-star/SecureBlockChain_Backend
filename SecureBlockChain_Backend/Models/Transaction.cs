using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SecureBlockChain_Backend.Models
{
    public class Transaction
    {
      
        public Guid Id { get; set; } = Guid.NewGuid();
        public int UserId { get; set; }
        public int SchemeId { get; set; }
        public string Type { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CreatedBy { get; set; }

        public override string ToString()
        {
            return (Id.ToString()+UserId.ToString() + SchemeId.ToString() + Type + Quantity.ToString().Trim() + Rate.ToString() + TransactionDate.ToString() );
        }
    }
}
