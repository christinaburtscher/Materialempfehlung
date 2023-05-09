namespace Materialempfehlung.Models
{
    public class Material
    {
        public int Id { get; set; }

        public string Artikelnummer_Carini  { get; set; }

        public string Bezeichnung { get; set; }

        public string Qualität  { get; set; }

        public string Artikeltyp  { get; set; }

        public string Dicke_mm { get; set; }

        public string Grammgewicht { get; set; }

        public string Bemerkung { get; set; }

        public double Preis { get; set; }

        public DateTime Erstellungsdatum { get; set; }

        public DateTime Änderungsdatum { get; set; }

        // Relations
        public List<Äußerer_Einfluss> Äußere_Einflüsse { get; set; }

        public List<Bedingung> Bedingungen { get; set; }

        public List<Besonderheit> Besonderheiten { get; set; }

        public List<Druckverfahren> Druckverfahren  { get; set; }

        public List<Kategorie> Kategorien { get; set; }

        public List<Klebstoff> Klebstoffe  { get; set; }

        public List<Oberfläche> Oberflächen  { get; set; }

        public List<Oberfläche_Beschaffenheit> Oberfläche_Beschaffenheiten { get; set; }

        public List<Oberfläche_Farbe> Oberfläche_Farben { get; set; }

        public List<Oberfläche_Form> Oberfläche_Formen { get; set; }

        public List<Oberfläche_Zustand> Oberfläche_Zustände { get; set; }
    }
}
