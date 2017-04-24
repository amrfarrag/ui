using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ui.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public IEnumerable<Employer> Employer { get; set; }
    }
}