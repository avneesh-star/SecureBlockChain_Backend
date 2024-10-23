using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SecureBlockChain_Backend.Data;
using SecureBlockChain_Backend.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace SecureBlockChain_Backend.Services
{
    public interface IUserAccountService
    {
        Task<Response<dynamic>> Login(LoginDto dto);
        Task<Response<dynamic>> GetUsers();
    }

    public class UserAccountService : IUserAccountService
    {
        private readonly BlockChainsDbContext _userContext;
        private readonly IConfiguration _configuration;

        public UserAccountService(BlockChainsDbContext userContext, IConfiguration configuration)
        {
            _userContext = userContext;
            _configuration = configuration;
        }


        public async Task<Response<dynamic>> Login(LoginDto dto)
        {
            var user = await _userContext.UserAccounts.FirstOrDefaultAsync(m => m.UserName == dto.userName && m.Password == dto.password);
            if (user == null)
            {
                return Response<dynamic>.Failed("Invalid username or password!");
            }
            DateTime tokenExpirey = DateTime.Now.AddMinutes(30);
            var res = new LoginResponseDto
            {
                userName = dto.userName,
                fullName = user.FullName,
                accessToken = GenerateToken(user.ID, user.UserName, tokenExpirey),
                tokenExpires = tokenExpirey,
                AccessRights = user.AccessRights,
            };
            return Response<dynamic>.Success(res);

        }

        private string GenerateToken(int userId, string username, DateTime tokenExpirey)
        {
            var claims = new[]
                 {
                    new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                    new Claim(ClaimTypes.Name, username)
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: tokenExpirey,
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<Response<dynamic>> GetUsers()
        {
            var users = await _userContext.UserAccounts
                .Where(x => x.AccessRights == "user")
                .Select(x=> new UserDto 
                { 
                    ID=x.ID,
                    UserName=x.UserName,
                    FullName=x.FullName,
                    EmailID=x.EmailID,
                    AccessRights=x.AccessRights,
                })
                .AsNoTracking()
                .ToListAsync();
               
                

            return Response<dynamic>.Success(users);
        }

    }
}
