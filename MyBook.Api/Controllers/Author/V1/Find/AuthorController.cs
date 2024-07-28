using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Author.Find;
using System.Net;

namespace MyBook.Api.Controllers.Author
{
    public partial class AuthorController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new FindAuthorCommand());

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
