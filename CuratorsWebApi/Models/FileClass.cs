namespace CuratorsWebApi.Models
{
    public class FileClass
    {
        public int FileClassId { get; set; }
        public string Name { get; set; }
        public string Type_id { get; set; }
        public string Description { get; set; }
        public DateTime UploadDate { get; set; }
        public byte[] Source { get; set; }
        public DateTime AcademicStartYear { get; set; }
        public int Semester { get; set; }
        public int faculty_id { get; set; }
    }
}
