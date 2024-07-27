using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Controllers.Subject;

namespace MyBook.Api.Controllers.Author
{
    [ApiController]
    [Route("[controller]")]
    public partial class AuthorController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SubjectController> _logger;

        public AuthorController(ILogger<SubjectController> logger)
        {
            _logger = logger;
        }

    }
}
