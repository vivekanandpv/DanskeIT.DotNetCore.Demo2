using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DanskeIT.DotNetCore.Demo2.Service;

namespace DanskeIT.DotNetCore.Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly Book _book;

        public SampleController(Book book)
        {
            _book = book;
            Console.WriteLine("creating the controller");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {Message = this._book.GetTitle()});
        }
    }
}
