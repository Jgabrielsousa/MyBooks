using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.SaleType.Update
{
    public class AlterSaleTypeCommand : Command<AlterSaleTypeCommand>
    {
        public int Id { get; set; }
        public SaleTypeDto SaleType { get; set; }


        public AlterSaleTypeCommand()
        {
        }
        public AlterSaleTypeCommand(int id, SaleTypeDto sales)
        {
            Id = id;
            SaleType = sales;
        }

    }
}
