namespace Projekt_krzyżówki.Models
{
    public class Lacznik
    {
        public int IdPytanie { get; set; }
        public Pytania Pytanie { get; set; }
        public int IdOdpowiedz { get; set; }
        public Slowa Odpowiedz { get; set; }
    }
}
