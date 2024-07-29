using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Book.Update;
using System.Net;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {

       
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Models.Book book)
        {
            var result = await _mediator.Send(new AlterBookCommand(id, book));

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
