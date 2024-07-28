using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Book.Create
{
    public class CreateBookCommand : Command<CreateBookCommand>
    {
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public int Edition { get; set; }
        public string PublicationDate { get; set; }
        public CreateBookCommand()
        {
                
        }

        public CreateBookCommand(string title, string publishingCompany, int edition, string publicationDate)
        {
            Title = title;
            PublishingCompany = publishingCompany;
            Edition = edition;
            PublicationDate = publicationDate;
        }
    }
}
