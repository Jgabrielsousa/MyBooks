using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.Results;
using MyBook.Application.UseCases.Author.Create;
using System.Net;

namespace MyBook.Api.Controllers.Author
{
    public partial class AuthorController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Author auhtor)
        {

            var result = await _mediator.Send(new CreateAuthorCommand());

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
