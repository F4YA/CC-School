using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Business.Models
{
    public abstract class Person
    {
        public int PersonId { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; private set; }
        public DateOnly Birth { get; set; }

        public List<Document> Documents { get; set; }
        public List<Phone> Phones { get; set; }

        public Person()
        {
            Documents = new List<Document>();
            Phones = new List<Phone>();
        }
    }
}
