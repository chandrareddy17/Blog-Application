using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperVision.Repository;

namespace CooperVision.Services
{
    public class CommentService : ICommentService
    {
        
        private readonly IRepository repository;

        public CommentService(IRepository repository)

        {
            this.repository = repository;
        }
        public List<Comment> GetComments(int blogId)
        {
            return repository.GetComments(blogId);
        }

        public void SaveComment(Comment newComment)
        {
            repository.SaveComment(newComment);
        }
    }
}
