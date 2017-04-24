using System;
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
        List<Project> projects = new List<Project>() {
            new Project() {
            ProjectID = 0,
            ProjectName = "cargel",
            Employer = new List<Employer>()
                                 {
                                     new Employer() { EmployerID=0,EmployerCode=100,EmployerName="amr"},
                                     new Employer() {EmployerID=1,EmployerCode=101,EmployerName="hassan" },
                                     new Employer() {EmployerID=2,EmployerCode=102,EmployerName="moamen" }
                                 },

                          },
            new Project() {
            ProjectID = 1,
            ProjectName = "schools",
            Employer = new List<Employer>()
                                 {
                                     new Employer() { EmployerID=0,EmployerCode=100,EmployerName="msaid"},
                                     new Employer() {EmployerID=1,EmployerCode=101,EmployerName="msaad" },
                                     new Employer() {EmployerID=2,EmployerCode=102,EmployerName="ibrahim" }
                                 },
                            }
            };
        // GET: api/ProjectAPI
        public IEnumerable<Project> Get()
        {

            return projects;
        }

        // GET: api/ProjectAPI/5
        public string Get(int id)
        {
            return "value";
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
