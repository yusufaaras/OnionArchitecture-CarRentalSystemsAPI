﻿//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OnionCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
//using OnionCarBook.Application.Features.Mediator.Results.StatisticsResults;
//using OnionCarBook.Application.Interfaces.StatisticsInterfaces;

//namespace OnionCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
//{
//    public class GetCarBrandAndModelByRentPriceDailyMinQueryHandler : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMinQuery, GetCarBrandAndModelByRentPriceDailyMinQueryResult>
//    {
//        private readonly IStatisticsRepository _repository;

//        public GetCarBrandAndModelByRentPriceDailyMinQueryHandler(IStatisticsRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<GetCarBrandAndModelByRentPriceDailyMinQueryResult> Handle(GetCarBrandAndModelByRentPriceDailyMinQuery request, CancellationToken cancellationToken)
//        {
//            var value = _repository.GetCarBrandAndModelByRentPriceDailyMin();
//            return new GetCarBrandAndModelByRentPriceDailyMinQueryResult
//            {
//                CarBrandAndModelByRentPriceDailyMin = value
//            };
//        }
//    }
//}
