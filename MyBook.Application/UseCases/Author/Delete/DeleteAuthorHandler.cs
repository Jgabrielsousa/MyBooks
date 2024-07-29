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
            try
            {
                var entity = _repo.Find(request.Id);

                if (entity == null)
                {
                    Result.AddNotification("Author not Found", Domain.Enums.ErrorCode.NotFound);
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
