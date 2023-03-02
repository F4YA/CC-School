using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Business.Models
{
    public class Coordinator : Person
    {
        public int Id { get; set; }
        public string User { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
