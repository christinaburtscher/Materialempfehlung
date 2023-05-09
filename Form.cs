using Materialempfehlung.Context;
using Materialempfehlung.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace Materialempfehlung
{
    public partial class Form : System.Windows.Forms.Form
    {
        private MaterialempfehlungContext? dbContext;
        private readonly Settings _settings;

        public Form()
        {
            InitializeComponent();
            var configurationBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            _settings = configurationBuilder?.GetRequiredSection("Settings")?.Get<Settings>();
            _settings ??= new Settings();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dbContext = new MaterialempfehlungContext(_settings.TestConnectionString ?? string.Empty);

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();
        }

    }
}