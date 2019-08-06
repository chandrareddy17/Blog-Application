using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CooperVision.Models
{
    public class BlogsViewModel
    {
        public int ID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}