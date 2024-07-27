using Microsoft.AspNetCore.Mvc;
using Models = MyBook.Api.Models;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody] Models.Subject subject)
        {

            return Ok();
        }

    }
}
