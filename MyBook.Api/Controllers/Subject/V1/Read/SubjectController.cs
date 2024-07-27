using Microsoft.AspNetCore.Mvc;
using MyBook.Api.Models;
using System.Collections.Generic;

namespace MyBook.Api.Controllers.Subject
{

    public partial class SubjectController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.Subject> Get()
        {

            return new List<Models.Subject>();
        }
       

    }
}
