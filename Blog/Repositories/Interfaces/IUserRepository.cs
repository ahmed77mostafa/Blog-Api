using Blog.DTOs;
using Blog.Models;

namespace Blog.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public void AddUser(UserDto userDto);
        public void AddUserReaction(UserReactionDto userDto);
        public void AddUserPostReaction(UserPostReactionDto userDto);
        public List<UserPostReactionDto> GetAll();
        public UserPostReactionDto GetUserById(int id);
    }
}
