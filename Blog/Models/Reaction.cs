namespace Blog.Models
{
    public class Reaction
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<PostReaction> PostReactions { get; set; }
    }
}
