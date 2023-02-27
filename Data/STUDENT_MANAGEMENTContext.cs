using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using STUDENT_MANAGEMENT.Model;

namespace STUDENT_MANAGEMENT.Data
{
    public class STUDENT_MANAGEMENTContext : DbContext
    {
        public STUDENT_MANAGEMENTContext (DbContextOptions<STUDENT_MANAGEMENTContext> options)
            : base(options)
        {
        }

        public DbSet<STUDENT_MANAGEMENT.Model.Student> Student { get; set; } = default!;
    }
}
