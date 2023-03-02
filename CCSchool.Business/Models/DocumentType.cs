using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Business.Models
{
    public class DocumentType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public List<Document> Documents { get; set; }

        public DocumentType()
        {
            Documents = new List<Document>();
        }
    }
}
