using CuratorsWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuratorsWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class NewsController : Controller
    {
        private static List<NewsItem> news = new List<NewsItem>();

        [HttpGet]
        public IEnumerable<NewsItem> Get() => news;


        [HttpGet("{id}")]
        public IActionResult GetNewsItem(int id)
        {
            var newsItem = news.SingleOrDefault(p => p.newsItemId == id);

            return Ok(newsItem);
        }

        [HttpGet("{titleTranslition}")]
        public IActionResult GetNewsItemByTitleTranslition(string titletranslition)
        {
            var newsItem = news.SingleOrDefault(p => p.titleTranslition == titletranslition);

            return Ok(newsItem);
        }
    }
}
