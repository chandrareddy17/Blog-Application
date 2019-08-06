using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperVision.Repository
{
   public class Repository : IRepository
    {
        private CooperVisionEntities1 db = new CooperVisionEntities1();

        public List<Blog> GetAllBlogs()
        {
            return db.Blogs.OrderByDescending(x => x.CreatedDateTime).ToList();
        }

        public Blog GetBlogById(int blogId)
        {
            var blog = db.Blogs.FirstOrDefault(x => x.ID == blogId);
            return blog;
        }

        public List<Comment> GetComments(int blogId)
        {
            var comments = db.Comments.Where(x => x.BlogId == blogId).OrderByDescending(x => x.CreatedDateTime).ToList();
            return comments;
        }

        public void SaveBlog(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
        }

        public void SaveComment(Comment newComment)
        {
            db.Comments.Add(newComment);
            db.SaveChanges();
        }
    }
}
