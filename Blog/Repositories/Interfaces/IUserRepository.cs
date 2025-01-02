using Blog.DTOs;
using Blog.Models;

namespace Blog.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public IList<UserPostReactionDto> GetAll();
        public void Add(UserDto user);
        public User GetById(int id);
    }
}
