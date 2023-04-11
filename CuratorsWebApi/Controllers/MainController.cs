using Microsoft.AspNetCore.Mvc;
using CuratorsWebApi.Models;
using System.Collections;

namespace CuratorsWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class MainController : Controller
    {
        private static List<Faculty> faculties = new List<Faculty>();

        [HttpGet("{id}")]
        public IActionResult GetNameAndNUrl(int id)
        {
            var faculty = faculties.SingleOrDefault(p => p.facultyId == id);
            ArrayList result = new ArrayList() { faculty.name, faculty.nameUrl };

            return Ok(result);
        }
    }
}
