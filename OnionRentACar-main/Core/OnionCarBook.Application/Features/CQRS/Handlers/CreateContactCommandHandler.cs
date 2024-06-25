using OnionCarBook.Application.Features.CQRS.Commands;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Handlers
{
    public class CreateContactCommandHandler
    {
        private IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = command.Name,
                Email = command.Email,
                Message = command.Message,
                SendDate = command.SendDate,
                Subject = command.Subject
            });
        }
    }
}
