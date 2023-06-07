using Materialempfehlung.Repository;

namespace Materialempfehlung.Forms
{
    public partial class EmpfehlungenErsetzen : Form
    {
        private readonly string _bereich = string.Empty;
        private readonly string _inhalt = string.Empty;

        private readonly EmpfehlungenRepository _empfehlungenRepository = new();
        private readonly MaterialRepository _materialRepository = new();

        public EmpfehlungenErsetzen()
        {
            InitializeComponent();
        }

        public EmpfehlungenErsetzen(string bereich, string inhalt)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(bereich) && string.IsNullOrEmpty(inhalt))
            {
                MessageBox.Show("Bereich und Inhalt müssen ausgewählt sein.", "", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
                Close();
            }

            _bereich = bereich;
            _inhalt = inhalt;

            textBoxBereich.Text = bereich;
            textBoxInhalt.Text = inhalt;

            labelNeuerInhalt.Visible = false;
            comboBoxInhalte.Visible = false;
        }

        private void ButtonSpeichern_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sollen die Änderungen wirklich gespeichert werden?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!checkBoxVerbindungenErsetzen.Checked)
                {
                    var result = _materialRepository.EmpfehlungenFürBereichLöschen(_bereich, _inhalt);
                    if (!result)
                    {
                        MessageBox.Show("Speichern nicht möglich. Bitte erneut probieren", "Fehler", MessageBoxButtons.OK);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }

                    // inhalt löschen
                    var deleteResult = _empfehlungenRepository.Delete(_bereich, _inhalt);
                    if (!deleteResult)
                    {
                        MessageBox.Show("Löschen nicht möglich. Bitte erneut probieren", "Fehler", MessageBoxButtons.OK);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    var relations = _materialRepository.PreisartikelFürEmpfehlungen(_bereich, _inhalt);
                    var neuerInhalt = (string)comboBoxInhalte.SelectedItem;
                    if (string.IsNullOrEmpty(neuerInhalt))
                    {
                        MessageBox.Show("Bitte einen neuen Inhalt für Empfehlungen auswählen", "Fehler", MessageBoxButtons.OK);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }

                    //neue Empfehlung hinzufügen
                    foreach (var item in relations)
                    {
                        var addResult = _materialRepository.AddRelation(item, _bereich, neuerInhalt);
                        if (!addResult)
                        {
                            MessageBox.Show("Inhalt hinzufügen nicht möglich. Bitte erneut probieren", "Fehler", MessageBoxButtons.OK);
                            DialogResult = DialogResult.Cancel;
                            Close();
                        }
                    }

                    //alte Empfehlungen löschen
                    var result = _materialRepository.EmpfehlungenFürBereichLöschen(_bereich, _inhalt);
                    if (!result)
                    {
                        MessageBox.Show("Speichern nicht möglich. Bitte erneut probieren", "Fehler", MessageBoxButtons.OK);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }

                    // Inhalt löschen
                    var deleteResult = _empfehlungenRepository.Delete(_bereich, _inhalt);
                    if (!deleteResult)
                    {
                        MessageBox.Show("Löschen nicht möglich. Bitte erneut probieren", "Fehler", MessageBoxButtons.OK);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                DialogResult = DialogResult.None;
                Close();
            }
        }

        private void CheckBoxVerbindungenErsetzen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVerbindungenErsetzen.Checked)
            {
                labelNeuerInhalt.Visible = true;
                comboBoxInhalte.Visible = true;

                var inhalte = _empfehlungenRepository.GetAllForOverview(_bereich);
                var values = inhalte.Values.FirstOrDefault();
                if (inhalte != null)
                {
                    comboBoxInhalte.DataSource = values;
                    values?.Remove(_inhalt);
                    comboBoxInhalte.DataSource = values;
                }
            }
            else
            {
                labelNeuerInhalt.Visible = false;
                comboBoxInhalte.Visible = false;
            }
        }
    }
}
