using Blog.DTOs;

namespace Blog.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        public void AddComment(CommentDto commentDto);
        public void AddCommentPost(PostCommentDto postCommentDto);
        public void AddCommentPostUser(PostCommentUserDto postCommentUserDto);
        public void AddCommentToPost(int postId, CommentDto commentDto);
        public List<PostCommentUserDto> GetComments();
        public PostCommentUserDto GetCommentById(int commentId);
        public void DeleteComment(int commentId);
        public void UpdateComment(int commentId, CommentDto commentDto);
        public void UpdateCommentPost(int commentId, PostCommentDto commentPostDto);
    }
}
