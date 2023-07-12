using Projekt_krzyżówki.Data;
using System.ComponentModel.DataAnnotations;

namespace Projekt_krzyżówki.Models
{
    public class Pytania
    {
        [Key]
        public int IdPytania { get; set; }
        [Display(Name = "Tresc")]
        public string Tresc { get; set; }
        [Display(Name = "Trudnosc_Pytania")]
        public int Trudnosc { get; set; }
        [Display(Name = "Kategoria_Pytania")]
        public Kategorie Kategoria { get; set; }
        [Display(Name = "Id_Odpowiedzi")]
        public int Id_Odpowiedzi { get; set; }
    }
}
