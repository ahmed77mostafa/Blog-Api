using Blog.DTOs;
using Blog.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactionController : ControllerBase
    {
        private readonly IReactionRepository _repo;
        public ReactionController(IReactionRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add(ReactionDto dto)
        {
            _repo.Add(dto);
            return Created();
        }
    }
}
