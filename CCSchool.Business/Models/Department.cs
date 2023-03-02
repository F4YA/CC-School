using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Business.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Coordinator> Coordinators { get; set; }

        public Department()
        {
            Coordinators = new List<Coordinator>();
        }
    }
}
