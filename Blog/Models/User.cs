namespace Blog.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Userame { get; set; }
        public List<Post> Post { get; set; }
        public PostReaction PostReaction { get; set; }
    }
}
