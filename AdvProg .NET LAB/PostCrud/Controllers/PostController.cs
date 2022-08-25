using PostCrud.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostCrud.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            var db = new Entities();
            var posts = db.Posts.ToList();

            return View(posts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Post p)
        {
            var db = new Entities();

            db.Posts.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var db = new Entities();
            var post = (from p in db.Posts
                        where p.id == id
                        select p).SingleOrDefault();

            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new Entities();
            var post = (from p in db.Posts
                        where p.id == id
                        select p
                        ).SingleOrDefault();
            return View(post);

        }

        [HttpPost]
        public ActionResult Edit(Post p)
        {
            var db = new Entities();
            var post = (from ep in db.Posts
                        where ep.id == p.id
                        select ep
                        ).SingleOrDefault();

            post.username = p.username;
            post.post_desc = p.post_desc;
            post.likes = p.likes;
            post.dislikes = p.dislikes;
            post.tag = p.tag;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}