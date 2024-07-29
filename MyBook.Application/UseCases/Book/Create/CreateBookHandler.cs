using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Entities.ManyToMany;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Book.Create
{
    public class CreateBookHandler : Handler<CreateBookCommand, CreateBookHandler>
    {
        private readonly IBookRepository _repo;
        private readonly IAuthorRepository _repoAuthor;
        private readonly IAuthorBookRepository _repoAuthorBook; 
        public CreateBookHandler(IBookRepository repo, IAuthorBookRepository repoAuthorBook, IAuthorRepository repoAuthor)
        {
            _repo = repo;
            _repoAuthorBook = repoAuthorBook;
            _repoAuthor = repoAuthor;
        }

        public override Task<Result> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var authorEntity = _repoAuthor.Find(request.AuthodId);

                if (authorEntity == null)
                {
                    Result.AddNotification("Author not Found", Domain.Enums.ErrorCode.NotFound);
                    return Task.FromResult(Result);
                }

                //Create Book
                var bookEntity = _repo.Add(new BookEntity()
                {
                    Title = request.Title,
                    PublishingCompany = request.PublishingCompany,
                    Edition = request.Edition,
                    PublicationDate = request.PublicationDate

                });

                //Create Relation Tbw Book and New Author 

                _repoAuthorBook.Add(new AuthorBook()
                {
                    AuthorId = authorEntity.Id,
                    BookId = bookEntity.Id
                });

                request.Id = bookEntity.Id;

                Result.Data = request;

            }
            catch (Exception)
            {

                Result.AddNotification("Somenting went wrong", Domain.Enums.ErrorCode.InternalError);
                return Task.FromResult(Result);
            }

          

           



          

            return Task.FromResult(Result);
        }
    }
}
