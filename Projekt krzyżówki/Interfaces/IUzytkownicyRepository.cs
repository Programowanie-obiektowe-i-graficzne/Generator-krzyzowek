using Projekt_krzyżówki.Models.MODELS;

namespace Projekt_krzyżówki.Interfaces
{
    public interface IUzytkownicyRepository
    {
        ICollection<Uzytkownik> GetUzytkowik();
    }
}
