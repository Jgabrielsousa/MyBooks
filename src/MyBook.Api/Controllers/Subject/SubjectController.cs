using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Controllers.Author;

namespace MyBook.Api.Controllers.Subject
{
    [ApiController]
    [Route("[controller]")]
    public partial class SubjectController : ControllerBase
    {
       

        private readonly ILogger<SubjectController> _logger;
        private readonly IMediator _mediator;

        public SubjectController(ILogger<SubjectController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }


    }
}
