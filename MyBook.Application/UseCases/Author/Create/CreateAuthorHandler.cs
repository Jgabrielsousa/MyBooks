using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Application.UseCases.Author.Create
{
    public  class CreateAuthorHandler : Handler<CreateAuthorCommand, CreateAuthorHandler>
    {
        public CreateAuthorHandler()
        {
                
        }

        public override Task<Result> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            Result.Data = new CreateAuthorDto(1, "Jhon Snow");

            return Task.FromResult(Result);
        }
    }
}
