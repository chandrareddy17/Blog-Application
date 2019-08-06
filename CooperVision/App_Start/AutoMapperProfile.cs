using AutoMapper;
using CooperVision.Models;
using CooperVision.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CooperVision.App_Start
{
    public class AutoMapperProfile: Profile
    { 
        public AutoMapperProfile()
        {
            CreateMap<Blog, BlogViewModel>().ForMember(x=>x.CommentViewModel, op=>op.Ignore());
            CreateMap<Blog, BlogsViewModel>();
            CreateMap<Comment, CommentViewModel>();
            CreateMap<CommentViewModel, Comment>();
            CreateMap<BlogViewModel, Blog>();
        }
    }
}