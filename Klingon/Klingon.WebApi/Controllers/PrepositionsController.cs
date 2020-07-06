using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Klingon.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Klingon.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PrepositionsController : ControllerBase
    {
        /// <summary>
        /// Retorna número de Preposições existentes no Texto B.
        /// </summary>
        /// <returns></returns>
        // GET: api/Get
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var prepositions = new Prepositions();
                return Ok(prepositions.CountPrepositions());
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
