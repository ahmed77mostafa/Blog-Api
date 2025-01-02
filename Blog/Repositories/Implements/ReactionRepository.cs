using Blog.Data;
using Blog.DTOs;
using Blog.Models;
using Blog.Repositories.Interfaces;

namespace Blog.Repositories.Implements
{
    public class ReactionRepository : IReactionRepository
    {
        private readonly AppDbContext _context;
        public ReactionRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(ReactionDto dto)
        {
            var r = new Reaction
            {
                Type = dto.Type,
            };
            _context.Reactions.Add(r);
            _context.SaveChanges();
        }
    }
}
