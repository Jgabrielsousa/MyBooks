using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Subject.Create;
using System.Net;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Subject subject)
        {

            var result = await _mediator.Send(new CreateSubjectCommand(subject.Description,subject.BookId));

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
