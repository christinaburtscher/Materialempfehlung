namespace Materialempfehlung
{
    public partial class Monitor : System.Windows.Forms.Form
    {
        public Monitor()
        {
            InitializeComponent();

        }

        private void ButtonSuche_Click(object sender, EventArgs e)
        {
            // UserControl hinzufügen
            groupBoxÜbersicht.Controls.Clear();
            var control = new Materialübersicht
            {
                Dock = DockStyle.Fill
            };
            groupBoxÜbersicht.Controls.Add(control);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // UserControl hinzufügen
            groupBoxÜbersicht.Controls.Clear();
            var control = new Empfehlungen
            {
                Dock = DockStyle.Fill
            };
            groupBoxÜbersicht.Controls.Add(control);
        }
    }
}