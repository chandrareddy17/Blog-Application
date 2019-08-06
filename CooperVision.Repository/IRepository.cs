using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperVision.Repository
{
   public interface IRepository
    {
        Blog GetBlogById(int blogId);
        List<Blog> GetAllBlogs();
        void SaveBlog(Blog blog);
        List<Comment> GetComments(int blogId);
        void SaveComment(Comment newComment);
    }
}
