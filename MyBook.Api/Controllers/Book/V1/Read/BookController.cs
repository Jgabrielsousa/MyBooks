using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Book
{

    public partial class BookController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<Models.Book> Get()
        {
            return new List<Models.Book>();
        }

    }
}
