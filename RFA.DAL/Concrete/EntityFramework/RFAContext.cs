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
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmut\source\repos\RegisterFormApplication-MVC\RFA.DAL\DB.mdf;Integrated Security=True");

        }

        public DbSet<RegistrationInfo> RegistrationInfos { get; set; }
        public DbSet<PaymentInfos> PaymentInfos { get; set; }
    }
}
