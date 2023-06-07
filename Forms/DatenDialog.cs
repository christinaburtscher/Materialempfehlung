using Materialempfehlung.Repository;

namespace Materialempfehlung
{
    public partial class DatenDialog : Form
    {
        private readonly EmpfehlungenRepository _empfehlungenRepository = new();
        public string Bereich = string.Empty;
        public string Inhalt = string.Empty;

        public DatenDialog()
        {
            InitializeComponent();
        }

        public DatenDialog(string bereich)
        {
            InitializeComponent();

            textBoxBereich.Text = bereich;
            Bereich = bereich;
        }

        private void ButtonEmpfehlungDetailSpeichern_Click(object sender, EventArgs e)
        {
            var inhalt = textBoxInhalt.Text;

            if (!string.IsNullOrEmpty(Bereich) && !string.IsNullOrEmpty(inhalt))
            {
                var addResult = _empfehlungenRepository.Hinzufügen(Bereich, inhalt, textBoxBemerkung.Text);
                if (!addResult)
                {
                    MessageBox.Show("Neuer Bereich konnte nicht hinzugefügt werden", "Fehler", MessageBoxButtons.OK);
                    return;
                }

                Bereich = textBoxBereich.Text;
                Inhalt = textBoxInhalt.Text;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Bereich und Inhalt müssen ausgefüllt sein", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.No;
                return;
            }
        }
    }
}
