using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.SaleType.Create
{
    public class CreateSaleTypeHandler : Handler<CreateSaleTypeCommand, CreateSaleTypeHandler>
    {
        private readonly ISaleTypeRepository _repo;
        private readonly IBookRepository _repoBook;
        private readonly ISaleTypeBookRepository _repoSalesTypeBook;
        public CreateSaleTypeHandler(ISaleTypeRepository repo, IBookRepository repoBook, ISaleTypeBookRepository repoSalesTypeBook)
        {
            _repo = repo;
            _repoBook = repoBook;
            _repoSalesTypeBook = repoSalesTypeBook;
        }

        public override Task<Result> Handle(CreateSaleTypeCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var bookEntity = _repoBook.Find(request.BookId);

                if (bookEntity == null)
                {
                    Result.AddNotification("Book not Found", Domain.Enums.ErrorCode.NotFound);
                    return Task.FromResult(Result);
                }
                //Add New Sales Type 
                var entity = _repo.Add(new SaleTypeEntity() { Description = request.Description, Value = request.Value });


                //Create Relation Tbw Book and New Sales 
                _repoSalesTypeBook.Add(new Domain.Entities.ManyToMany.SaleTypeBook()
                {
                    BookId = bookEntity.Id,
                    SaleTypeId = entity.Id
                });

                request.Id = entity.Id;

                Result.Data = request;

               
            }
            catch (Exception)
            {
                Result.AddNotification("Somenting went wrong", Domain.Enums.ErrorCode.InternalError);
                return Task.FromResult(Result);
            }

            return Task.FromResult(Result);

        }
    }
}
