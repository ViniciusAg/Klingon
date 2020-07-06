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
    public class VocabularyController : ControllerBase
    {
        /// <summary>
        /// Lista de Vocabulário do Texto B.
        /// </summary>
        /// <returns></returns>
        // GET: api/Vocabulary
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var vocabulary = new ListVocabulary();
                return Ok(vocabulary.OrderedTextB());
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
