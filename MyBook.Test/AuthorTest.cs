using Moq;
using MyBook.Application.Results;
using MyBook.Application.UseCases.Author.Create;
using MyBook.Application.UseCases.Author.Delete;
using MyBook.Application.UseCases.Author.Find;
using MyBook.Application.UseCases.Author.FindById;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Test
{
    public class AuthorTest
    {


        private readonly Mock<IAuthorRepository> _repo = new Mock<IAuthorRepository>();
        private const string  _name = "Joao";
        private const int  _id = 1;

        #region CreateAuthor  

        private CreateAuthorCommand CreateCommand(string name)
        {
            var command = new CreateAuthorCommand();
            command.Name = name;
            return command;
        }

        public async Task<Result> RunCreateAuthor(CreateAuthorCommand command)
        {
            var handler = new CreateAuthorHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldCreateAuthor()
        {
           
            //Arrange
            var command = CreateCommand(_name);

            //Act
            var obj = new AuthorEntity() { Name = _name };
            _repo.Setup(c => c.Add(It.IsAny<AuthorEntity>())).Returns(obj);

            var result = await RunCreateAuthor(command);

            var checkValue = ((AuthorEntity)result.Data).Name;
            //Assertion
            Assert.Equal(checkValue, _name);

        }

        #endregion

        #region FindAuthor

      

        public async Task<Result> RunFindAuthor(FindAuthorCommand command)
        {
            var handler = new FindAuthorHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldGetAuthors()
        {
           
            //Arrange
            var obj = new AuthorEntity() { Name = _name };
            var list = new List<AuthorEntity>() { obj };

            //Act
            _repo.Setup(c => c.GetAll()).Returns(list);

            var result = await RunFindAuthor(new FindAuthorCommand());
            var checkValue = ((List<AuthorEntity>)result.Data).Any();
            //Assertion
            Assert.Equal(checkValue, true);
        }

        #endregion

        #region FindByIdAuthor

      

        private FindByIdAuthorCommand CreateFindByIdCommand(int id)
        {
            return new FindByIdAuthorCommand(id); ;
        }

        public async Task<Result> RunFindByIdAuthor(FindByIdAuthorCommand command)
        {
            var handler = new FindByIdAuthorHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldGetAuthorById()
        {

            //Arrange
            var command = CreateFindByIdCommand(_id);

            //Act
            var obj = new AuthorEntity() { Id = _id, Name = _name };
            _repo.Setup(c => c.Find(It.IsAny<int>())).Returns(obj);

            var result = await RunFindByIdAuthor(command);

            var checkValue = ((AuthorEntity)result.Data).Id;
            //Assertion
            Assert.Equal(checkValue, _id);

        }

        #endregion


        #region DeleteAuthor

       
        public async Task<Result> RunDeleteAuthor(DeleteAuthorCommand command)
        {
            var handler = new DeleteAuthorHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldDeleteAuthor()
        {
            //Arrange


            //Act
            var obj = new AuthorEntity() { Id = _id, Name = _name };
            _repo.Setup(c => c.Find(It.IsAny<int>())).Returns(obj);

            _repo.Setup(c => c.Remove(It.IsAny<AuthorEntity>()));

            var result = await RunDeleteAuthor(new DeleteAuthorCommand(_id));
            var checkValue = result.Notifications.Any();
            //Assertion
            Assert.Equal(checkValue, false);
        }
        #endregion
    }
}