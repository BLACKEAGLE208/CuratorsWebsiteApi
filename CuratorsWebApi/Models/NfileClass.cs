namespace CuratorsWebApi.Models
{
    public class Nfile
    {
        public int nfileId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string source { get; set; }
        public DateTime uploadDate { get; set; }
        public DateTime academicStartYear { get; set; }
        public int semester { get; set; }
        public int facultyId { get; set; }
    }
}
