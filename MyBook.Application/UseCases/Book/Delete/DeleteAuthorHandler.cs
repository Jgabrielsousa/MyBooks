using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Book.Delete
{
    public class DeleteBookHandler : Handler<DeleteBookCommand, DeleteBookHandler>
    {


        private readonly IBookRepository _repo;
        public DeleteBookHandler(IBookRepository repo)
        {
            _repo = repo;
        }


        public override Task<Result> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var entity = _repo.Find(request.Id);
            _repo.Remove(entity);

            return Task.FromResult(Result);
        }
    }
}
