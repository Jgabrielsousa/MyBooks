using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Author.Create
{
    public  class CreateAuthorHandler : Handler<CreateAuthorCommand, CreateAuthorHandler>
    {
        private readonly IAuthorRepository _repo;
        public CreateAuthorHandler(IAuthorRepository repo)
        {
            _repo= repo;
        }

        public override Task<Result> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {

            var entity = _repo.Add(new AuthorEntity() { Name = request.Name });
            Result.Data = entity;

            return Task.FromResult(Result);
        }
    }
}
