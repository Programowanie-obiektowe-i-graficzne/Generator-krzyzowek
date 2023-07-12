using Microsoft.AspNetCore.Mvc;
using Projekt_krzyżówki.Data;
using Projekt_krzyżówki.Interfaces;
using Projekt_krzyżówki.Models.MODELS;

namespace Projekt_krzyżówki.Controllers
{
    [Route("api/[contoller]")]
    [ApiController]
    public class UzytkownicyController : Controller
    {
        private readonly IUzytkownicyRepository _uzytkownicyRepository;
        private readonly DataContext _context;

        public UzytkownicyController(IUzytkownicyRepository uzytkownicyRepository, DataContext context)
        {
            _uzytkownicyRepository = uzytkownicyRepository;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Uzytkownik>))]
        public IActionResult GetUzytkownik()
        {
            var uzytkownik = _uzytkownicyRepository.GetUzytkowik();
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(uzytkownik);
        }
    }
}
