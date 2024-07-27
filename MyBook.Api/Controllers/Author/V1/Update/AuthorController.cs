using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MyBook.Api.Controllers.Author
{
    public partial class AuthorController : ControllerBase
    {

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Models.Author auhtor)
        {
            return Ok();
        }
        
    }
}
