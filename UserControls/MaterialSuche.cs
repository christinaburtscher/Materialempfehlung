using Materialempfehlung.Models;
using Materialempfehlung.Repository;
using System.Data;

namespace Materialempfehlung.UserControls
{
    public partial class MaterialSuche : UserControl
    {
        private readonly EmpfehlungenRepository _empfehlungenRepository = new();
        private readonly MaterialRepository _materialRepository = new();
        private readonly List<Empfehlung> EmpfehlungenSuche = new();
        private bool _initialLoading = false;

        public MaterialSuche()
        {
            InitializeComponent();
            EmpfehlungenLaden();
        }

        private void EmpfehlungenLaden()
        {
            var gesamteEmpfehlungen = _empfehlungenRepository.GetAll();
            if (gesamteEmpfehlungen == null || gesamteEmpfehlungen.Keys.Count <= 0)
            {
                MessageBox.Show("Empfehlungen können nicht geladen werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _initialLoading = true;

            foreach (var key in gesamteEmpfehlungen.Keys)
            {
                if (gesamteEmpfehlungen.TryGetValue(key, out var gesamteInhalte))
                {
                    var falscheWerte = gesamteInhalte.Where(o => o.Equals("---")).ToList();
                    gesamteInhalte = gesamteInhalte.Except(falscheWerte).ToList();
                    gesamteInhalte.Insert(0, "---");

                    //get needed combobox
                    var neededCombobox = groupBoxInhalte.Controls.OfType<ComboBox>().Where(o => o.AccessibleName == key).FirstOrDefault();
                    if (neededCombobox != null)
                    {
                        neededCombobox.DataSource = null;
                        neededCombobox.DataSource = gesamteInhalte;
                    }
                }
            }

            _initialLoading = false;
        }


        private void EmpfehlungAuswahlHinzufügen(ComboBox comboBoxÄußererEinfluss)
        {
            var empfehlung = new Empfehlung
            {
                Bereich = comboBoxÄußererEinfluss.AccessibleName,
                Inhalt = (string)comboBoxÄußererEinfluss.SelectedItem
            };

            var result = EmpfehlungenSuche.Where(o => o.Bereich == empfehlung.Bereich && o.Inhalt == empfehlung.Inhalt).FirstOrDefault();
            if (result == null && !empfehlung.Inhalt.Equals("---"))
            {
                EmpfehlungenSuche.Add(empfehlung);
                dataGridViewSuchkriterien.DataSource = null;
                dataGridViewSuchkriterien.DataSource = EmpfehlungenSuche;
            }
        }

        private void ButtonSuche_Click(object sender, EventArgs e)
        {
            //Material suchen, welches alle Kriterien erfüllt
            var result = new List<int>();

            foreach (var empfehlung in EmpfehlungenSuche)
            {
                if (!string.IsNullOrEmpty(empfehlung.Bereich) && !string.IsNullOrEmpty(empfehlung.Inhalt))
                {
                    var preisartikel = _materialRepository.PreisartikelFürEmpfehlungen(empfehlung.Bereich, empfehlung.Inhalt);
                    if (result.Count > 0)
                    {
                        result = result.Intersect(preisartikel).ToList();
                    }
                    else
                    {
                        result = preisartikel;
                    }
                }
            }

            var materialien = _materialRepository.GetMaterialInformationen(result);
            if (materialien == null)
            {
                MessageBox.Show("Materialempfehlungen konnten nicht geladen werden", "Fehler", MessageBoxButtons.OK);
                return;
            }
            else
            {
                dataGridViewMaterialübersicht.DataSource = materialien;
            }
        }

        private void ComboBoxÄußererEinfluss_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxÄußererEinfluss);
            }
        }

        private void ComboBoxBedingungen_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxBedingungen);
            }
        }

        private void ComboBoxBesonderheit_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxBesonderheit);
            }
        }

        private void ComboBoxDruckverfahren_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxDruckverfahren);
            }
        }

        private void ComboBoxKategorien_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxKategorien);
            }
        }

        private void ComboBoxKlebstoff_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxKlebstoff);
            }
        }

        private void ComboBoxVeredelung_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxVeredelung);
            }
        }

        private void ComboBoxOberfläche_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxOberfläche);
            }
        }

        private void ComboBoxOberfläche_Beschaffenheit_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxOberfläche_Beschaffenheit);
            }
        }

        private void ComboBoxOberfläche_Farbe_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxOberfläche_Farbe);
            }
        }

        private void ComboBoxOberfläche_Form_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxOberfläche_Form);
            }
        }

        private void ComboBoxOberfläche_Zustand_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                EmpfehlungAuswahlHinzufügen(comboBoxOberfläche_Zustand);
            }
        }

        private void DataGridViewSuchkriterien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridViewSuchkriterien.SelectedRows[0].DataBoundItem is Empfehlung selectedItem)
                {
                    EmpfehlungenSuche.Remove(selectedItem);
                    dataGridViewSuchkriterien.DataSource = null;
                    dataGridViewSuchkriterien.DataSource = EmpfehlungenSuche;
                }
            }
        }
    }
}

