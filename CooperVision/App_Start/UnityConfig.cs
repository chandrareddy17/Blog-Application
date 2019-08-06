using System.Web.Mvc;
using Unity;
using CooperVision.Services;
using Unity.Mvc5;
using AutoMapper;
using CooperVision.App_Start;
using CooperVision.Repository;

namespace CooperVision
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IBlogService, BlogService>();
            container.RegisterType<CooperVision.Repository.IRepository, CooperVision.Repository.Repository>();
            container.RegisterType<ICommentService, CommentService>();
            container.RegisterInstance<IMapper>(config.CreateMapper());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}