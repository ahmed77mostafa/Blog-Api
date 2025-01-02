using Blog.Data;
using Blog.DTOs;
using Blog.Models;
using Blog.Repositories.Interfaces;

namespace Blog.Repositories.Implements
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;
        public PostRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(PostDto post)
        {
            var p = new Post
            {
                Title = post.Title,
               Content = post.Content,
               User=new User
               {
                   Userame=post.User
               }
            };
            _context.Posts.Add(p);
            _context.SaveChanges();
        }

        public Post GetPost(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Update(int id, PostDto post)
        {
            var p=GetPost(id);
            p.Title = post.Title;
            p.Content = post.Content;
            _context.Posts.Update(p);
            _context.SaveChanges();
        }
    }
}
