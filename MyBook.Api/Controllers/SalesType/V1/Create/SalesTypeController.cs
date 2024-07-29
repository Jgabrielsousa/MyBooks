using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Presenters;
using MyBook.Application.UseCases.SaleType.Create;
using System.Net;

namespace MyBook.Api.Controllers.SalesType
{

    public partial class SalesTypeController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.SalteType salesType)
        {

            var result = await _mediator.Send(new CreateSaleTypeCommand(salesType.Description,salesType.Value,salesType.BookId));

            return await Presenter.Do(result, HttpStatusCode.OK);
        }

    }
}
