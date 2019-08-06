using AutoMapper;
using CooperVision.Models;
using CooperVision.Repository;
using CooperVision.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CooperVision.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogService blogService;
        private readonly ICommentService commentService;
        private readonly IMapper mapper;


        public HomeController(IBlogService blogService, ICommentService commentService, IMapper mapper)
        {
            this.commentService = commentService;
            this.blogService = blogService;
            this.mapper = mapper;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetAllBlogs()
        {
            var blogs = this.blogService.GetAllBlogs();
            var blogeViewModel = mapper.Map<List<Blog>, List<BlogsViewModel>>(blogs);
            return View("AllBlogs", blogeViewModel);

        }
        [HttpPost]
        public ActionResult PostBlog(BlogViewModel blogViewModel)
        {
            Blog blog = new Blog();
            blog = mapper.Map<BlogViewModel, Blog>(blogViewModel);
            blog.CreatedDateTime = DateTime.Now;
            this.blogService.SaveBlog(blog);
            return RedirectToAction("GetAllBlogs");
        }
        [HttpGet]

        public ActionResult CreateBlog()
        {
            return View("CreateBlog");
        }
        [HttpGet]
        public ActionResult GetBlogById(int blogId)
        {
            BlogViewModel blogViewModel = new BlogViewModel();
            List<CommentViewModel> commentViewModels = new List<CommentViewModel>();
            var blog = blogService.GetBlogById(blogId);
            blogViewModel = mapper.Map<Blog, BlogViewModel>(blog);
            var comments = commentService.GetComments(blogId);
            commentViewModels = mapper.Map<List<Comment>, List<CommentViewModel>>(comments);
            blogViewModel.CommentViewModel = commentViewModels;

            return View("GetBlog", blogViewModel);
        }
        [HttpPost]
        public ActionResult PostComment(CommentViewModel commentViewModel)
        {
            Comment comment = new Comment();
            comment = mapper.Map<CommentViewModel, Comment>(commentViewModel);
            comment.CreatedDateTime = DateTime.Now;
            this.commentService.SaveComment(comment);
            return RedirectToAction("GetBlogById", new RouteValueDictionary(
    new { blogId = commentViewModel.BlogId }));
        }
        [HttpGet]
        public ActionResult Cancel()
        {
            return RedirectToAction("GetAllBlogs");
        }
    }
}