using OnionCarBook.Application.Features.CQRS.Results;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
               CarID = x.CarID,
               BrandID = x.BrandID,
               BigImageUrl = x.BigImageUrl,
               CoverImageUrl = x.CoverImageUrl,
               Fuel = x.Fuel,
               Km = x.Km,
               Luggage = x.Luggage,
               Model = x.Model,
               Seat = x.Seat,
               Transmission= x.Transmission
            }).ToList();
        }
    }
}
