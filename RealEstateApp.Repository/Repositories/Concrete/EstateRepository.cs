using RealEstateApp.Core.Models;
using RealEstateApp.Repository.Context;
using RealEstateApp.Repository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Repository.Repositories.Concrete
{
    public class EstateRepository : GenericRepository<Estate>, IEstateRepository
    {
        public EstateRepository(SqlServerDbContext connection) : base(connection)
        {
        }
    }
}
