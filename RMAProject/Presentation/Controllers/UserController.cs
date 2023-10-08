using Microsoft.AspNetCore.Mvc;
using RMAProject.Domain.Commands;
using RMAProject.Presentation.Services.Implementations;
using RMAProject.Presentation.Services.Interfaces;

namespace RMAProject.Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> RegisterUser(UserRegisterCommand command)
        {
            await _userService.RegisterUser(command);
            return Ok("Usuário criado com sucesso!");
        }
    }
}
