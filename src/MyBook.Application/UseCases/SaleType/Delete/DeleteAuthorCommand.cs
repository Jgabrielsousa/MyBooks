using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.SaleType.Delete
{
    public class DeleteSaleTypeCommand : Command<DeleteSaleTypeCommand>
    {
        public int Id { get; set; }

        public DeleteSaleTypeCommand() 
        {
                
        }
        public DeleteSaleTypeCommand(int id)
        {
            Id = id;
        }
    }
}
