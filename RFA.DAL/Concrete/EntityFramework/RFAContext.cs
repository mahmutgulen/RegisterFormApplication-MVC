using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFA.DAL.Concrete.EntityFramework
{
    public class RFAContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PH12VSS;Database=CvCreator;User Id=DESKTOP-PH12VSS\mako; integrated security=true; TrustServerCertificate=True;");

        }

        //public DbSet<User> Users { get; set; }
    }
}
