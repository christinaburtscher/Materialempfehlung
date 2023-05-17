using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materialempfehlung
{
    public partial class DatenDialog : Form
    {
        private string _bereich;
        private string _feld;

        public DatenDialog()
        {
            InitializeComponent();
        }

        public DatenDialog(string bereich, string feld)
        {
            InitializeComponent();

            comboBoxDatenDialogBereich.SelectedItem = bereich;
            _bereich = bereich;

            textBoxDetailBearbeiten.Text = feld;
            _feld = feld;
        }

        private void buttonEmpfehlungDetailSpeichern_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBoxDatenDialogBereich.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedItem))
            {
                _bereich = selectedItem;
            }
            else
            {
                errorProvider1.SetError(comboBoxDatenDialogBereich, "Bereich ist leer. Bitte Bereich ausfüllen");
            }

            if (!string.IsNullOrEmpty(textBoxDetailBearbeiten.Text))
            {
                _feld = textBoxDetailBearbeiten.Text;
            }
            else
            {
                errorProvider1.SetError(textBoxDetailBearbeiten, "Detail ist leer. Bitte Detail ausfüllen");
            }

            //ToDo add logic for implementing repository actions
        }
    }
}
