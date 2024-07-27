using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Models;

namespace MyBook.Api.Controllers.Author
{
    public partial class AuthorController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Models.Author> Get()
        {
            return new List<Models.Author>();
        }

    }
}
