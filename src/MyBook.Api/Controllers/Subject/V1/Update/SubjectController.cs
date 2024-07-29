using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Subject.Update;
using System.Net;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Models.Subject subject)
        {
            var result = await _mediator.Send(new AlterSubjectCommand(id, subject));

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
