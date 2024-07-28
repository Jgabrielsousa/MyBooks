using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Author.Delete
{
    public class DeleteAuthorHandler : Handler<DeleteAuthorCommand, DeleteAuthorHandler>
    {


        private readonly IAuthorRepository _repo;
        public DeleteAuthorHandler(IAuthorRepository repo)
        {
            _repo = repo;
        }


        public override Task<Result> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            var entity = _repo.Find(request.Id);
            _repo.Remove(entity);

            return Task.FromResult(Result);
        }
    }
}
