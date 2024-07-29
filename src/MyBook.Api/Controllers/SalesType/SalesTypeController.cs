using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Controllers.Subject;

namespace MyBook.Api.Controllers.SalesType
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class SalesTypeController : ControllerBase
    {
        private readonly ILogger<SubjectController> _logger;
        private readonly IMediator _mediator;

        public SalesTypeController(ILogger<SubjectController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
    }
}
