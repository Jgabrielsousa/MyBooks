using Moq;
using MyBook.Application.Results;
using MyBook.Application.UseCases.Subject.Create;
using MyBook.Application.UseCases.Subject.Delete;
using MyBook.Application.UseCases.Subject.Find;
using MyBook.Application.UseCases.Subject.FindById;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Test
{
    public class SubjectTest
    {


        private readonly Mock<ISubjectRepository> _repo = new Mock<ISubjectRepository>();
        private const string  _description= "Joao";
        private const int  _id = 1;

        #region CreateSubject  

        private CreateSubjectCommand CreateCommand(string name)
        {
            var command = new CreateSubjectCommand();
            command.Description = name;
            return command;
        }

        public async Task<Result> RunCreateSubject(CreateSubjectCommand command)
        {
            var handler = new CreateSubjectHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldCreateSubject()
        {
           
            //Arrange
            var command = CreateCommand(_description);

            //Act
            var obj = new SubjectEntity() { Description = _description};
            _repo.Setup(c => c.Add(It.IsAny<SubjectEntity>())).Returns(obj);

            var result = await RunCreateSubject(command);

            var checkValue = ((SubjectEntity)result.Data).Description;
            //Assertion
            Assert.Equal(checkValue, _description);

        }

        #endregion

        #region FindSubject

      

        public async Task<Result> RunFindSubject(FindSubjectCommand command)
        {
            var handler = new FindSubjectHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldGetSubjects()
        {
           
            //Arrange
            var obj = new SubjectEntity() { Description = _description};
            var list = new List<SubjectEntity>() { obj };

            //Act
            _repo.Setup(c => c.GetAll()).Returns(list);

            var result = await RunFindSubject(new FindSubjectCommand());
            var checkValue = ((List<SubjectEntity>)result.Data).Any();
            //Assertion
            Assert.Equal(checkValue, true);
        }

        #endregion

        #region FindByIdSubject

      

        private FindByIdSubjectCommand CreateFindByIdCommand(int id)
        {
            return new FindByIdSubjectCommand(id); ;
        }

        public async Task<Result> RunFindByIdSubject(FindByIdSubjectCommand command)
        {
            var handler = new FindByIdSubjectHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldGetSubjectById()
        {

            //Arrange
            var command = CreateFindByIdCommand(_id);

            //Act
            var obj = new SubjectEntity() { Id = _id, Description = _description};
            _repo.Setup(c => c.Find(It.IsAny<int>())).Returns(obj);

            var result = await RunFindByIdSubject(command);

            var checkValue = ((SubjectEntity)result.Data).Id;
            //Assertion
            Assert.Equal(checkValue, _id);

        }

        #endregion


        #region DeleteSubject

       
        public async Task<Result> RunDeleteSubject(DeleteSubjectCommand command)
        {
            var handler = new DeleteSubjectHandler(_repo.Object);
            return await handler.Handle(command, new CancellationToken());

        }

        [Fact]
        public async void ShouldDeleteSubject()
        {
            //Arrange


            //Act
            var obj = new SubjectEntity() { Id = _id, Description = _description};
            _repo.Setup(c => c.Find(It.IsAny<int>())).Returns(obj);

            _repo.Setup(c => c.Remove(It.IsAny<SubjectEntity>()));

            var result = await RunDeleteSubject(new DeleteSubjectCommand(_id));
            var checkValue = result.Notifications.Any();
            //Assertion
            Assert.Equal(checkValue, false);
        }
        #endregion
    }
}