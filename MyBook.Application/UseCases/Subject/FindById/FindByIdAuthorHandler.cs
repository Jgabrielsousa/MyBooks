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
            Result.Data = _repo.Find(request.Id);

            return Task.FromResult(Result);
        }
    }
}
