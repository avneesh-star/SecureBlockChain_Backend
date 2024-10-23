using System;

namespace SecureBlockChain_Backend.Dtos
{
    public class LoginDto
    {
        public string password { get; set; }
        public string userName { get; set; }
    }


    public class LoginResponseDto
    {
        public string userName { get; set; }
        public string fullName { get; set; }
        public string AccessRights { get; set; }
        public string accessToken { get; set; }
        public DateTime tokenExpires { get; set; }
    }
}