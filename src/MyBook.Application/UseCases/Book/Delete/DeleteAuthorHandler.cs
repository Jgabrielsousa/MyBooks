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
            try
            {
                var entity = _repo.Find(request.Id);

                if (entity == null)
                {
                    Result.AddNotification("Book not Found", Domain.Enums.ErrorCode.NotFound);
                    return Task.FromResult(Result);
                }


                _repo.Remove(entity);
            }
            catch (Exception)
            {

                Result.AddNotification("Somenting went wrong", Domain.Enums.ErrorCode.InternalError);
        
            }

            return Task.FromResult(Result);
        }
    }
}
