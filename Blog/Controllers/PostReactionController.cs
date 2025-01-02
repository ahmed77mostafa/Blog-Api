using Blog.DTOs;
using Blog.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostReactionController : ControllerBase
    {
        private readonly IPostReactionRepository _postReactionRepository;

        public PostReactionController(IPostReactionRepository postReactionRepository)
        {
            _postReactionRepository = postReactionRepository;
        }

        [HttpPost]
        public IActionResult AddReaction(int postId, int userId, ReactionDto reactionDto)
        {
            _postReactionRepository.AddReaction(postId,userId, reactionDto);
            return Ok();
        }
    }
}
