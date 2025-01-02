using Blog.DTOs;

namespace Blog.Repositories.Interfaces
{
    public interface IPostReactionRepository
    {
        public void AddReaction(int postId, int userId, ReactionDto reactionDto);
    }
}
