using Projekt_krzyżówki.Data;
using Projekt_krzyżówki.Interfaces;
using Projekt_krzyżówki.Models.MODELS;

namespace Projekt_krzyżówki.Repository
{
    public class KrzyzowkiRepository : IKrzyzowkiRepository
    {
        private readonly DataContext _context; 
        public KrzyzowkiRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Krzyzowka> GetKrzyzowki()
        {
            return _context.Krzyzowki.OrderBy(p => p.Id_Krzyzowki).ToList();
        }
    }
}
