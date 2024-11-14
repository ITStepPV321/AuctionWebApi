using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Login;
using AuctionWebApi.Infrastructure.DTOs.Update;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<UserDto> users = _userService.GetAll();

            return Ok(users);
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

        // REVIEW: Вхід учасника аукціону в систему (Створення сесії)
        [HttpPost("login")]
        public async Task<IActionResult> LoginPost([FromBody] LoginUserDto userDto)
        {
            string token = await _userService.Login(userDto);

            return Ok(token);
        }

        // REVIEW: Вихід учасника аукціону із системи (Видалення сесії)
        [HttpPost("logout")]
        public async Task<IActionResult> LogoutPost()
        {
            await _userService.Logout();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] UpdateUserDto userDto)
        {
            userDto.Id = id;
            await _userService.Update(userDto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _userService.Delete(id);

            return Ok();
        }
    }
}