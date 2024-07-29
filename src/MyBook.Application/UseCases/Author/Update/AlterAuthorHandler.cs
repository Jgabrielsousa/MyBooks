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
            try
            {
                var entity = _repo.Find(request.Id);
                entity.Name = request.Author.Name;
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
