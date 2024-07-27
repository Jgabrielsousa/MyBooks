using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute]int id, [FromBody] Models.Subject subject)
        {

            return Ok();
        }

    }
}
