using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
        public class AuthController : ControllerBase
    {

        private readonly IAuthRespository _repon;
        public AuthController(IAuthRespository repon)
        {
            _repon = repon;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(userForRegisterDto userForRegister)
        {
            userForRegister.username = userForRegister.username.ToLower();
            if (await _repon.ExitsUser(userForRegister.username))
                return BadRequest("Username already exists");

            var userToCreat = new User
            {
                UserName = userForRegister.username
            };

            var createdUser = await _repon.Register(userToCreat, userForRegister.password);

            return StatusCode(201);
        }
    }
}