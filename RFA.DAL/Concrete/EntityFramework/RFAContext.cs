using Microsoft.EntityFrameworkCore;
using RFA.ENTITY.Concrete;
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
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mako\Documents\rfaDB.mdf;Integrated Security=True;");

        }

        public DbSet<RegistrationInfo> RegistrationInfos { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
    }
}
