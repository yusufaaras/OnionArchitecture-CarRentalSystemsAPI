using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarBook.Application.Features.Mediator.Results.PricingResults;

namespace OnionCarBook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery:IRequest<List<GetPricingQueryResult>>
    {

    }
}
