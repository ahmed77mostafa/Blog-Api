using Blog.DTOs;
using Blog.Repositories.Interfaces;

namespace Blog.Repositories.Implements
{
    public class CommentRepository : ICommentRepository
    {
        public void AddComment(CommentDto commentDto)
        {
            throw new NotImplementedException();
        }

        public void AddCommentPost(PostCommentDto postCommentDto)
        {
            throw new NotImplementedException();
        }

        public void AddCommentPostUser(PostCommentUserDto postCommentUserDto)
        {
            throw new NotImplementedException();
        }

        public void AddCommentToPost(int postId, CommentDto commentDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public PostCommentUserDto GetCommentById(int commentId)
        {
            throw new NotImplementedException();
        }

        public List<PostCommentUserDto> GetComments()
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(int commentId, CommentDto commentDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateCommentPost(int commentId, PostCommentDto commentPostDto)
        {
            throw new NotImplementedException();
        }
    }
}
