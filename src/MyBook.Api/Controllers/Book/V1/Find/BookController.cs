using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Author.Create;
using MyBook.Application.UseCases.Book.Find;
using System.Net;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new FindBookCommand());

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
