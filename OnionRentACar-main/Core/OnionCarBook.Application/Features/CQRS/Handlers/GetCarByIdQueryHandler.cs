using OnionCarBook.Application.Features.CQRS.Queries;
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
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;
        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandID = values.BrandID,
                CarID = values.CarID,
                Transmission = values.Transmission,
                BigImageUrl = values.BigImageUrl,
                CoverImageUrl = values.CoverImageUrl,
                Fuel = values.Fuel,
                Km = values.Km,
                Seat = values.Seat,
                Model = values.Model,
                Luggage = values.Luggage
            };
        }
    }
}
