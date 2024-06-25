//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OnionCarBook.Application.Features.Mediator.Commands.TagCloudCommands;
//using OnionCarBook.Application.Interfaces;
//using OnionCarBook.Domain.Entities;

//namespace OnionCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
//{
//    public class CreatePricingCommandHandler : IRequestHandler<CreateTagCloudCommand>
//    {
//        private readonly IRepository<TagCloud> _repository;
//        public CreatePricingCommandHandler(IRepository<TagCloud> repository)
//        {
//            _repository = repository;
//        }
//        public async Task Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
//        {
//            await _repository.CreateAsync(new TagCloud
//            {
//                Title = request.Title,
//                BlogID = request.BlogID
//            });
//        }
//    }
//}
