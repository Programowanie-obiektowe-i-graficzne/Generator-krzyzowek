namespace Projekt_krzyżówki.Models
{
    public class Slowa
    {
        public int IdSlowa { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public int Podkategoria { get; set; }
        public bool Anagram { get; set; }
        public List<Pytania> ListaPytan { get; set; }
    }
}
