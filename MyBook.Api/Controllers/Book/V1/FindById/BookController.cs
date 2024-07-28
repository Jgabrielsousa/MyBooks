using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Book.FindById;
using System.Net;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {


        [HttpGet("{id}")]
        public async Task<IActionResult> FindById([FromRoute] int id)
        {
            var result = await _mediator.Send(new FindByIdBookCommand(id));

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
