using CooperVision.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperVision.Services
{
    public interface ICommentService
    {
        List<Comment> GetComments(int blogId);
        void SaveComment(Comment newComment);
    }
}
