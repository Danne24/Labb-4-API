using Labb_4___API.Models;
using Labb_4___API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository<User> _userRepo;

        public UsersController(IUserRepository<User> userRepo)
        {
            this._userRepo = userRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                return Ok(await this._userRepo.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, " Can't Get data from database...");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserAndHobbies(int id)
        {
            try
            {
                var result = await this._userRepo.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, " Can't Get data from database...");
            }
        }
    }
}
