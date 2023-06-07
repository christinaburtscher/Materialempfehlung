namespace Materialempfehlung.Models
{
    public class MaterialVorschlag
    {
        public MaterialVorschlag(string artikelnummer_Bezeichnung)
        {
            Artikelnummer_Bezeichnung = artikelnummer_Bezeichnung;
        }

        public string Artikelnummer_Bezeichnung { get; set; }

        public int Preisartikel { get; set; }
    }
}
