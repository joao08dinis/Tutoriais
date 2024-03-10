using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class ContosoSchoolContext : DbContext
    {
        public ContosoSchoolContext (DbContextOptions<ContosoSchoolContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Student { get; set; } = default!;
    }
}
