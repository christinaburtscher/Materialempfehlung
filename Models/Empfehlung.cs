namespace Materialempfehlung.Models
{
    public class Empfehlung
    {
        public int Id { get; set; }

        public string Bereich  { get; set; }

        public string Inhalt { get; set; }

        public string Bemerkung { get; set; }

        public DateTime Erstellungsdatum { get; set; }

        public DateTime? Änderungsdatum { get; set; }

    }
}
