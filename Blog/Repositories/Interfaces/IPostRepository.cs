using Blog.DTOs;
using Blog.Models;

namespace Blog.Repositories.Interfaces
{
    public interface IPostRepository
    {
        public void Add(PostDto post);
        public void Update(int id,PostDto post);
        public Post GetPost(int id);
    }
}
