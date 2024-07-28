using MyBook.Application.Results;
using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Author.FindById
{
    public class FindByIdAuthorHandler : Handler<FindByIdAuthorCommand, FindByIdAuthorHandler>
    {
      
        private readonly IAuthorRepository _repo;
        public FindByIdAuthorHandler(IAuthorRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(FindByIdAuthorCommand request, CancellationToken cancellationToken)
        {
            Result.Data = _repo.Find(request.Id);

            return Task.FromResult(Result);
        }
    }
}
