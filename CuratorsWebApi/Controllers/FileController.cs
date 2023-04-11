using CuratorsWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuratorsWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class FileController : Controller
    {
        private static List<Nfile> nfiles = new List<Nfile>();
        private static List<Faculty> faculties = new List<Faculty>();

        /*
        [HttpGet("{nameUrl}")]
        public IActionResult GetCurator(string nameurl)
        {
            var file = nfiles.SingleOrDefault(p => p.nfileId == id);

            return Ok(file);
        }
        */
    }
}
