using Microsoft.AspNetCore.Mvc;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {
        // Membuat array of string yang berisi data user.
        private static List<UserData> listUserData = new List<UserData>()
        {
            new UserData("Deva Raja", 1302204058, "devarj00", "singa00"),
            new UserData("Saeful Anwar",1302204001, "saefulanw88", "hiu88"),
            new UserData("Asyrafbilal", 1302204002, "asyrafbll99", "elang99"),
            new UserData("Bellamy Insan", 1302204003, "bellamyik22", "zebra22"),
            new UserData("Melvin Justinus", 1302204004, "melvinj66", "badak66")
        };

        // GET: api/UserData.
        [HttpGet]
        public IEnumerable<UserData> Get()
        {
            return listUserData;
        }

        // GET api/UserData.
        [HttpGet("{id}")]
        public UserData Get(int id)
        {
            return listUserData[id];
        }

        // POST api/UserData.
        [HttpPost]
        public void Post([FromBody] UserData value)
        {
            listUserData.Add(value);
        }

        // DELETE api/UserData.
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listUserData.RemoveAt(id);
        }
    }
}
