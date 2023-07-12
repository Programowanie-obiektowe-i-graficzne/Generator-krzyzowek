using Projekt_krzyżówki.Data;
using Projekt_krzyżówki.Interfaces;
using Projekt_krzyżówki.Models.MODELS;

namespace Projekt_krzyżówki.Repository
{
    public class UzytkownikRepository : IUzytkownicyRepository
    {
        private readonly DataContext _context;

        public UzytkownikRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Uzytkownik> GetUzytkownik()
        {
            return _context.Uzytkownicy.OrderBy(p => p.Id_Uzytkownik).ToList();
        }

    }
}
