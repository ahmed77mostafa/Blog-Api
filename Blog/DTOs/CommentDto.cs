using Blog.Models;
using System.ComponentModel.DataAnnotations;

namespace Blog.DTOs
{
    public class CommentDto
    {
        [Required]
        public string Text { get; set; }
    }
    public class CommentPostDto
    {
        [Required]
        public string Text { get; set; }
        public Post Post { get; set; }
    }
}
