using System.ComponentModel.DataAnnotations;
namespace Projekt_krzyżówki.Models.MODELS
{
    public class Uzytkownik
    {
        [Key]
        public int Id_Uzytkownik { get; set; }
        public string Nazwa { get; set; }
        public int Rozwiazane { get; set; }
        List<Krzyzowka> ListaKrzyzowek { get; set; }
    }
}
