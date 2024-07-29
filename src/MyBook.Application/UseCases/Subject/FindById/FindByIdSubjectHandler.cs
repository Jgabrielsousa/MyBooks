using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Subject.FindById
{
    public class FindByIdSubjectHandler : Handler<FindByIdSubjectCommand, FindByIdSubjectHandler>
    {
      
        private readonly ISubjectRepository _repo;
        public FindByIdSubjectHandler(ISubjectRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(FindByIdSubjectCommand request, CancellationToken cancellationToken)
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
