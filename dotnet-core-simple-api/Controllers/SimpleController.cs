using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_simple_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleController : ControllerBase
    {
        // GET: api/Simple
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", ".NET Core API" };
        }

        // GET: api/Simple/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "Hello API";
        }
    }
}
