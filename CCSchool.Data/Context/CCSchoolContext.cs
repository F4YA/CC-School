using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSchool.Data.Context
{
    internal class CCSchoolContext : DbContext
    {
        public CCSchoolContext(DbContextOptions options) : base(options) { }
    }
}
