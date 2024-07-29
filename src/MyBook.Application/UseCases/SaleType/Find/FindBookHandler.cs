using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.SaleType.Find
{
    public class FindSaleTypeHandler : Handler<FindSaleTypeCommand, FindSaleTypeHandler>
    {
        private readonly ISaleTypeRepository _repo;
        public FindSaleTypeHandler(ISaleTypeRepository repo)
        {
            _repo = repo;
        }


        public override Task<Result> Handle(FindSaleTypeCommand request, CancellationToken cancellationToken)
        {
           

            Result.Data = _repo.GetAll();

            return Task.FromResult(Result);
        }
    }
}
