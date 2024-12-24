using Microsoft.AspNetCore.Mvc;
using Result_Pattern_WebAPI.IServices;
using Result_Pattern_WebAPI.Models.Entities;

namespace Result_Pattern_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) => _userService = userService;

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userService.GetUsersAsync();
            return result.IsSuccess ? Ok(result) : BadRequest(result.Error);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUser(User user)
        {
            var result = await _userService.CreateUserAsync(user);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Error);
        }
    }
}
