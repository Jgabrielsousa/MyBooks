using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Book.Delete;
using System.Net;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _mediator.Send(new DeleteBookCommand(id));

            return await Presenter.Do(result, HttpStatusCode.OK);

        }

    }
}
