using Blog.DTOs;
using Blog.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Users = _userRepo.GetAll();
            return Ok(Users);
        }
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var User = _userRepo.GetUserById(id);
            return Ok(User);
        }
        [HttpPost]
        public IActionResult AddUser(UserDto userDto)
        {
            _userRepo.AddUser(userDto);
            return Created();
        }
        [HttpPost("User-Reaction")]
        public IActionResult AddUserPost(UserReactionDto userReactionDto)
        {
            _userRepo.AddUserReaction(userReactionDto);
            return Created();
        }
        [HttpPost("User-Post-Reaction")]
        public IActionResult AddUserPostReation(UserPostReactionDto userPostReactionDto)
        {
            _userRepo.AddUserPostReaction(userPostReactionDto);
            return Created();
        }
    }
}
