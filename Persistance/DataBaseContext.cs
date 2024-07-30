using Application;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class DataBaseContext:DbContext, IDataBaseContext
    {
        public DbSet<User> Users { get; set ; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EfCoreCleanArc;User Id=DESKTOP-4PP4QV0;Password=admin123;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
