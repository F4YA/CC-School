using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Business.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int PersonId { get; set; }
        public int DocumentTypeId { get; set; }

        public DocumentType DocumentType { get; set; }
    }
}
