namespace Materialempfehlung.Models
{
    public class Settings
    {
        public string? LocalDb { get; set; }

        public string? TestConnectionString { get; set; }

        public string? ProductionPrintplusConnectionString { get; set; }

        public string? ProductionCariniConnectionString { get; set; }
    }
}
