﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarBook.Application.Features.Mediator.Results.LocationResults;

namespace OnionCarBook.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}
