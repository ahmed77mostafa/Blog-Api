using Blog.Data;
using Blog.DTOs;
using Blog.Models;
using Blog.Repositories.Interfaces;

namespace Blog.Repositories.Implements
{
    public class PostReactionRepository : IPostReactionRepository
    {
        private readonly AppDbContext _context;

        public PostReactionRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddReaction(int postId,int userId, ReactionDto reactionDto)
        {
            var Post = _context.Posts.FirstOrDefault(i => i.Id == postId);
            var User = _context.Users.FirstOrDefault(i => i.Id == userId);
            if (Post == null & User == null)
                return;

 
            PostReaction postReaction = new PostReaction
            {
                Post = Post,
                Reaction =new Reaction
                {
                    Type = reactionDto.Type,
                },
                User = User
            };
            if (postReaction==null)
            {
                Post.PostReactions.Add(postReaction);
                _context.SaveChanges();

            }
            _context.PostReactions.Add(postReaction);
            _context.SaveChanges(); 
        }
    }
}
