using Microsoft.AspNetCore.Mvc;
using Projekt_krzyżówki.Interfaces;
using Projekt_krzyżówki.Models.MODELS;

namespace Projekt_krzyżówki.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class PytaniaController : Controller
    {
        private readonly IPytaniaRepository _pytaniaRepository;
        public PytaniaController(IPytaniaRepository pytaniaRepository)
        {
            _pytaniaRepository = pytaniaRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Krzyzowka>))]
        public IActionResult GetPytania()
        {
            var pytania = _pytaniaRepository.GetPytania();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pytania);
        }
    }
}

