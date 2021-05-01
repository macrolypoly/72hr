using _72hr.Models;
using _72hr.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _72hr.Controllers
{
    public class PostController : ApiController
    {
        private  PostServices CreatePostService()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var sPostservice = new PostServices(userid);
            return sPostservice;


        }
        public IHttpActionResult CreatePost(PostCreate model)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
                
            }
            if (model is null)
                return BadRequest("You cannot have an empty post");
            var spost = CreatePostService();
            if (!spost.CreatePost(model))
            {
                return BadRequest("Post cannot be added");
            }
            return Ok("Post succesfully created");
        }
        [HttpGet]
        public IHttpActionResult GetAllPost()
        {
            var spost = CreatePostService();
            var post = spost.GetAllPost();
            return Ok(post);
        }
    }
}
