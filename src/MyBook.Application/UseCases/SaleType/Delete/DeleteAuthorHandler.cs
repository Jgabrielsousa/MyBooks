using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Application.UseCases.SaleType.Delete
{
    public class DeleteSaleTypeHandler : Handler<DeleteSaleTypeCommand, DeleteSaleTypeHandler>
    {


        private readonly ISaleTypeRepository _repo;
        public DeleteSaleTypeHandler(ISaleTypeRepository repo)
        {
            _repo = repo;
        }


        public override Task<Result> Handle(DeleteSaleTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _repo.Find(request.Id);

                if (entity == null)
                {
                    Result.AddNotification("SaleType not Found", Domain.Enums.ErrorCode.NotFound);
                    return Task.FromResult(Result);
                }


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
