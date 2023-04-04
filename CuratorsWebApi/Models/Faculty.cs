namespace CuratorsWebApi.Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }
        public string NameUrl { get; set; }
        public string Description { get; set; }
        public byte[] PhotoSource { get; set; }
        public byte[] WebsiteSource { get; set; }
    }
}
