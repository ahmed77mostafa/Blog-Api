using Blog.Models;

namespace Blog.DTOs
{
    public class PostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string User { get; set; }
    }
    public class PostUserDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }
    public class PostCommentDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
    public class PostCommentUserDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}
