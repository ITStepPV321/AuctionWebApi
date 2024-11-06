using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Login;
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

        // ACHTUNG: Наступні дії робити лише завдяки сервісу!!!

        // REVIEW: Отримання усіх учасників аукціону
        [HttpGet]
        public IActionResult Get()
        {
            List<UserDto> users = _userService.GetAll();

            return Ok(users);
        }

        // REVIEW: Отримання учасника аукціону за Id
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            //   UserDto user = _userService.GetById(id);

            //return Ok(user);
            return Ok();
        }

        // REVIEW: Реєстрація нового учасника аукціону
        [HttpPost("register")]
        public async Task<IActionResult> RegisterPost([FromBody] CreateUserDto userDto)
        {
         //   await _userService.Register(userDto);

            return Ok();
        }

        // REVIEW: Вхід учасника аукціону в систему (Створення сесії)
        [HttpPost("login")]
        public async Task<IActionResult> LoginPost([FromBody] LoginUserDto userDto)
        {
            // string token = await _userService.Login(userDto);

            //  return Ok(token);
            return Ok();
        }

        // REVIEW: Вихід учасника аукціону із системи (Видалення сесії)
        [HttpPost("logout")]
        public async Task<IActionResult> LogoutPost()
        {
           // _userService.Logout();

            return Ok();
        }

        // REVIEW: Редагування учасника аукціону
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] UserDto user)
        {
          //  await _userService.Update(user);

            return Ok();
        }

        // REVIEW: Видалення учасника аукціону
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
          //  await _userService.Delete(id);

            return Ok();
        }
    }
}