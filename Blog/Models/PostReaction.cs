namespace Blog.Models
{
    public class PostReaction
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int ReactionId { get; set; }
        public Reaction Reaction { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
