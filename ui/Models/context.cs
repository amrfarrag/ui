using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ui.Models
{
    public static class context
    {
        public static List<Project> getdb()
        {
            List<Project> projects = new List<Project>() {
            new Project() {
            ProjectID = 0,
            ProjectName = "cargel",
            Employers = new List<Employer>()
                                 {
                                     new Employer() { EmployerID=0,EmployerCode=100,EmployerName="amr"},
                                     new Employer() {EmployerID=1,EmployerCode=101,EmployerName="hassan" },
                                     new Employer() {EmployerID=2,EmployerCode=102,EmployerName="moamen" }
                                 },

                          },
            new Project() {
            ProjectID = 1,
            ProjectName = "schools",
            Employers = new List<Employer>()
                                 {
                                     new Employer() { EmployerID=0,EmployerCode=100,EmployerName="msaid"},
                                     new Employer() {EmployerID=1,EmployerCode=101,EmployerName="msaad" },
                                     new Employer() {EmployerID=2,EmployerCode=102,EmployerName="ibrahim" }
                                 },
                            }
            };
            return projects;
        }
        public static List<Employer> getemployers()
        {
            List<Employer> employers = new List<Employer>()
            {
                                     new Employer() { EmployerID=0,EmployerCode=100,EmployerName="msaid"},
                                     new Employer() {EmployerID=1,EmployerCode=101,EmployerName="msaad" },
                                     new Employer() {EmployerID=2,EmployerCode=102,EmployerName="ibrahim" },
                                     new Employer() { EmployerID=0,EmployerCode=100,EmployerName="amr"},
                                     new Employer() {EmployerID=1,EmployerCode=101,EmployerName="hassan" },
                                     new Employer() {EmployerID=2,EmployerCode=102,EmployerName="moamen" }
            };
            return employers;

        }
    }
}