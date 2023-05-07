namespace CuratorsWebApi.Models
{
    public class Curator
    {
        public int curatorId { get; set; }
        public string? firstName { get; set; }
        public string? secondName { get; set; }
        public string? lastName { get; set; }
        public string? academicTitle { get; set; }
        public int? facultyId { get; set; }
        public string? photoSource { get; set; }
    }
}
