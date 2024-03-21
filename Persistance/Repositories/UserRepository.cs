using Application.Contracts.Persistance;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly MilesCarRentalDbContext _dbContext;

        public UserRepository(MilesCarRentalDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
