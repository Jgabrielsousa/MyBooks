using Microsoft.AspNetCore.Mvc;

namespace MyBook.Api.Controllers.Subject
{
    [ApiController]
    [Route("[controller]")]
    public partial class SubjectController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SubjectController> _logger;

        public SubjectController(ILogger<SubjectController> logger)
        {
            _logger = logger;
        }

       
    }
}
