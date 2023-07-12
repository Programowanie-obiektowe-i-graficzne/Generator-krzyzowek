using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt_krzyżówki.Models.MODELS
{
    public class Krzyzowka
    {
        [Key]
        public int Id_Krzyzowki { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Pytania_Krzyzowki> ListaPytan { get; set; } 
        public Uzytkownik Uzytkownik { get; set; }
    }
}
