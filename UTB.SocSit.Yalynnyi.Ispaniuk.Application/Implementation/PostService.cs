using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.Implementation
{
    public class PostService(SocSitDbContext socsitDbContext) : IPostService
    {
        SocSitDbContext _SocSitDbContext = socsitDbContext;

        public IList<Post> Select(int userId)
        {
            return _SocSitDbContext.Posts.Where(p => p.UserID == userId).ToList();
        }

        public IList<Post> SelectAll()
        {
            return _SocSitDbContext.Posts.ToList();
        }

        public IList<Comment> GetComments(int postId)
        {
            return _SocSitDbContext.Comments.Where(c => c.PostID == postId).ToList();
        }

        public void Create(Post post)
        {
            try
            {
                _SocSitDbContext.Posts.Add(post);
                _SocSitDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while creating post: {ex.Message}");
                return;
            }
        }

        public bool Delete(int id) 
        {
            try
            {
                Post postToDelete = _SocSitDbContext.Posts.Find(id);
                if (postToDelete != null)
                {
                    _SocSitDbContext.Remove(postToDelete);
                    _SocSitDbContext.SaveChanges();
                    Console.WriteLine($"Post with ID {id} deleted successfully");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Post with ID {id} not found");
                    return false;
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Error occurred while deleting post: {ex.Message}");
                return false;
            }
        }
    }
}
