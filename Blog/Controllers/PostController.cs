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
        private readonly IPostRepository _repo;
        public PostController(IPostRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var p=_repo.GetPost(id);
            return Ok(p);   
        }
        [HttpPost]
        public IActionResult Add(PostDto post)
        {
            _repo.Add(post);
            return Created();
        }
        [HttpPut]
        public IActionResult Put(int id,PostDto post)
        {
            _repo.Update(id, post);
            return Ok("Updated");

        }
    }
}
