using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Author
{
    public partial class AuthorController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody] Models.Author auhtor)
        {

            return Ok();
        }

    }
}
