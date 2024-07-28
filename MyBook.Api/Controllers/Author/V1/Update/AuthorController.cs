using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Author.Create;
using System.Net;

namespace MyBook.Api.Controllers.Author
{
    public partial class AuthorController : ControllerBase
    {

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Models.Author auhtor)
        {
            var result = await _mediator.Send(new AlterAuthorCommand());

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
