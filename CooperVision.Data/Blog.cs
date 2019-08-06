using System;
using System.ComponentModel.DataAnnotations;

namespace CooperVision.Data
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
