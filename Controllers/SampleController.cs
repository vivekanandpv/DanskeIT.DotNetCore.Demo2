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
        private readonly IEnumerable<IStore> _stores;

        public SampleController(IStore store, IBook book, IEnumerable<IStore> stores)
        {
            Console.WriteLine("creating the controller");
            _store = store;
            _stores = stores;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                new
                {
                    Message = $"We got: {_stores.Count()} stores", 
                    CurrentStore = $"{_store.GetInfo()}"
                });
        }
    }
}
