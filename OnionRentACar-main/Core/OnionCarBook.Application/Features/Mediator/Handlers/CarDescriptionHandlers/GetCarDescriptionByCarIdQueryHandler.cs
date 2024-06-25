//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OnionCarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
//using OnionCarBook.Application.Features.Mediator.Results.CarDescriptionResults;
//using OnionCarBook.Application.Interfaces;
//using OnionCarBook.Application.Interfaces.CarDescriptionInterfaces;
//using OnionCarBook.Domain.Entities;

//namespace OnionCarBook.Application.Features.Mediator.Handlers.CarDescriptionHandlers
//{
//    public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionQueryResult>
//    {
//        private readonly ICarDescriptionRepository _repository;
//        public GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<GetCarDescriptionQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
//        {
//            var values = await _repository.GetCarDescription(request.Id);
//            return new GetCarDescriptionQueryResult
//            {
//                CarDescriptionID = values.CarDescriptionID,
//                CarID = values.CarID,
//                Details = values.Details
//            };
//        }
//    }
//}
