using Microsoft.AspNetCore.Mvc;
using CuratorsWebApi.Models;

namespace SwaggerTest.Controllers
{
    [Route("/api/[controller]")]
    public class CuratorController : Controller
    {
        private static List<Curator> curators = new List<Curator>(new[] {
            new Curator() {CuratorId = 1, FirstName = "Magomed",
                                          //SecondName = "Magomedovich",
                                          LastName = "Magomedov",
                                          AcademicTitle = "Doctor" },
            new Curator() {CuratorId = 2, FirstName = "Budaychi",
                                          //SecondName = "Budaychievich",
                                          LastName = "Budaychiev",
                                          AcademicTitle = "Doctor of history" },
            new Curator() {CuratorId = 3, FirstName = "John",
                                          //SecondName = "Capitan",
                                          LastName = "Shepard",
                                          AcademicTitle = "Doctor of physics" },
        });


        [HttpGet]
        public IEnumerable<Curator> Get() => curators;
        

        [HttpGet("{id}")]
        public IActionResult GetCurator(int id)
        {
            var curator = curators.SingleOrDefault(p => p.CuratorId == id);
            
            return Ok(curator);
        }


        private int NextProductId => curators.Count() == 0 ? 1 : curators.Max(x => x.CuratorId) + 1;
        [HttpPost]
        public IActionResult Post(Curator curator) 
        {
            curator.CuratorId = NextProductId;
            curators.Add(curator);
            return CreatedAtAction(nameof(Get), new { id = curator.CuratorId }, curator); 
        }

        [HttpPost("AddCurator")]
        public IActionResult PostBody([FromBody] Curator curator) => Post(curator);

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            curators.Remove(curators.SingleOrDefault(p => p.CuratorId == id));
            return Ok();
        }
    }
}
