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
//    public class GetBlogTitleByMaxBlogCommentQueryHandler : IRequestHandler<GetBlogTitleByMaxBlogCommentQuery, GetBlogTitleByMaxBlogCommentQueryResult>
//    {
//        private readonly IStatisticsRepository _repository;

//        public GetBlogTitleByMaxBlogCommentQueryHandler(IStatisticsRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<GetBlogTitleByMaxBlogCommentQueryResult> Handle(GetBlogTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
//        {
//            var value = _repository.GetBlogTitleByMaxBlogComment();
//            return new GetBlogTitleByMaxBlogCommentQueryResult
//            {
//                BlogTitleByMaxBlogComment = value
//            };
//        }   
//    }
//}
