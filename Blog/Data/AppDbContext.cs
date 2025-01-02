using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostReaction>()
                .HasKey(pr => new {pr.PostId, pr.ReactionId, pr.UserId});

            modelBuilder.Entity<PostReaction>()
                .HasOne(p => p.Post)
                .WithMany(pr => pr.PostReactions)
                .HasForeignKey(p => p.PostId);

            modelBuilder.Entity<PostReaction>()
                .HasOne(r => r.Reaction)
                .WithMany(pr => pr.PostReactions)
                .HasForeignKey(r => r.ReactionId);
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
