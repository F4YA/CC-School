using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Business.Models
{
    public abstract class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; private set; }
        public int Phone { get; set; }
        public DateOnly Birth { get; set; }

        public List<Document> Documents { get; set; }
    }
}
