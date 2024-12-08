using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Login;
using AuctionWebApi.Infrastructure.DTOs.Read;
using AuctionWebApi.Infrastructure.DTOs.Update.User;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            List<UserDto> users = _userService.GetAll();

            return Ok(users);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("get")]
        public IActionResult Get()
        {
            string userId = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value!;
            
            UserDto user = _userService.GetById(userId);

            return Ok(user);
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            UserDto user = _userService.GetById(id);

            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterPost([FromBody] CreateUserDto userDto)
        {
            await _userService.Register(userDto);

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginPost([FromBody] LoginUserDto userDto)
        {
            string token = await _userService.Login(userDto);

            return Ok(token);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("logout")]
        public async Task<IActionResult> LogoutPost()
        {
            await _userService.Logout();

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("change-username")]
        public async Task<IActionResult> Put([FromBody] UpdateUserNameDto userDto)
        {
            userDto.Id = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value!;
            await _userService.UpdateUserName(userDto);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("change-email")]
        public async Task<IActionResult> Put([FromBody] UpdateEmailDto userDto)
        {
            userDto.Id = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value!;
            await _userService.UpdateEmail(userDto);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("change-password")]
        public async Task<IActionResult> Put([FromBody] UpdatePasswordDto userDto)
        {
            userDto.Id = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value!;
            await _userService.UpdatePassword(userDto);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("delete-user")]
        public async Task<IActionResult> Delete()
        {
            string userId = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value!;

            await _userService.Delete(userId);

            return Ok();
        }
    }
}