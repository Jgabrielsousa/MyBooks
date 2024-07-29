using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.SaleType.FindById
{
    public class FindByIdSaleTypeCommand : Command<FindByIdSaleTypeCommand>
    {
        public int Id { get; set; }


        public FindByIdSaleTypeCommand()
        {
                
        }
        public FindByIdSaleTypeCommand(int id)
        {
            Id = id;
        }

    }
}
