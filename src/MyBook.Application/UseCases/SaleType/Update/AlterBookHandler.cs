using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.SaleType.Update
{
    public class AlterSaleTypeHandler : Handler<AlterSaleTypeCommand, AlterSaleTypeHandler>
    {
       
        private readonly ISaleTypeRepository _repo;
        public AlterSaleTypeHandler(ISaleTypeRepository repo)
        {
            _repo = repo;
        }

        public override Task<Result> Handle(AlterSaleTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = _repo.Find(request.Id);
            entity.Description = request.SaleType.Description;
            entity.Value = request.SaleType.Value;
            _repo.Update(entity);

            return Task.FromResult(Result);
        }
    }
}
