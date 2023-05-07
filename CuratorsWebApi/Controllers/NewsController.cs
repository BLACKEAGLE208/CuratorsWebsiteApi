using CuratorsWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuratorsWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class NewsController : Controller
    {
        private CuratorsContext db;
        public NewsController(CuratorsContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult GetAllNews()
        {
            return Ok(db.News);
        }

        /*public IActionResult GetAllMainNews()
        {
            return Ok(db.News);
        }*/

        [HttpGet("number")]
        public IActionResult GetLastNews(int number)
        {
            List<NewsItem> list = new List<NewsItem>();

            for (int i = db.News.Count() - number; i < db.News.Count(); i++)
            {
                list.Add(db.News.SingleOrDefault(p => p.newsItemId == i+1));
            }

            return Ok(list);
        }

        [HttpGet("id")]
        public IActionResult GetNewsItem(int id)
        {
            var newsItem = db.News.SingleOrDefault(p => p.newsItemId == id);

            return Ok(newsItem);
        }

        [HttpGet("titleTranslition")]
        public IActionResult GetNewsItemByTitleTranslition(string titletranslition)
        {
            var newsItem = db.News.SingleOrDefault(p => p.titleTranslition == titletranslition);

            return Ok(newsItem);
        }

        [HttpPost]
        public IActionResult PostNewsItem(NewsItem newsItem)
        {
            db.News.Add(newsItem);
            db.SaveChangesAsync();
            return Ok(newsItem);
        }
    }
}
