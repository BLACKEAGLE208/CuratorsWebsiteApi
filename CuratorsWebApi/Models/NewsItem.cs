namespace CuratorsWebApi.Models
{
    public class NewsItem
    {
        public int NewsItemId { get; set; }
        public string Title { get; set; }
        public string Annotation { get; set; }
        public DateTime PublishDate { get; set;}
        public string MainImageSource { get; set;}
    }
}
