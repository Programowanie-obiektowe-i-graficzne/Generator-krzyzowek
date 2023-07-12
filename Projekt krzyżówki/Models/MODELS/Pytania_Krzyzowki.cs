namespace Projekt_krzyżówki.Models.MODELS
{
    public class Pytania_Krzyzowki
    {
        public int Id_Pytania { get; set; }
        public int Id_Krzyzowki { get; set; }
        public Pytania Pytanie { get; set; }
        public Krzyzowka Krzyzowka { get; set; }
    }
}
