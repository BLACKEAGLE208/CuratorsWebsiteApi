using Microsoft.AspNetCore.Mvc;
using CuratorsWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CuratorsWebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AdminController : Controller
    {
        CuratorsContext db;
        public AdminController(CuratorsContext context)
        {
            db = context;
            if (!db.Curators.Any())
            {
                db.Curators.Add(new Curator { firstName = "iPhone X", lastName = "Apple" });
                db.Curators.Add(new Curator { firstName = "Galaxy S8", lastName = "Samsung" });
                db.Curators.Add(new Curator { firstName = "Pixel 2", lastName = "Google" });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Curator> Get()
        {
            return db.Curators.ToList();
        }

        [HttpGet("{id}")]
        public Curator Get(int id)
        {
            Curator curator = db.Curators.FirstOrDefault(x => x.curatorId == id);
            return curator;
        }

        [HttpPost]
        public IActionResult Post(Curator curator)
        {
            if (ModelState.IsValid)
            {
                db.Curators.Add(curator);
                db.SaveChanges();
                return Ok(curator);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Curator curator)
        {
            if (ModelState.IsValid)
            {
                db.Update(curator);
                db.SaveChanges();
                return Ok(curator);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Curator curator = db.Curators.FirstOrDefault(x => x.curatorId == id);
            if (curator != null)
            {
                db.Curators.Remove(curator);
                db.SaveChanges();
            }
            return Ok(curator);
        }
    }
}
