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
        private readonly IStore _store;

        public SampleController(IStore store, IBook book)
        {
            Console.WriteLine("creating the controller");
            _store = store;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {Message = this._store.GetInfo()});
        }
    }
}
