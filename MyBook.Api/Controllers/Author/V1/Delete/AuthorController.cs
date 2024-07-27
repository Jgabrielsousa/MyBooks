using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Author
{
    public partial class AuthorController : ControllerBase
    {

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {

            return Ok();
        }

    }
}
