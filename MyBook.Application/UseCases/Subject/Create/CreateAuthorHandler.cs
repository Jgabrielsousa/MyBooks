using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Subject.Create
{
    public  class CreateSubjectHandler : Handler<CreateSubjectCommand, CreateSubjectHandler>
    {
        private readonly ISubjectRepository _repo;
        public CreateSubjectHandler(ISubjectRepository repo)
        {
            _repo= repo;
        }

        public override Task<Result> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {

            var entity = _repo.Add(new SubjectEntity() { Description = request.Description });
            Result.Data = entity;

            return Task.FromResult(Result);
        }
    }
}
