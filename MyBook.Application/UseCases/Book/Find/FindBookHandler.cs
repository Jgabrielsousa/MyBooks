using MyBook.Application.Results;
using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;
using MyBook.Application.UseCases.Book.Find;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Book.Find
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
            var bookList = _repo.GetAll();

            var bookListDtos = new List<BookDto>();
            var salesListDtos = new List<SaleTypeDto>();
            var subjectListDtos = new List<SubjectDto>();


            foreach (var book in bookList)
            {

                salesListDtos = new List<SaleTypeDto>();
                subjectListDtos = new List<SubjectDto>();

                foreach (var salesType in book.SaleTypeBook)
                {

                   salesListDtos.Add(new SaleTypeDto
                    {
                        Id = salesType.SaleType.Id,
                        Value = salesType.SaleType.Value,
                        Description = salesType.SaleType.Description
                    });
                }

                foreach (var subject in book.SubjectBook)
                {

                    subjectListDtos.Add(new SubjectDto
                    {
                        Id = subject.Subject.Id,
                        Description = subject.Subject.Description
                    });
                }


                bookListDtos.Add(new BookDto()
                {
                    Id = book.Id,
                    AuthorId = book.AuthorBook.First().AuthorId,
                    Title = book.Title,
                    PublishingCompany = book.PublishingCompany,
                    Edition = book.Edition,
                    PublicationDate = book.PublicationDate,
                    Subjects = subjectListDtos,
                    SaleTypes = salesListDtos
                });
            }

            Result.Data = bookListDtos;

            return Task.FromResult(Result);
        }
    }
}
