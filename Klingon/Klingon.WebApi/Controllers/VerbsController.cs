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
    public class VerbsController : ControllerBase
    {
        /// <summary>
        /// Retorna número de Verbos existente no Texto B e quantos são em primeira pessoa, respectivamente.
        /// </summary>
        /// <returns></returns>
        // GET: api/Verbs
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var verbs = new Verbs();
                var result = new List<int>();

                result.Add(verbs.CountVerbs());
                result.Add(verbs.FirtsPersonVerbs());

                return Ok(result);
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
