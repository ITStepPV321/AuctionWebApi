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

        // TODO: Отримання усіх учасників аукціону
        [HttpGet]
        public IActionResult Get()
        {
            // Logic

            return Ok();
        }

        // TODO: Отримання учасника аукціону за Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // Logic

            return Ok();
        }

        // TODO: Реєстрація нового учасника аукціону
        [HttpPost("register")]
        public IActionResult RegisterPost([FromBody] string value)
        {
            // Logic

            return Ok();
        }

        // TODO: Вхід учасника аукціону в систему (Створення сесії)
        [HttpPost("login")]
        public IActionResult LoginPost([FromBody] string value)
        {
            // Logic

            return Ok();
        }

        // TODO: Вихід учасника аукціону із системи (Видалення сесії)
        [HttpPost("logout")]
        public IActionResult LogoutPost([FromBody] string value)
        {
            // Logic

            return Ok();
        }

        // TODO: Редагування учасника аукціону
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            // Logic

            return Ok();
        }

        // TODO: Видалення учасника аукціону
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Logic

            return Ok();
        }
    }
}