using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CooperVision.Models
{
    public class CommentViewModel
    {
        public int ID { get; set; }
        public int BlogId { get; set; }
        [Required(ErrorMessage ="Comment is required field")]
        public string CommentDescription { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
    }
}