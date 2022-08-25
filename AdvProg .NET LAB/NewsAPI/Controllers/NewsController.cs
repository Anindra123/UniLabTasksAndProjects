using NewsAPI.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsAPI.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/news/get")]
        [HttpGet]
        public HttpResponseMessage GetNews()
        {
            var db = new TestDBEntities();
            var news = db.News.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, news);
            
        }

        [Route("api/news/create")]
        [HttpPost]

        public HttpResponseMessage CreateNews(News news)
        {
            var db = new TestDBEntities();
            db.News.Add(news);
            db.SaveChanges();
            var output = db.News.Last();
            return Request.CreateResponse(HttpStatusCode.OK, output);

        }

        [Route("api/news/update/{id}/{news}")]
        [HttpPut]

        public HttpResponseMessage UpdateNews(News news,int id)
        {
            var db = new TestDBEntities();
            var u_news = (from n in db.News
                        where n.id == id
                        select n
                        ).SingleOrDefault();

            if(u_news != null)
            {
                u_news.title = news.title;
                u_news.description = news.description;
                u_news.type = news.type;
                u_news.date = news.date;
                db.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK, u_news);
            }
           
        }

        [Route("api/news/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteNews(int id)
        {
            var db = new TestDBEntities();
            var news = (from n in db.News
                        where n.id == id
                        select n
                        ).SingleOrDefault();
            db.News.Remove(news);
            var newslist = db.News.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, newslist);

        }

    }
}
