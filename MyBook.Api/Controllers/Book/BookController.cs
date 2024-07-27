using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Controllers.Subject;

namespace MyBook.Api.Controllers.Book
{
    [ApiController]
    [Route("[controller]")]
    public partial class BookController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SubjectController> _logger;

        public BookController(ILogger<SubjectController> logger)
        {
            _logger = logger;
        }

        

 
        
    }
}
