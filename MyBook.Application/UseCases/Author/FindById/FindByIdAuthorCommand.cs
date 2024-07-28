using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Create
{
    public class FindByIdAuthorCommand : Command<FindByIdAuthorCommand>
    {
        public int Id { get; set; }


        public FindByIdAuthorCommand()
        {
                
        }
        public FindByIdAuthorCommand(int id)
        {
            Id = id;
        }

    }
}
