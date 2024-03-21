using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Persistance
{
    public interface ICarRepository : IGenericRepository<Car>
    {
        Task<Car> GetCarDetailAsync(int id);
        Task<List<Car>> GetAllInCityAsync(string city);
        Task<List<Car>> GetAllInLocationAsync(int locationid);
        Task<bool> ExistAsync(string plate);
    }
}
