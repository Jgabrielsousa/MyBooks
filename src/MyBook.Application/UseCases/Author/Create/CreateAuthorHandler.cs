using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Author.Create
{
    public  class CreateAuthorHandler : Handler<CreateAuthorCommand, CreateAuthorHandler>
    {
        private readonly IAuthorRepository _repo;
        public CreateAuthorHandler(IAuthorRepository repo)
        {
            _repo= repo;
        }

        public override Task<Result> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _repo.Add(new AuthorEntity() { Name = request.Name });

                request.Id = entity.Id;
                Result.Data = request;
            }
            catch (Exception)
            {

                Result.AddNotification("Somenting went wrong", Domain.Enums.ErrorCode.InternalError);
            }

         

            return Task.FromResult(Result);
        }
    }
}
