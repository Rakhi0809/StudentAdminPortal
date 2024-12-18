using Microsoft.EntityFrameworkCore;
using Studentadmin_Poratl.Models.Entities;

namespace Studentadmin_Poratl.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
       {
        }

        public DbSet<Student> Students { get; set; }

    }
    }

