using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CooperVision.Data
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string CommentDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
