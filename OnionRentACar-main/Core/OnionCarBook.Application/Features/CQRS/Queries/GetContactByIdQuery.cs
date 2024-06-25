using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Queries
{
    public class GetContactByIdQuery
    {
        public GetContactByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
