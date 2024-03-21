using Application.Contracts.Persistance;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        private readonly MilesCarRentalDbContext _dbContext;

        public CarRepository(MilesCarRentalDbContext dbContext) :base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> ExistAsync(string plate)
        {
            var car = await _dbContext.Cars.FirstOrDefaultAsync(x=>x.NumberPlate == plate);
            return car!= null;
        }

        public async Task<List<Car>> GetAllInCityAsync(string city)
        {
            return await _dbContext.Set<Car>().Where(x => x.Location.City == city && x.Status == false).Include(x=>x.Location).ToListAsync();
        }

        public async Task<List<Car>> GetAllInLocationAsync(int idLocation)
        {
            return await _dbContext.Set<Car>().Where(x=>x.LocationId == idLocation && x.Status==false).Include(x=>x.Location).ToListAsync();
        }

        public async Task<Car> GetCarDetailAsync(int id)
        {
            return await _dbContext.Set<Car>().Where(x => x.Id==id).Include(x => x.Location).Include(x=>x.User).FirstOrDefaultAsync();
        }
    }
}
