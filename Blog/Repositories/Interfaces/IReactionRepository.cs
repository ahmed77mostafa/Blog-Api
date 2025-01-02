using Blog.DTOs;

namespace Blog.Repositories.Interfaces
{
    public interface IReactionRepository
    {
        public void Add(ReactionDto dto);
    }
}
