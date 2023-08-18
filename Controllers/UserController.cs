using Microsoft.AspNetCore.Mvc;
using UserApi.Models;
using UserApi.Services;
/// <summary>
/// Controlador para gerenciamento de usuários.
/// </summary>
namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Construtor do userController
        /// </summary>
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// Cria um novo usuário.
        /// </summary>
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            _userService.AddUser(user);
            return Ok();
        }
        /// <summary>
        /// Pesquisar por usuário.
        /// </summary>
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
