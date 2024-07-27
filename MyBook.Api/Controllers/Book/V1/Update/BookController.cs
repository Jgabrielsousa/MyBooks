using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Models.Book auhtor)
        {

            return Ok();
        }

    }
}
