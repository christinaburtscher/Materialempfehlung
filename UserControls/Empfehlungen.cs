namespace Materialempfehlung
{
    public partial class Empfehlungen : UserControl
    {
        public Empfehlungen()
        {
            InitializeComponent();
            listBoxMaterialEmpfehlung_Detail.ContextMenuStrip = contextMenuStripBereiche;
        }

        private void NeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var datenDialog = new DatenDialog();
            var result = datenDialog.ShowDialog();
        }

        private void BearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToDo implement
            var bereich = listBoxEmpfehlungen_Detail.SelectedItem.ToString();
            var feld = listBoxMaterialEmpfehlung_Detail.SelectedItem.ToString();
            var datendialog = new DatenDialog(bereich, feld);
            datendialog.ShowDialog();
        }

        private void LöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToDo implement
        }

        private void ListBoxEmpfehlungen_Detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bereich = listBoxEmpfehlungen_Detail.SelectedItem.ToString();
            if (string.IsNullOrEmpty(bereich))
            {
                errorProviderEmpfehlungen.SetError(listBoxEmpfehlungen_Detail, "Bitte Bereich auswählen");
            }
            else 
            {
                //ToDo implement database operations with generic 
            }
        }
    }
}
