namespace CuratorsWebApi.Models
{
    public class Faculty
    {
        public int facultyId { get; set; }
        public string name { get; set; }
        public string nameUrl { get; set; }
        public string description { get; set; }
        public byte[] photoSource { get; set; }
        public byte[] websiteSource { get; set; }
    }
}
