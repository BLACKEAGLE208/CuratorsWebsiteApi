using Microsoft.AspNetCore.Mvc;
using CuratorsWebApi.Models;

namespace SwaggerTest.Controllers
{
    [Route("/api/[controller]")]
    public class CuratorController : Controller
    {
        private CuratorsContext db;
        public CuratorController(CuratorsContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult GetAllCurators()
        {
            return Ok(db.Curators);
        }


        [HttpGet("{id}")]
        public IActionResult GetCuratorById(int id)
        {
            var curator = db.Curators.SingleOrDefault(p => p.curatorId == id);
            
            return Ok(curator);
        }
    }
}
