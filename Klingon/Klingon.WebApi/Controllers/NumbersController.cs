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
        /// <summary>
        /// Retorna quantos números bonitos existem no Texto B.
        /// </summary>
        /// <returns></returns>
        // GET: api/Numbers
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var numbers = new Numbers();
                return Ok(numbers.DistinctBeautifulNumbers());
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException($"{e.Message}");
            }
            catch (Exception e)
            {
                throw new ArgumentNullException($"{e.Message}");
            }
        }
    }
}
