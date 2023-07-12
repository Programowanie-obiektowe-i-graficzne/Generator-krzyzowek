using System.ComponentModel.DataAnnotations;

namespace Projekt_krzyżówki.Models.MODELS
{
    public class Slowa
    {
        [Key]
        public int Id_Slowa { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public int Podkategoria { get; set; }
        public bool Anagram { get; set; }

        List<Pytania> ListaPytan { get; set; }

    }
}
