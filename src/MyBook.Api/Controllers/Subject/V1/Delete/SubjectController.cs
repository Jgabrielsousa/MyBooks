using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Subject.Delete;
using System.Net;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _mediator.Send(new DeleteSubjectCommand(id));

            return await Presenter.Do(result, HttpStatusCode.OK);

        }

    }
}
