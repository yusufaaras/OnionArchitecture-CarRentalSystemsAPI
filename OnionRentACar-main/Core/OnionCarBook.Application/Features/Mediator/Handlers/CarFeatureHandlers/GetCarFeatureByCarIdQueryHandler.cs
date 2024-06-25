//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OnionCarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
//using OnionCarBook.Application.Features.Mediator.Queries.LocationQueries;
//using OnionCarBook.Application.Features.Mediator.Results.BlogResults;
//using OnionCarBook.Application.Features.Mediator.Results.CarFeatureResults;
//using OnionCarBook.Application.Features.Mediator.Results.LocationResults;
//using OnionCarBook.Application.Interfaces;
//using OnionCarBook.Application.Interfaces.BlogInterfaces;
//using OnionCarBook.Application.Interfaces.CarFeatureInterfaces;
//using OnionCarBook.Domain.Entities;

//namespace OnionCarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
//{
//    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
//    {
//        private readonly ICarFeatureRepository _repository;
//        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
//        {
//            var values = _repository.GetCarFeaturesByCarID(request.Id);
//            return values.Select(x => new GetCarFeatureByCarIdQueryResult
//            {
//                Available = x.Available,
//                CarFeatureID = x.CarFeatureID,
//                FeatureID = x.FeatureID,
//                FeatureName=x.Feature.Name
//            }).ToList();
//        }
//    }
//}
