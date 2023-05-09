﻿namespace Materialempfehlung.Models
{
    public class Bedingung
    {
        public int Id { get; set; }

        public string Bezeichnung { get; set; }

        public string Bemerkung { get; set; }

        public DateTime Erstellungsdatum { get; set; }

        public DateTime Änderungsdatum { get; set; }

        // Relations
        public List<Material> Materialien { get; set; }
    }
}