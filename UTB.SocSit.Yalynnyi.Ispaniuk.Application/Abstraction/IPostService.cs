using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction
{
    public interface IPostService
    {
        IList<Post> Select(int userId);
        IList<Post> SelectAll();
        IList<Comment> GetComments(int postId);
        IList<Media> GetMedia(int postId);
        void Create(Post post);
        bool Delete(int id);
    }
}
