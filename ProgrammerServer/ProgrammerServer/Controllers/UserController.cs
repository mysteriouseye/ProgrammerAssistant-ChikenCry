using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProgrammerServer.Entity;
using ProgrammerServer.Repositories.IRe;

namespace ProgrammerServer.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepositories _userRepositories;

        public UserController(IUserRepositories userRepositories)
        {
            _userRepositories = userRepositories;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Users users)
        {
            Console.WriteLine("23232323");
            var result = await _userRepositories.LoginTask(users);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }

        }
    }
}
