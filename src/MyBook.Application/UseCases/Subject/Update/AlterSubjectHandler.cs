using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Subject.Update
{
    public class AlterSubjectHandler : Handler<AlterSubjectCommand, AlterSubjectHandler>
    {
       
        private readonly ISubjectRepository _repo;
        public AlterSubjectHandler(ISubjectRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(AlterSubjectCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _repo.Find(request.Id);
                entity.Description = request.Subject.Description;
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
