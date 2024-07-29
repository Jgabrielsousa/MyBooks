using Moq;
using MyBook.Application.Results;
using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;
using MyBook.Application.UseCases.Book.Create;
using MyBook.Application.UseCases.Book.Delete;
using MyBook.Application.UseCases.Book.Find;
using MyBook.Application.UseCases.Book.FindById;
using MyBook.Domain.Entities;
using MyBook.Domain.Entities.ManyToMany;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Test
{
    public class BookTest
    {


        private readonly Mock<IBookRepository> _repo = new Mock<IBookRepository>();
        private readonly Mock<IAuthorRepository> _repoAuthor = new Mock<IAuthorRepository>();
        private readonly Mock<IAuthorBookRepository> _repoAuthorBook = new Mock<IAuthorBookRepository>();

    

        private const int _id = 1;
        private const string _title = "Titulo Livro";
        private const string _publishingCompany = "Saraiva";
        private const int _edition = 1;
        private const string _publicationDate = "2010";

        private const string _name = "Joao";


        public AuthorEntity AuthorEntity()
            => new AuthorEntity() { Name = _name };

        #region CreateBook  

        private CreateBookCommand CreateCommand()
        {
            var command = new CreateBookCommand();
            command.Title = _title;
            command.PublishingCompany = _publishingCompany;
            command.Edition = _edition;
            command.PublicationDate = _publicationDate;
            return command;
        }

        public async Task<Result> RunCreateBook(CreateBookCommand command)
        {
            var handler = new CreateBookHandler(_repo.Object, _repoAuthorBook.Object, _repoAuthor.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        public BookEntity BookEntity()
        => new BookEntity()
        {
            Id = _id,
            Title = _title,
            PublishingCompany = _publishingCompany,
            Edition = _edition,
            PublicationDate = _publicationDate,
            SubjectBook = new List<SubjectBook>(),
            SaleTypeBook = new List<SaleTypeBook>(),
            AuthorBook = new List<AuthorBook>() { new AuthorBook() { AuthorId = _id} },
           
        };

        [Fact]
        public async void ShouldCreateBook()
        {

            //Arrange
            var command = CreateCommand();

            //Act
            _repoAuthor.Setup(c => c.Find(It.IsAny<int>())).Returns(AuthorEntity());

            _repo.Setup(c => c.Add(It.IsAny<BookEntity>())).Returns(BookEntity());
            _repoAuthorBook.Setup(c => c.Add(It.IsAny<AuthorBook>())).Returns(new AuthorBook());

        

            var result = await RunCreateBook(command);

            var checkValue = ((CreateBookCommand)result.Data).Title;
            //Assertion
            Assert.Equal(checkValue, BookEntity().Title);

        }

        #endregion

        #region FindBook



        public async Task<Result> RunFindBook(FindBookCommand command)
        {
            var handler = new FindBookHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldGetBooks()
        {

            //Arrange
         
            var list = new List<BookEntity>() { BookEntity() };

            //Act
            _repo.Setup(c => c.GetAll()).Returns(list);

            var result = await RunFindBook(new FindBookCommand());
            var checkValue = ((List<BookDto>)result.Data).Any();
            //Assertion
            Assert.Equal(checkValue, true);
        }

        #endregion

        #region FindByIdBook



        private FindByIdBookCommand CreateFindByIdCommand(int id)
        {
            return new FindByIdBookCommand(id); ;
        }

        public async Task<Result> RunFindByIdBook(FindByIdBookCommand command)
        {
            var handler = new FindByIdBookHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldGetBookById()
        {

            //Arrange
            var command = CreateFindByIdCommand(_id);

            //Act
            _repo.Setup(c => c.Find(It.IsAny<int>())).Returns(BookEntity());

            var result = await RunFindByIdBook(command);

            var checkValue = ((BookEntity)result.Data).Id;
            //Assertion
            Assert.Equal(checkValue, BookEntity().Id);

        }

        #endregion

        #region DeleteBook


        public async Task<Result> RunDeleteBook(DeleteBookCommand command)
        {
            var handler = new DeleteBookHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldDeleteBook()
        {
            //Arrange


            //Act
            _repo.Setup(c => c.Find(It.IsAny<int>())).Returns(BookEntity());

            _repo.Setup(c => c.Remove(It.IsAny<BookEntity>()));

            var result = await RunDeleteBook(new DeleteBookCommand(BookEntity().Id));
            var checkValue = result.Notifications.Any();
            //Assertion
            Assert.Equal(checkValue, false);
        }

        #endregion


    }
}