using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myStore.Controllers
{
    public class OrdersController : ApiController
    {
        // GET: api/Orders
        public IEnumerable<string> Get()
        {
            return new string[] { "item1", "item2" };
        }

        // GET: api/Orders/5
        public string Get(int id)
        {
            return "item1";
        }

        // POST: api/Orders
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
