using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarBook.Application.Features.Mediator.Results.BlogResults;

namespace OnionCarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogsWithAuthorsQuery : IRequest<List<GetLast3BlogsWitAuthorsQueryResult>>
    {
    }
}
