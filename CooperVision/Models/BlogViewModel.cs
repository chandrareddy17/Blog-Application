using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CooperVision.Models
{
    public class BlogViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Title is required field")]
        public string BlogTitle { get; set; }
        [Required(ErrorMessage ="Content is required field")]
        public string BlogContent { get; set; }
        public List<CommentViewModel> CommentViewModel { get; set; }
       
    }
}