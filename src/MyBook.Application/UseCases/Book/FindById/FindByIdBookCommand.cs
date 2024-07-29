using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Book.FindById
{
    public class FindByIdBookCommand : Command<FindByIdBookCommand>
    {
        public int Id { get; set; }


        public FindByIdBookCommand()
        {
                
        }
        public FindByIdBookCommand(int id)
        {
            Id = id;
        }

    }
}
