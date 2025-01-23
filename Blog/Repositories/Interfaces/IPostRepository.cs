using Blog.DTOs;
using Blog.Models;

namespace Blog.Repositories.Interfaces
{
    public interface IPostRepository
    {
        public void AddPost(PostDto postDto);
        public void AddPostComment(PostCommentDto postDto);
        public void AddPostCommentUser(PostCommentUserDto postDto);
        public void UpdatePost(int id, PostDto postDto);
        public void UpdatePostCommentUser(int id, PostCommentUserDto postDto);
        public PostCommentUserDto GetPostById(int id);
        public List<PostCommentUserDto> GetPosts();
    }
}
