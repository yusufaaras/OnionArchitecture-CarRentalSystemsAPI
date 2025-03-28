﻿using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByFualElectiricQueryHandler : IRequestHandler<GetCarCountByFualElectiricQuery, GetCarCountByFualElectiricQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetCarCountByFualElectiricQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByFualElectiricQueryResult> Handle(GetCarCountByFualElectiricQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFualElectiric();
            return new GetCarCountByFualElectiricQueryResult
            {
                CarCountByFualElectiric = value
            };
        }
    }
}