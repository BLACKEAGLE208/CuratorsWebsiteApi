using CuratorsWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CuratorsWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class FacultyController : Controller
    {
        private CuratorsContext db;
        public FacultyController(CuratorsContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult GetAllFaculties()
        {
            return Ok(db.Faculties);
        }

        [HttpPost]
        public async Task<IActionResult> PostFaculty(Faculty faculty)
        {
            db.Faculties.Add(faculty);
            await db.SaveChangesAsync();
            return Ok(faculty);
        }

        [HttpGet("id")]
        public IActionResult GetFacultyById(int id)
        {
            var faculty = db.Faculties.SingleOrDefault(p => p.Id == id);

            return Ok(faculty);
        }

        [HttpGet("nameUrl")]
        public IActionResult GetFaculty(string nameurl)
        {
            var faculty = db.Faculties.SingleOrDefault(p => p.nameUrl == nameurl);

            return Ok(faculty);
        }

        [HttpPut("id")]
        public IActionResult Put(Faculty faculty)
        {
            Faculty f = db.Faculties.SingleOrDefault(c => c.Id == faculty.Id);

            f.name = faculty.name;
            f.nameUrl = faculty.nameUrl;
            f.description = faculty.description;
            f.photoSource = faculty.photoSource;
            f.websiteSource = faculty.websiteSource;

            //db.Faculties.Update(faculty);
            db.SaveChangesAsync();

            return Ok(f);
        }

    }
}
