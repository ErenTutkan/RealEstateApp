using Microsoft.EntityFrameworkCore;
using RealEstateApp.Core.Models;
using RealEstateApp.Core.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Repository.Context
{
    public class SqlServerDbContext:DbContext
    {
        private readonly ConnectionStrings _connectionStrings;

        public SqlServerDbContext(ConnectionStrings connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStrings.SqlServer);
            base.OnConfiguring(optionsBuilder);
        }


       public DbSet<Estate> Estates { get; set; }
       public DbSet<Image> Images { get;set; }
    }
}
