using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Book.Create
{
    public class CreateBookHandler : Handler<CreateBookCommand, CreateBookHandler>
    {
        private readonly IBookRepository _repo;
        public CreateBookHandler(IBookRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {

            var entity = _repo.Add(new BookEntity()
            {
                Title = request.Title,
                PublishingCompany = request.PublishingCompany,
                Edition = request.Edition,
                PublicationDate = request.PublicationDate

            });
            Result.Data = entity;

            return Task.FromResult(Result);
        }
    }
}
