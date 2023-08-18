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
        /// Cria um novo usu�rio.
        /// </summary>
        /// <param name="user">Dados do usu�rio a serem criados.</param>
        /// <returns>O resultado da cria��o do usu�rio.</returns>
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
