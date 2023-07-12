using System.ComponentModel.DataAnnotations;

namespace Projekt_krzyżówki.Models
{
    public class Slowa
    {
        [Key]
        public int IdSlowa { get; set; }
        [Display(Name ="Slowo")]
        public string Nazwa { get; set; }
        [Display(Name = "Kategoria_Slowa")]
        public string Kategoria { get; set; }
        [Display(Name = "Podkategoria_Slowa")]
        public int Podkategoria { get; set; }
        public bool Anagram { get; set; }
        public List<Pytania> ListaPytan { get; set; }
    }
}
