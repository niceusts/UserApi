using Microsoft.AspNetCore.Mvc;
using UserApi.Models;
using UserApi.Services;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpGet("{cpf}")]
        public IActionResult GetUser(int cpf)
        {
            var user = _userService.GetUserByCpf(cpf);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
