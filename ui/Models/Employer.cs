using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ui.Models
{
    public class Employer
    {
        public int EmployerID { get; set; }
        public int EmployerCode { get; set; }
        public string EmployerName { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}