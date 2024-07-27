using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {

            return Ok();
        }

    }
}
