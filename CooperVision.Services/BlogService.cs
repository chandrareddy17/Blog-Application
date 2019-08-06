using CooperVision.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperVision.Services
{
    public class BlogService : IBlogService
    {
        private readonly IRepository repository;

        public BlogService(IRepository repository)
        {
            this.repository = repository;
        }

        public Blog GetBlogById(int blogId)
        {
            return repository.GetBlogById(blogId);
        }
        public List<Blog> GetAllBlogs()
        {
            return repository.GetAllBlogs();
        }

        public void SaveBlog(Blog blog)
        {
            repository.SaveBlog(blog);
        }
    }
}
