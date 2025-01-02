using Blog.Models;

namespace Blog.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
    }    
    public class UserPostDto
    {
        public string Username { get; set; }
        public List<PostCommentDto> Posts { get; set; }
    }     
    public class UserReactionDto
    {
        public string Username { get; set; }
        public PostReactionDto Reaction { get; set; }
    }   

    public class UserPostReactionDto
    {
        public string Username { get; set; }
        public List<PostCommentDto> Post { get; set; }
        public PostReactionDto PostReaction { get; set; }
    }
}
