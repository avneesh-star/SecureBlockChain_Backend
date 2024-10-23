using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using SecureBlockChain_Backend.Services;
using System.Threading.Tasks;

namespace SecureBlockChain_Backend.Controllers
{
    
    public class UserController : BaseApiController
    {
        private readonly IUserAccountService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserAccountService userAccountService, ILogger<UserController> logger)
        {
            _userService = userAccountService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsers();
            return Ok(users);
        }
    }
}
