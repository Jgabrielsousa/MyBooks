using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Subject.Delete
{
    public class DeleteSubjectHandler : Handler<DeleteSubjectCommand, DeleteSubjectHandler>
    {


        private readonly ISubjectRepository _repo;
        public DeleteSubjectHandler(ISubjectRepository repo)
        {
            _repo = repo;
        }


        public override Task<Result> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _repo.Find(request.Id);
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
