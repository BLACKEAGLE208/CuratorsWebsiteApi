namespace CuratorsWebApi.Models
{
    public class Curator
    {
        public int CuratorId { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? AcademicTitle { get; set; }
        public int? faculty_id { get; set; }
        public byte[]? PhotoSource { get; set; }
    }
}
