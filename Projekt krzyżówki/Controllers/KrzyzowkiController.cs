using Microsoft.AspNetCore.Mvc;
using Projekt_krzyżówki.Interfaces;
using Projekt_krzyżówki.Models.MODELS;

namespace Projekt_krzyżówki.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class KrzyzowkiController:Controller
    {
        private readonly IKrzyzowkiRepository _krzyzowkiRepository;
        public KrzyzowkiController(IKrzyzowkiRepository krzyzowkiRepository)
        {
            _krzyzowkiRepository = krzyzowkiRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Krzyzowka>))]
        public IActionResult GetKrzyzowki()
        {
            var krzyzowki = _krzyzowkiRepository.GetKrzyzowki();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(krzyzowki);
        }
    }
}
