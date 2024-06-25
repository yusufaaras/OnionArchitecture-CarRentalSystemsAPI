using Microsoft.EntityFrameworkCore;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using OnionCarBook.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Persistence.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;
        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public async Task<List<Car>> GetCarsListWithBrands()
        {
            var values = await _context.Cars.Include(x => x.Brand).ToListAsync();
            return values;
        }
        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;
        }
    }
}
