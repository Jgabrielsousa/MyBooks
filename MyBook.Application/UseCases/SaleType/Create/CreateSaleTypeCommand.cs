using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.SaleType.Create
{
    public class CreateSaleTypeCommand : Command<CreateSaleTypeCommand>
    {
        public string Description { get; set; }
        public float Value { get; set; }
        public int BookId { get; set; }
        public int Id { get; set; }
        public CreateSaleTypeCommand()
        {
                
        }

      

        public CreateSaleTypeCommand(string description, float value, int bookId)
        {
            Description = description;
            Value = value;
            BookId = bookId;
        }
    }
}
