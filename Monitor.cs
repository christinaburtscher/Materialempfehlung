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
            // UserControl hinzuf�gen
            groupBox�bersicht.Controls.Clear();
            var control = new Material�bersicht
            {
                Dock = DockStyle.Fill
            };
            groupBox�bersicht.Controls.Add(control);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // UserControl hinzuf�gen
            groupBox�bersicht.Controls.Clear();
            var control = new Empfehlungen
            {
                Dock = DockStyle.Fill
            };
            groupBox�bersicht.Controls.Add(control);
        }
    }
}