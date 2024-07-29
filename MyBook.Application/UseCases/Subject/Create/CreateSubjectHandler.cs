using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Entities.ManyToMany;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.Subject.Create
{
    public  class CreateSubjectHandler : Handler<CreateSubjectCommand, CreateSubjectHandler>
    {
        private readonly ISubjectRepository _repo;
        private readonly IBookRepository _repoBook;
        private readonly ISubjectBookRepository _repoSubjectBook;
        public CreateSubjectHandler(ISubjectRepository repo, IBookRepository repoBook, ISubjectBookRepository repoSubjectBook)
        {
            _repo = repo;
            _repoBook = repoBook;
            _repoSubjectBook = repoSubjectBook;
        }

        public override Task<Result> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var bookEntity = _repoBook.Find(request.BookId);

                if (bookEntity == null)
                {
                    Result.AddNotification("Book not Found", Domain.Enums.ErrorCode.NotFound);
                    return Task.FromResult(Result);
                }

                //Add New Subject
                var entity = _repo.Add(new SubjectEntity() { Description = request.Description });
               

                //Create Relation Tbw Book and New Subject 
                _repoSubjectBook.Add(new SubjectBook()
                {
                    BookId = bookEntity.Id
                    ,SubjectId = entity.Id
                });
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
