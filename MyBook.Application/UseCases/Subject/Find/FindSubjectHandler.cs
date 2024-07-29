using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Subject.Find
{
    public class FindSubjectHandler : Handler<FindSubjectCommand, FindSubjectHandler>
    {
        private readonly ISubjectRepository _repo;
        public FindSubjectHandler(ISubjectRepository repo)
        {
            _repo = repo;
        }
       

        public override Task<Result> Handle(FindSubjectCommand request, CancellationToken cancellationToken)
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
