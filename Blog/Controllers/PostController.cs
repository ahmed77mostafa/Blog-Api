using Blog.DTOs;
using Blog.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepo;

        public PostController(IPostRepository postRepo)
        {
            _postRepo = postRepo;
        }

        [HttpGet("{id}")]
        public IActionResult GetPostById(int id)
        {
            var post = _postRepo.GetPostById(id);
            return Ok(post);
        }
        [HttpPost]
        public IActionResult AddPost(PostDto post)
        {
            _postRepo.AddPost(post);
            return Created();
        }
        [HttpPut("{id}")]
        public IActionResult PutPost(int id,PostDto post)
        {
            _postRepo.UpdatePost(id, post);
            return Ok("Updated");
        }
        [HttpPut("{postId}")]
        public IActionResult PutPostCommentUser(int postId, PostCommentUserDto postCommentUserDto)
        {
            _postRepo.UpdatePostCommentUser(postId, postCommentUserDto);
            return Ok("Updated");
        }
    }
}
