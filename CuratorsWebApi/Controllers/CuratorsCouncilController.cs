using Microsoft.AspNetCore.Mvc;
using CuratorsWebApi.Models;
using System.Collections;

namespace SwaggerTest.Controllers
{
    [Route("/api/[controller]")]
    public class CuratorsCouncilController : Controller
    {
        private static List<Faculty> faculties = new List<Faculty>();
        private static List<Curator> curators = new List<Curator>();

        [HttpGet]
        public IEnumerable<Curator> GetAllCurators() => curators;

        [HttpGet("{id}")]
        public IActionResult GetNameAndNUrl(int id)
        {
            var faculty = faculties.SingleOrDefault(p => p.FacultyId == id);
            ArrayList result = new ArrayList() { faculty.Name, faculty.NameUrl };

            return Ok(result);
        }
    }
}
