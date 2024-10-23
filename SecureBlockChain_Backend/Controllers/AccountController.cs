using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SecureBlockChain_Backend.Data;
using SecureBlockChain_Backend.Dtos;
using SecureBlockChain_Backend.Models;
using SecureBlockChain_Backend.Services;

namespace SecureBlockChain_Backend.Controllers
{
    
    public class AccountController : BaseApiController
    {
        private readonly IUserAccountService _accountService;
        public AccountController(IUserAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LogIn(LoginDto dto)
        {
            var response = await _accountService.Login(dto);
            return Ok(response);
        }
    }
}