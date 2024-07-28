using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Models;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.Book.Create;
using System.Net;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Book book)
        {
            var command = new CreateBookCommand();
            command.Title = book.Title;
            command.PublishingCompany = book.PublishingCompany;
            command.Edition = book.Edition;
            command.PublicationDate = book.PublicationDate; 
            var result = await _mediator.Send(command);

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
