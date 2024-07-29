using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Book.Update
{
    public class AlterBookHandler : Handler<AlterBookCommand, AlterBookHandler>
    {
       
        private readonly IBookRepository _repo;
        public AlterBookHandler(IBookRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(AlterBookCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var entity = _repo.Find(request.Id);
                entity.Title = request.Book.Title;
                entity.PublishingCompany = request.Book.PublishingCompany;
                entity.Edition = request.Book.Edition;
                entity.PublicationDate = request.Book.PublicationDate;
                _repo.Update(entity);
            }
            catch (Exception)
            {

                Result.AddNotification("Somenting went wrong", Domain.Enums.ErrorCode.InternalError);
            }
           

            return Task.FromResult(Result);
        }
    }
}
