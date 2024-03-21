using Application.Contracts.Persistance;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        private readonly MilesCarRentalDbContext _dbContext;

        public LocationRepository(MilesCarRentalDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
