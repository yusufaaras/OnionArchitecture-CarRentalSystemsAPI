using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarBook.Application.Features.Mediator.Queries.LocationQueries;
using OnionCarBook.Application.Features.Mediator.Results.FeatureResults;
using OnionCarBook.Application.Features.Mediator.Results.LocationResults;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;
        public GetPricingByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                LocationID = values.LocationID,
                Name = values.Name
            };
        }
    }
}
