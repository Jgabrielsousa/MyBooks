using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Application.UseCases.Book.Find;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Book.Create
{
    public class FindBookHandler : Handler<FindBookCommand, FindBookHandler>
    {
        private readonly IBookRepository _repo;
        public FindBookHandler(IBookRepository repo)
        {
            _repo = repo;
        }
       

        public override Task<Result> Handle(FindBookCommand request, CancellationToken cancellationToken)
        {
            

            Result.Data = _repo.GetAll();

            return Task.FromResult(Result);
        }
    }
}
