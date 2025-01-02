using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public Post Post { get; set; }
    }
}
