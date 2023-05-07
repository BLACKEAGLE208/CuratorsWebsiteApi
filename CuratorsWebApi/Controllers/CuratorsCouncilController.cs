using Microsoft.AspNetCore.Mvc;
using CuratorsWebApi.Models;
using System.Collections;

namespace CuratorsWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class CuratorsCouncilController : Controller
    {
        private CuratorsContext db;
        public CuratorsCouncilController(CuratorsContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult GetCurators()
        {
            return Ok(db.Curators);
        }


        [HttpPost]
        public async Task<IActionResult> PostCurator(Curator curator)
        {
            db.Curators.Add(curator);
            await db.SaveChangesAsync();
            return Ok(curator);
        }
    }
}
