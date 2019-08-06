using CooperVision.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperVision.Services
{
    public interface IBlogService
    {
        Blog GetBlogById(int blogId);
        List<Blog> GetAllBlogs();
        void SaveBlog(Blog blog);
    }
}
