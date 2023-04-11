using CuratorsWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuratorsWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class FacultyController : Controller
    {
        private static List<Faculty> faculties = new List<Faculty>();

        [HttpGet]
        public IEnumerable<Faculty> Get() => faculties;

        private int NextFacultyId => faculties.Count() == 0 ? 1 : faculties.Max(x => x.facultyId) + 1;
        [HttpPost]
        public IActionResult Post(Faculty faculty)
        {
            faculty.facultyId = NextFacultyId;
            faculties.Add(faculty);
            return CreatedAtAction(nameof(Get), new { id = faculty.facultyId }, faculty);
        }

        [HttpGet("nameUrl")]
        public IActionResult GetFaculty(string nameurl)
        {
            var faculty = faculties.SingleOrDefault(p => p.nameUrl == nameurl);

            return Ok(faculty);
        }

        [HttpPut("nameUrl")]
        public IActionResult Put(Faculty faculty)
        {
            faculties.Add(faculty);
            
            return Ok(faculty);
        }

    }
}
