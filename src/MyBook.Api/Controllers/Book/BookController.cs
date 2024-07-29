using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Book
{
    [ApiController]
    [Route("[controller]")]
    public partial class BookController : ControllerBase
    {
       

      


        private readonly ILogger<BookController> _logger;
        private readonly IMediator _mediator;

        public BookController(ILogger<BookController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }


    }
}
