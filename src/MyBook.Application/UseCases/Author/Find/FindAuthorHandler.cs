using MyBook.Application.Results;
using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Author.Find
{
    public class FindAuthorHandler : Handler<FindAuthorCommand, FindAuthorHandler>
    {
        private readonly IAuthorRepository _repo;
        public FindAuthorHandler(IAuthorRepository repo)
        {
            _repo = repo;
        }
       

        public override Task<Result> Handle(FindAuthorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Result.Data = _repo.GetAll();

            
            }
            catch (Exception)
            {

                Result.AddNotification("Somenting went wrong", Domain.Enums.ErrorCode.InternalError);
            }

            return Task.FromResult(Result);
        }
    }
}
