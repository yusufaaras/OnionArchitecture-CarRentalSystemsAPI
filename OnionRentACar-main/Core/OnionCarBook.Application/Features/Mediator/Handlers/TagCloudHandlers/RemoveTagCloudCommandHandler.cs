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
//    public class RemovePricingCommandHandler : IRequestHandler<RemoveTagCloudCommand>
//    {
//        private readonly IRepository<TagCloud> _repository;

//        public RemovePricingCommandHandler(IRepository<TagCloud> repository)
//        {
//            _repository = repository;
//        }
//        public async Task Handle(RemoveTagCloudCommand request, CancellationToken cancellationToken)
//        {
//            var value = await _repository.GetByIdAsync(request.Id);
//            await _repository.RemoveAsync(value);
//        }
//    }
//}
