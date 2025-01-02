using Blog.Data;
using Blog.DTOs;
using Blog.Models;
using Blog.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Blog.Repositories.Implements
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(UserDto user)
        {
            var u = new User()
            {
                Userame = user.Username
            };    
            _context.Users.Add(u);
            _context.SaveChanges();
        }

        public IList<UserPostReactionDto> GetAll()
        {
            var users = _context.Users
                .Include(p => p.Post)
                .ThenInclude(c => c.Comments)
                .Include(pr => pr.PostReaction)
                .Select(i => new UserPostReactionDto
                {
                    Username = i.Userame,
                    Post = i.Post.Select(p => new PostCommentDto
                    {
                        Title = p.Title,
                        Content = p.Content,
                        Comments = p.Comments.Select(c => new CommentDto
                        {
                            Text = c.Text,
                        }).ToList()
                    }).ToList(),
                    PostReaction = new PostReactionDto
                    {   
                        Post = new PostDto
                        {
                            Title = i.PostReaction.Post.Title,
                            Content = i.PostReaction.Post.Content,
                        },
                        Reaction = new ReactionDto
                        {
                            Type = i.PostReaction.Reaction.Type
                        }
                    }
                }).ToList();

            if (users == null)
            {
                return null;
            }
            return users;

        }

        public User GetById(int id)
        {
            var u=_context.Users.FirstOrDefault(x => x.Id == id);
            return u;
        }
    }
}
