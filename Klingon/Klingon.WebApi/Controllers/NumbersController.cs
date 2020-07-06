using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Klingon.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Klingon.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        // GET: api/Numbers
        [HttpGet]
        public IActionResult Get()
        {
            var numbers = new Numbers();
            return Ok(numbers.BeatefulNumber().ToString());
        }
    }
}
