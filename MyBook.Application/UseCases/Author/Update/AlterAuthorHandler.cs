using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Author.Create
{
    public class AlterAuthorHandler : Handler<AlterAuthorCommand, AlterAuthorHandler>
    {
       
        private readonly IAuthorRepository _repo;
        public AlterAuthorHandler(IAuthorRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(AlterAuthorCommand request, CancellationToken cancellationToken)
        {
            var entity = _repo.Find(request.Id);
            entity.Name = request.Author.Name;
            _repo.Update(entity);

            return Task.FromResult(Result);
        }
    }
}
