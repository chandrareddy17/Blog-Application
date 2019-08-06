using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CooperVision.Repository;
using CooperVision.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CooperVision.Test
{
    [TestClass]
    public class UnitTest1
    {
        public List<Blog> SetupBlogData()
        {
            var blogEntities = new List<Blog> { new Blog { CreatedDateTime = new DateTime(1990, 1, 1),
            ID=1,BlogContent="Blog Conent"}, new Blog { CreatedDateTime = new DateTime(1990, 1, 1) ,ID=2} };
            return blogEntities;
        }
        [TestMethod]
        public void Get_AllBlogs()
        {
            var mockRepository = new Mock<IRepository>();
           
            var blogEntities = new List<Blog> { new Blog { CreatedDateTime = new DateTime(1990, 1, 1) }, new Blog { CreatedDateTime = new DateTime(1990, 1, 1) } };
            mockRepository.Setup(x => x.GetAllBlogs()).Returns(blogEntities);
            BlogService blogService = new BlogService(mockRepository.Object);
            
            //Act
            var response = blogService.GetAllBlogs();

            //Assert
            Assert.AreEqual(blogEntities.Count, response.Count);
            Assert.AreEqual(blogEntities, response);
        }
        
    }
}
