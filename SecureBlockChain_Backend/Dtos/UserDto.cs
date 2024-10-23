using System.ComponentModel.DataAnnotations;

namespace SecureBlockChain_Backend.Dtos
{
    public class UserDto
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string AccessRights { get; set; }
        
    }
}
