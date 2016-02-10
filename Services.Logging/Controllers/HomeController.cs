using System;
using System.Collections.Generic;
using System.Web.Http;
using Nest;
using Services.Logging.Models;

namespace Services.Logging.Controllers
{
    public class HomeController : ApiController
    {
        // GET: api/Home
        public IEnumerable<PersonModel> Get()
        {
            var node = new Uri("http://search-logging-4b4ahpkoiumas4xso6qbqrcel4.eu-west-1.es.amazonaws.com");
            var settings = new ConnectionSettings(node);
            var client = new ElasticClient(settings);

            var list = new List<PersonModel>
            {
                new PersonModel {Name = "Murat", City = "Sinop"},
                new PersonModel {Name = "Orhan", City = "Muğla"}
            };

            var person = new PersonModel
            {
                Id = "1",
                Name = "Murat",
                City = "Sinop"
            };

            //var index = client.Index(person, i => i
            //    .Index("deneme-index")
            //    .Type("deneme-type")
            //    .Refresh()
            //    .Ttl("10m")
            //    );

            var index = client.Index(list, z => z.Index("deneme-index").Type("deneme-type"));

            //var index = client.Index(list, z => z
            //    .Index("deneme-index")
            //    .Type("deneme-type")
            //    .Refresh()
            //    .Ttl("10m"));

            //var index = client.Index(list, i => i
            //    .Index("another-index")
            //    .Type("another-type")
            //    .Id("1-should-not-be-the-id")
            //    .Refresh()
            //    .Ttl("1m"));

            return list;
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
