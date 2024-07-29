using Moq;
using MyBook.Application.Results;
using MyBook.Application.UseCases.SaleType.Create;
using MyBook.Application.UseCases.SaleType.Delete;
using MyBook.Application.UseCases.SaleType.Find;
using MyBook.Application.UseCases.SaleType.FindById;
using MyBook.Domain.Entities;
using MyBook.Domain.Entities.ManyToMany;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Test
{
    public class SaleTypeTest
    {


        private readonly Mock<ISaleTypeRepository> _repo = new Mock<ISaleTypeRepository>();
        private readonly Mock<IBookRepository> _repoBook = new Mock<IBookRepository>();
        private readonly Mock<ISaleTypeBookRepository> _repoSaleTypeBook = new Mock<ISaleTypeBookRepository>();

      


        private const string  _description= "Internet";
        private const int  _id = 1;


        private const string _title = "Titulo Livro";
        private const string _publishingCompany = "Saraiva";
        private const int _edition = 1;
        private const string _publicationDate = "2010";

        public BookEntity BookEntity()
       => new BookEntity()
       {
           Id = _id,
           Title = _title,
           PublishingCompany = _publishingCompany,
           Edition = _edition,
           PublicationDate = _publicationDate
       };

        public SaleTypeEntity SaleTypeEntity()
            => new SaleTypeEntity() { Description = _description};

        #region CreateSaleType  

        private CreateSaleTypeCommand CreateCommand(string name)
        {
            var command = new CreateSaleTypeCommand();
            command.Description = name;
            return command;
        }

        public async Task<Result> RunCreateSaleType(CreateSaleTypeCommand command)
        {
            var handler = new CreateSaleTypeHandler(_repo.Object,_repoBook.Object,_repoSaleTypeBook.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldCreateSaleType()
        {
           
            //Arrange
            var command = CreateCommand(_description);

            //Act
            _repoBook.Setup(c => c.Find(It.IsAny<int>())).Returns(BookEntity());

            _repo.Setup(c => c.Add(It.IsAny<SaleTypeEntity>())).Returns(SaleTypeEntity());
            _repoSaleTypeBook.Setup(c => c.Add(It.IsAny<SaleTypeBook>())).Returns(new SaleTypeBook());



            var result = await RunCreateSaleType(command);

            var checkValue = ((CreateSaleTypeCommand)result.Data).Description;
            //Assertion
            Assert.Equal(checkValue, _description);

        }

        #endregion

        #region FindSaleType

      

        public async Task<Result> RunFindSaleType(FindSaleTypeCommand command)
        {
            var handler = new FindSaleTypeHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldGetSaleTypes()
        {
           
            //Arrange
            var obj = new SaleTypeEntity() { Description = _description};
            var list = new List<SaleTypeEntity>() { obj };

            //Act
            _repo.Setup(c => c.GetAll()).Returns(list);

            var result = await RunFindSaleType(new FindSaleTypeCommand());
            var checkValue = ((List<SaleTypeEntity>)result.Data).Any();
            //Assertion
            Assert.Equal(checkValue, true);
        }

        #endregion

        #region FindByIdSaleType

      

        private FindByIdSaleTypeCommand CreateFindByIdCommand(int id)
        {
            return new FindByIdSaleTypeCommand(id); ;
        }

        public async Task<Result> RunFindByIdSaleType(FindByIdSaleTypeCommand command)
        {
            var handler = new FindByIdSaleTypeHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldGetSaleTypeById()
        {

            //Arrange
            var command = CreateFindByIdCommand(_id);

            //Act
            var obj = new SaleTypeEntity() { Id = _id, Description = _description};
            _repo.Setup(c => c.Find(It.IsAny<int>())).Returns(obj);

            var result = await RunFindByIdSaleType(command);

            var checkValue = ((SaleTypeEntity)result.Data).Id;
            //Assertion
            Assert.Equal(checkValue, _id);

        }

        #endregion


        #region DeleteSaleType

       
        public async Task<Result> RunDeleteSaleType(DeleteSaleTypeCommand command)
        {
            var handler = new DeleteSaleTypeHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldDeleteSaleType()
        {
            //Arrange


            //Act
            var obj = new SaleTypeEntity() { Id = _id, Description = _description};
            _repo.Setup(c => c.Find(It.IsAny<int>())).Returns(obj);

            _repo.Setup(c => c.Remove(It.IsAny<SaleTypeEntity>()));

            var result = await RunDeleteSaleType(new DeleteSaleTypeCommand(_id));
            var checkValue = result.Notifications.Any();
            //Assertion
            Assert.Equal(checkValue, false);
        }
        #endregion
    }
}