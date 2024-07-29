using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.SaleType.FindById
{
    public class FindByIdSaleTypeHandler : Handler<FindByIdSaleTypeCommand, FindByIdSaleTypeHandler>
    {
      
        private readonly ISaleTypeRepository _repo;
        public FindByIdSaleTypeHandler(ISaleTypeRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(FindByIdSaleTypeCommand request, CancellationToken cancellationToken)
        {
            Result.Data = _repo.Find(request.Id);

            return Task.FromResult(Result);
        }
    }
}
