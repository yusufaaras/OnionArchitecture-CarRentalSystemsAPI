//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OnionCarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
//using OnionCarBook.Application.Interfaces.CarFeatureInterfaces;
//using OnionCarBook.Domain.Entities;

//namespace OnionCarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
//{
//    public class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
//    {
//        private readonly ICarFeatureRepository _repository;

//        public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
//        {
//            _repository.CreateCarFeatureByCar(new CarFeature
//            {
//                Available = false,
//                CarID = request.CarID,
//                FeatureID = request.FeatureID
//            });
//        }
//    }
//}
