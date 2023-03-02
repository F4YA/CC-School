using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Business.Models
{
    public class Instructor : Person
    {
        public int Id { get; set; }
        public string User { get; set; }
        public bool Active { get; set; }

        public List<Subject> Subjects { get; set; }

        public Instructor()
        {
            Subjects = new List<Subject>();
        }
    }
}
