using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ui.Models;

namespace ui.Controllers
{
    public class EmployerapiController : ApiController
    {
        // GET: api/Employerapi
        public IEnumerable<Employer> Get()
        {
            return context.getemployers();
        }

        // GET: api/Employerapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employerapi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employerapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employerapi/5
        public void Delete(int id)
        {
        }
    }
}
