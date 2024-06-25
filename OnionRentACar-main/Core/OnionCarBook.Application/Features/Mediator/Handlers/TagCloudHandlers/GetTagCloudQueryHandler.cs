//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OnionCarBook.Application.Features.Mediator.Queries.TagCloudQueries;
//using OnionCarBook.Application.Features.Mediator.Results.FeatureResults;
//using OnionCarBook.Application.Features.Mediator.Results.TagCloudResults;
//using OnionCarBook.Application.Interfaces;
//using OnionCarBook.Domain.Entities;

//namespace OnionCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
//{
//    public class GetServiceQueryHandler : IRequestHandler<GetTagCloudQuery, List<GetTagCloudQueryResult>>
//    {
//        private readonly IRepository<TagCloud> _repository;
//        public GetServiceQueryHandler(IRepository<TagCloud> repository)
//        {
//            _repository = repository;
//        }
//        public async Task<List<GetTagCloudQueryResult>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
//        {
//            var values = await _repository.GetAllAsync();
//            return values.Select(x => new GetTagCloudQueryResult
//            {
//                Title = x.Title,
//                TagCloudID = x.TagCloudID,
//                BlogID = x.BlogID
//            }).ToList();
//        }
//    }
//}
