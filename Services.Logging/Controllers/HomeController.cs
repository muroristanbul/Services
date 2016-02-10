using System.Collections.Generic;
using System.Web.Http;

namespace Services.Logging.Controllers
{
    public class HomeController : ApiController
    {
        // GET: api/Home
        public IEnumerable<string> Get()
        {
            return new string[] { "murat", "orhan", "Talha", "Irmak", "asdasdasda", "sigortam.net", "deneme", "istanbul" };
        }

        // GET: api/Home/5
        public string Get(int id)
        {
            return "value" + id;
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
