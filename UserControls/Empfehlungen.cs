using Materialempfehlung.Forms;
using Materialempfehlung.Repository;

namespace Materialempfehlung
{
    public partial class Empfehlungen : UserControl
    {
        private readonly EmpfehlungenRepository _empfehlungenRepository;

        public Empfehlungen()
        {
            InitializeComponent();
            _empfehlungenRepository = new EmpfehlungenRepository();
        }

        private void LöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bereich = (string)listBoxEmpfehlungen_Bereiche.SelectedItem;
            var inhalt = (string)listBoxMaterialEmpfehlung_Inhalt.SelectedItem;
            if (string.IsNullOrEmpty(bereich) || string.IsNullOrEmpty(inhalt))
            {
                MessageBox.Show("Bereich oder Inhalt muss ausgewählt sein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = new EmpfehlungenErsetzen(bereich, inhalt);
            result.ShowDialog();            
        }

        private void NeuerBereichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToDo testing
            var datenDialog = new DatenDialog();
            datenDialog.ShowDialog();
            if (datenDialog.DialogResult == DialogResult.OK)
            {
                listBoxEmpfehlungen_Bereiche.Items.Add(datenDialog.Bereich);
            }
        }

        private void NeuerInhaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bereich = (string)listBoxEmpfehlungen_Bereiche.SelectedItem;
            if (string.IsNullOrEmpty(bereich))
            {
                errorProviderEmpfehlungen.SetError(listBoxEmpfehlungen_Bereiche, "Bereich muss ausgewählt sein");
                return;
            }

            var datenDialog = new DatenDialog(bereich);
            datenDialog.ShowDialog();
            if (datenDialog.DialogResult == DialogResult.OK)
            {
                var items = (List<string>)listBoxMaterialEmpfehlung_Inhalt.DataSource;
                items.Add(datenDialog.Inhalt);
                listBoxMaterialEmpfehlung_Inhalt.DataSource = null;
                listBoxMaterialEmpfehlung_Inhalt.DataSource = items;
            }
        }

        private void ListBoxEmpfehlungen_Detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bereich = listBoxEmpfehlungen_Bereiche.SelectedItem.ToString();
            if (string.IsNullOrEmpty(bereich))
            {
                errorProviderEmpfehlungen.SetError(listBoxEmpfehlungen_Bereiche, "Bitte Bereich auswählen");
            }
            else
            {
                var relations = _empfehlungenRepository.GetAllForOverview(bereich);
                var values = relations.Values.Cast<IList<string>>().FirstOrDefault();
                if (relations != null && values?.Count > 0)
                {
                    listBoxMaterialEmpfehlung_Inhalt.DataSource = values;
                }
                else
                {
                    listBoxMaterialEmpfehlung_Inhalt.DataSource = new List<string>();
                    MessageBox.Show("Es gibt keine Inhalte für diese Empfehlung", "Fehler", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void ListBoxEmpfehlungen_Bereiche_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listBoxEmpfehlungen_Bereiche.ContextMenuStrip = contextMenuStripBereiche;
                contextMenuStripBereiche.Show();
            }
        }
    }
}
