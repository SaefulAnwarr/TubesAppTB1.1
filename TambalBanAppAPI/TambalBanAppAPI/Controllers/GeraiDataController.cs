using Microsoft.AspNetCore.Mvc;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeraiDataController : ControllerBase
    {
        // Membuat array of string yang berisi data user.
        private static List<GeraiData> listGeraiData = new List<GeraiData>()
        {
            new GeraiData("Gerai Indo Sejati", 0130220, "Jl. Mekar Jaya I No.02"),
            new GeraiData("Gerai Sejuta Kasih", 0130221, "Jl. Sudirman I No.18"),
            new GeraiData("Gerai Merdeka Abadi", 0130222, "Jl. Merkar Jaya II No.07"),
            new GeraiData("Gerai Cinta Ibu", 0130223, "Jl. Proklamasi No.25"),
            new GeraiData("Gerai Semangat Jaya", 0130224, "Jl. Majapahit No.66"),
        };

        // GET: api/GeraiData.
        [HttpGet]
        public IEnumerable<GeraiData> Get()
        {
            return listGeraiData;
        }

        // GET api/GeraiData.
        [HttpGet("{id}")]
        public GeraiData Get(int id)
        {
            return listGeraiData[id];
        }

        // POST api/UserData.
        [HttpPost]
        public void Post([FromBody] GeraiData value)
        {
            listGeraiData.Add(value);
        }

        // DELETE api/GeraiData.
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listGeraiData.RemoveAt(id);
        }
    }
}
