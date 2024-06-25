using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Commands
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
    }
}
