namespace Materialempfehlung.Models
{
    public class Material
    {
        public int Id { get; set; }

        //maarcod
        public string Artikelnummer_Bezeichnung  { get; set; }      

        //maarprart
        public int Preisartikel { get; set; }

        //maarbez Preisartikel
        public string? Bezeichnung { get; set; }

        //Qualität Preisartikel
        public string? Qualität  { get; set; }

        //intern
        public string? Bemerkung { get; set; }

        //Preisartikel
        public double Preis { get; set; }

        //Preisartikel
        public double Lieferzeit { get; set; }

        public string? Status  { get; set; }

        public string? Farbe { get; set; }

        public string? Klebstoff_Printplus { get; set; }

        // intern
        public DateTime Erstellungsdatum { get; set; }

        // intern
        public DateTime? Änderungsdatum { get; set; }

        public bool Inaktiv { get; set; }
    }
}
