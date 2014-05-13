using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace awesomeBlog.Controllers
{
    public class HomeController : Controller
    {
        //step 1 set up database access
        Models.myBlogEntities db = new Models.myBlogEntities();
        // GET: /Home /

        public ActionResult Index()
        {
            var list = db.Articles.OrderBy(x => x.ArticleDate);
            return View(list);
        }
        public ActionResult Rating(int id)
        {
            var article = db.Articles.Where(x => x.ArticleID == id).First();
            article.ArticlePositiveAppeal += 1;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Comment(int id, FormCollection values)
        {
            //making a new comment
            var comments = new Models.Comment();
            comments.ArticalID = id;
            comments.CommentCreator = values["author"];
            comments.CommentBody = values["body"];
            comments.CommentDate = DateTime.Now;
            comments.CommentRating = 0;
            //add comment to the database
            db.Comments.Add(comments);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
