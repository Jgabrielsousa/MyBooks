using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Subject.FindById;
using System.Net;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {

        [HttpGet("{id}")]
        public async Task<IActionResult> FindById([FromRoute] int id)
        {
            var result = await _mediator.Send(new FindByIdSubjectCommand(id));

            return await Presenter.Do(result, HttpStatusCode.OK);
        }


    }
}
