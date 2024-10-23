using System.ComponentModel.DataAnnotations;

namespace SecureBlockChain_Backend.Models
{
    public class SchemeInfo
    {
        [Key]
        public int ShcemeId { get; set; }
        public string ShcemeCode { get; set; }
        public string ShcemeName { get; set; }
    }
}
