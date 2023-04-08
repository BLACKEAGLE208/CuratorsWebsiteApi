namespace CuratorsWebApi.Models
{
    public class User
    {
        public int userId {  get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public DateTime registrationDate { get; set; }
    }
}
