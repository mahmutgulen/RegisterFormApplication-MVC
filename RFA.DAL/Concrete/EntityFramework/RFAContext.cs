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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=rfaDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        public DbSet<RegistrationInfo> RegistrationInfos { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
    }
}
