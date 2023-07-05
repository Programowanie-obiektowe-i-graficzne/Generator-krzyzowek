using Projekt_krzyżówki.Data;
using System.ComponentModel.DataAnnotations;

namespace Projekt_krzyżówki.Models
{
    public class Pytania
    {
        public int IdPytania { get; set; }
        public string Tresc { get; set; }
        public int Trudnosc { get; set; }
        public Kategorie Kategoria { get; set; }
        public List<Slowa> ListaSlow { get; set; }
    }
}
