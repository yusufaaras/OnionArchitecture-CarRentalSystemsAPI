using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Queries
{
    public class GetCategoryByIdQuery
    {
        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
