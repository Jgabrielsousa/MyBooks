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
            var entity = _repo.Find(request.Id);
            _repo.Remove(entity);

            return Task.FromResult(Result);
        }
    }
}
