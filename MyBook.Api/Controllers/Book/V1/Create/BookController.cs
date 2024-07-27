using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Models.Book subject)
        {

            return Ok();
        }

    }
}
