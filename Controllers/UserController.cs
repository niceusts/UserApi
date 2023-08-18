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
        /// <summary>
        /// Cria um novo usuário.
        /// </summary>
        /// <param name="user">Dados do usuário a serem criados.</param>
        /// <returns>O resultado da criação do usuário.</returns>
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
