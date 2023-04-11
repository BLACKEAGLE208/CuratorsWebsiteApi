namespace CuratorsWebApi.Models
{
    public class NewsItem
    {
        public int newsItemId { get; set; }
        public string title { get; set; }
        public string titleTranslition { get; set; }
        public string annotation { get; set; }
        public DateTime publishDate { get; set;}
        public string mainImageSource { get; set;}
    }
}
