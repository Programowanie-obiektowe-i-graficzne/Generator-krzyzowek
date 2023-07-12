using Projekt_krzyżówki.Data;
using Projekt_krzyżówki.Interfaces;
using Projekt_krzyżówki.Models.MODELS;

namespace Projekt_krzyżówki.Repository
{
    public class PytaniaRepository : IPytaniaRepository
    {
        private readonly DataContext _context;
        public PytaniaRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Pytania> GetPytania()
        {
            return _context.Pytania.OrderBy(p => p.Id_Pytania).ToList();
        }
    }
}
