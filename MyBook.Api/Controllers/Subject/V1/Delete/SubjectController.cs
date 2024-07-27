using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {

            return Ok();
        }

    }
}
