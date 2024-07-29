using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Author.Delete;
using System.Net;

namespace MyBook.Api.Controllers.Author
{
    public partial class AuthorController : ControllerBase
    {

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _mediator.Send(new DeleteAuthorCommand(id));

            return await Presenter.Do(result, HttpStatusCode.OK);

        }

    }
}
