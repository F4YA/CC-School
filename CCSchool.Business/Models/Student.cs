using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Business.Models
{
    public class Student : Person
    {
        public int RA { get; set; }
        public string Nationality { get; set; }
        public string PicLink { get; set; }
        public bool Cortesy { get; set; }
    }
}
