﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ui.Models;

namespace ui.Controllers
{
    public class ProjectAPIController : ApiController
    {

        // GET: api/ProjectAPI
        public IEnumerable<Project> Get()
        {

            return context.getdb();
        }

        // GET: api/ProjectAPI/5
        public Project Get(int id)
        {
            return context.getdb().Find(t =>t.ProjectID==id);
        }

        // POST: api/ProjectAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProjectAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProjectAPI/5
        public void Delete(int id)
        {
        }
    }
}
