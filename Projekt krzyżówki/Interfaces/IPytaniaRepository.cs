using Projekt_krzyżówki.Models.MODELS;
namespace Projekt_krzyżówki.Interfaces
{
    public interface IPytaniaRepository
    {
        ICollection<Pytania> GetPytania();
    }
}
