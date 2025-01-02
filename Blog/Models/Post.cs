namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content {  get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public List<PostReaction> PostReactions { get; set; }
    }
}
