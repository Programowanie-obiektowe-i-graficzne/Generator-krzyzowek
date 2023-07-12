using Projekt_krzyżówki.Data;
using System.ComponentModel.DataAnnotations;

namespace Projekt_krzyżówki.Models.MODELS
{
    public class Pytania
    {
        [Key]
        public int Id_Pytania { get; set; }
        public string Tresc { get; set; }
        public int Trudnosc { get; set; }
        public string Kategoria { get; set; }
        public Slowa Slowo { get; set; }
        public ICollection<Pytania_Krzyzowki> ListaKrzyzowek { get; set; }
    }
}
