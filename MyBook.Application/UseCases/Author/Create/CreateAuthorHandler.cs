﻿using MyBook.Application.Results;
using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Create
{
    public  class CreateAuthorHandler : Handler<CreateAuthorCommand, CreateAuthorHandler>
    {
        public CreateAuthorHandler()
        {
                
        }

        public override Task<Result> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            Result.Data = new AuthorDto(1, "Jhon Snow");

            return Task.FromResult(Result);
        }
    }
}
