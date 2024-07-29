using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Book.FindById
{
    public class FindByIdBookHandler : Handler<FindByIdBookCommand, FindByIdBookHandler>
    {
      
        private readonly IBookRepository _repo;
        public FindByIdBookHandler(IBookRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(FindByIdBookCommand request, CancellationToken cancellationToken)
        {

            try
            {
                Result.Data = _repo.Find(request.Id);

              
            }
            catch (Exception)
            {

                Result.AddNotification("Somenting went wrong", Domain.Enums.ErrorCode.InternalError);
            }
            return Task.FromResult(Result);



        }
    }
}
