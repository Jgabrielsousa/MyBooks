using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Subject.Find;
using System.Net;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new FindSubjectCommand());

            return await Presenter.Do(result, HttpStatusCode.OK);
        }


    }
}
