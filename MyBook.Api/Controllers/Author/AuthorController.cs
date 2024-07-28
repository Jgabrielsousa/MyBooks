using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Controllers.Subject;

namespace MyBook.Api.Controllers.Author
{
    [ApiController]
    [Route("[controller]")]
    public partial class AuthorController : ControllerBase
    {
      
        private readonly ILogger<AuthorController> _logger;
        private readonly IMediator _mediator;

        public AuthorController(ILogger<AuthorController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

    }
}
