using Materialempfehlung.Models;
using Materialempfehlung.Repository;
using System.Windows.Forms;

namespace Materialempfehlung
{
    public partial class Materialübersicht : UserControl
    {
        private readonly MaterialRepository _materialRepository;
        private readonly EmpfehlungenRepository _empfehlungenRepository;
        private DataGridView _selectedDataGridView = new();
        private bool _initialLoading = false;

        public Materialübersicht()
        {
            InitializeComponent();
            _materialRepository = new MaterialRepository();
            _empfehlungenRepository = new EmpfehlungenRepository();

            labelInaktiv.Visible = false;
        }

        public void LoadMaterial(List<MaterialVorschlag> vorschläge)
        {
            comboBoxArtikelnummer.DataSource = vorschläge;
            comboBoxArtikelnummer.DisplayMember = "Artikelnummer_Bezeichnung";
            comboBoxArtikelnummer.DroppedDown = true;

            buttonMaterialübersichtSpeichern.Visible = false;
        }

        private void ButtonMaterialübersichtSpeichern_Click(object sender, EventArgs e)
        {
            if (comboBoxArtikelnummer.SelectedItem is MaterialVorschlag selectedItem)
            {
                var materialExists = _materialRepository.MaterialExistiert(selectedItem.Preisartikel);
                Material? resultMaterial;
                if (!materialExists)
                {
                    // Material hinzufügen
                    var material = new Material
                    {
                        Artikelnummer_Bezeichnung = selectedItem.Artikelnummer_Bezeichnung,
                        Preisartikel = selectedItem.Preisartikel,
                        Bemerkung = textBoxBemerkung.Text,
                    };

                    var addResult = _materialRepository.Add(material);
                    if (addResult == null)
                    {
                        errorProviderMaterialübersicht.SetError(comboBoxArtikelnummer, "Fehler beim hinzufügen. Ist die Artikelnummer korrekt?");
                        return;
                    }

                    resultMaterial = addResult;
                }
                else
                {
                    // Material aktualisieren 
                    var updateMaterial = new Material
                    {
                        Artikelnummer_Bezeichnung = selectedItem.Artikelnummer_Bezeichnung,
                        Preisartikel = selectedItem.Preisartikel,
                        Bemerkung = textBoxBemerkung.Text,
                    };

                    var updateResult = _materialRepository.Update(updateMaterial);
                    if (updateResult == null)
                    {
                        errorProviderMaterialübersicht.SetError(comboBoxArtikelnummer, "Fehler beim aktualisieren. Bitte erneut probieren");
                        return;
                    }

                    resultMaterial = updateResult;
                }

                FelderBefüllen(resultMaterial);
            }
            else
            {
                errorProviderMaterialübersicht.SetError(comboBoxArtikelnummer, "Keine gültige Artikelnummer ausgewählt");
            }
        }

        private void HinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var items = new List<string>();
            foreach (DataGridViewRow row in _selectedDataGridView.Rows)
            {
                var test = row.Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(test))
                {
                    items.Add(test);
                }
            }

            if (comboBoxArtikelnummer.SelectedItem is MaterialVorschlag selectedItem)
            {
                var materialExistiert = _materialRepository.MaterialExistiert(selectedItem.Preisartikel);
                if (!materialExistiert)
                {
                    buttonMaterialübersichtSpeichern.Visible = true;
                    errorProviderMaterialübersicht.SetError(_selectedDataGridView, "Material muss zuerst gespeichert werden");
                    return;
                }

                var empfehlungHinzufügen = new EmpfehlungHinzufügen(selectedItem, _selectedDataGridView.AccessibleName, items);
                var result = empfehlungHinzufügen.ShowDialog();
                if (result == DialogResult.OK)
                {

                    //neue Werte in Listbox anzeigen
                    var empfehlungen = _materialRepository.GetByBereich(selectedItem.Preisartikel, _selectedDataGridView.AccessibleName);
                    _selectedDataGridView.DataSource = null;
                    _selectedDataGridView.DataSource = empfehlungen.Select(o => new { Value = o }).ToList(); ;
                }
            }
        }

        private void FelderBefüllen(Material material)
        {
            textBoxBezeichnung.Text = material.Bezeichnung;
            textBoxQualität.Text = material.Qualität;
            textBoxPreis.Text = material.Preis.ToString();
            textBoxLieferzeit.Text = material.Lieferzeit.ToString();
            textBoxBemerkung.Text = material.Bemerkung;
            textBoxStatus.Text = material.Status;
            textBoxFarbe.Text = material.Farbe;
            textBoxMaterialeigenschaften.Text = material.Materialeigenschaften;
            textBoxKlebstoffeigenschaften.Text = material.Klebstoffeigenschaften;
            textBoxTrägerpapier.Text = material.Trägerpapier;
            textBoxTrägerpapiereigenschaften.Text = material.Trägerpapiereigenschaften;
            textBoxLagerbedingungen.Text = material.Lagerbedingungen;
            textBoxNachhaltigkeit.Text = material.Nachhaltigkeit_Ökologie;
        }

        private void ComboBoxArtikelnummer_Leave(object sender, EventArgs e)
        {
            if (comboBoxArtikelnummer.SelectedItem is MaterialVorschlag selectedVorschlag)
            {
                var material = _materialRepository.GetByPreisartikel(selectedVorschlag.Preisartikel);
                if (material != null)
                {
                    if (!material.Inaktiv)
                    {
                        labelInaktiv.Visible = false;
                        ComboboxSichtbarkeit(true);
                        DatagridAktiv(true);
                        FelderBefüllen(material);

                        var relations = _materialRepository.EmpfehlungenFürPreisartikel(selectedVorschlag.Preisartikel);

                        relations.Add(new Material2Empfehlung
                        {
                            Artikelnummer_Bezeichnung = material.Artikelnummer_Bezeichnung,
                            Bereich = "Klebstoff",
                            Preisartikel = material.Preisartikel,
                            Inhalt = material.Klebstoff_Printplus ?? string.Empty
                        });

                        var gesamteEmpfehlungen = _empfehlungenRepository.GetAll();
                        if (gesamteEmpfehlungen == null || gesamteEmpfehlungen.Keys.Count <= 0)
                        {
                            errorProviderMaterialübersicht.SetError(groupBoxEmpfehlungen, "Empfehlungen können nicht geladen werden");
                            return;
                        }

                        _initialLoading = true;
                        var datagrids = groupBoxEmpfehlungen.Controls.OfType<DataGridView>().Select(o => o.AccessibilityObject).Where(w => !string.IsNullOrEmpty(w.Name)).Select(v => v.Name);
                        foreach (var datagrid in datagrids)
                        {
                            if (!string.IsNullOrEmpty(datagrid))
                            {
                                // get all matching relations 
                                var empfehlungen = relations.Where(o => o.Bereich == datagrid).Select(v => v.Inhalt).Distinct().ToList();

                                var datagridView = groupBoxEmpfehlungen.Controls.OfType<DataGridView>().Where(o => o.AccessibleName == datagrid).FirstOrDefault();
                                if (datagridView != null)
                                {
                                    datagridView.DataSource = null;
                                    datagridView.DataSource = empfehlungen.Select(o => new { Value = o }).ToList();

                                    if (gesamteEmpfehlungen.TryGetValue(datagridView.AccessibleName, out var gesamteInhalte))
                                    {
                                        var bestehendeEmpfehlungen = relations.Where(o => o.Bereich == datagridView.AccessibleName).Select(v => v.Inhalt).ToList();
                                        var newDataSource = gesamteInhalte.Except(bestehendeEmpfehlungen).ToList();

                                        //get needed combobox
                                        var neededCombobox = groupBoxEmpfehlungen.Controls.OfType<ComboBox>().Where(o => o.AccessibleName == datagrid).FirstOrDefault();
                                        if (neededCombobox != null)
                                        {
                                            neededCombobox.DataSource = null;
                                            neededCombobox.DataSource = newDataSource;
                                        }
                                    }
                                }
                            }
                        }

                        _initialLoading = false;

                        if (material.Id > 0 || material.Inaktiv)
                        {
                            buttonMaterialübersichtSpeichern.Visible = false;
                        }
                        else
                        {
                            buttonMaterialübersichtSpeichern.Visible = true;
                        }
                    }
                    else
                    {
                        labelInaktiv.Visible = true;
                        ComboboxSichtbarkeit(false);
                        DatagridAktiv(false);
                    }
                }
            }
        }

        private void DatagridAktiv(bool aktiv)
        {
            dataGridViewBedingung.Enabled = aktiv;
            dataGridViewBesonderheit.Enabled = aktiv;
            dataGridViewDruckverfahren.Enabled = aktiv;
            dataGridViewKategorie.Enabled = aktiv;
            dataGridViewKlebstoff.Enabled = aktiv;
            dataGridViewOberfläche.Enabled = aktiv;
            dataGridViewOberfläche_Beschaffenheit.Enabled = aktiv;
            dataGridViewOberfläche_Farbe.Enabled = aktiv;
            dataGridViewOberfläche_Form.Enabled = aktiv;
            dataGridViewOberfläche_Zustand.Enabled = aktiv;
            dataGridViewVeredelung.Enabled = aktiv;
            dataGridViewÄußerer_Einfluss.Enabled = aktiv;
        }

        private void ComboboxSichtbarkeit(bool sichtbarkeit)
        {
            comboBoxBedingung.Visible = sichtbarkeit;
            comboBoxBesonderheit.Visible = sichtbarkeit;
            comboBoxDruckverfahren.Visible = sichtbarkeit;
            comboBoxKategorie.Visible = sichtbarkeit;
            comboBoxKlebstoff.Visible = sichtbarkeit;
            comboBoxOberfläche.Visible = sichtbarkeit;
            comboBoxOberfläche_Beschaffenheit.Visible = sichtbarkeit;
            comboBoxOberfläche_Farbe.Visible = sichtbarkeit;
            comboBoxOberfläche_Form.Visible = sichtbarkeit;
            comboBoxOberfläche_Zustand.Visible = sichtbarkeit;
            comboBoxVeredelung.Visible = sichtbarkeit;
            comboBoxÄußerer_Einfluss.Visible = sichtbarkeit;
        }

        private void TextBoxBemerkung_Leave(object sender, EventArgs e)
        {
            var text = textBoxBemerkung.Text;
            if (text.Length >= 3)
            {
                buttonMaterialübersichtSpeichern.Visible = true;
            }
        }

        private void DataGridViewÄußerer_Einfluss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewÄußerer_Einfluss;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewBedingung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewBedingung;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewBesonderheit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewBesonderheit;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewDruckverfahren_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewDruckverfahren;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewKategorie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewKategorie;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewKlebstoff_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewKlebstoff;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewVeredelung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewVeredelung;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewOberfläche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewOberfläche;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewOberfläche_Beschaffenheit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewOberfläche_Beschaffenheit;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewOberfläche_Farbe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewOberfläche_Farbe;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewOberfläche_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewOberfläche_Form;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DataGridViewOberfläche_Zustand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedDataGridView = dataGridViewOberfläche_Zustand;
                DeleteRelation(_selectedDataGridView);
            }
        }

        private void DeleteRelation(DataGridView selectedDataGrid)
        {
            if (comboBoxArtikelnummer.SelectedItem is MaterialVorschlag selectedItem)
            {
                //get selected item
                var inhalt = new List<string>();
                var allRows = new List<string>();
                foreach (DataGridViewRow row in _selectedDataGridView.Rows)
                {
                    allRows.Add(row.Cells[0].Value.ToString());
                    if (row.Selected)
                    {
                        var test = row.Cells[0].Value.ToString();
                        if (!string.IsNullOrEmpty(test))
                        {
                            inhalt.Add(test);
                            var result = MessageBox.Show($"Soll die Empfehlung '{test}' wirklich gelöscht werden?", "Frage", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //relation löschen
                                var deleteResult = _materialRepository.EmpfehlungenLöschen(selectedItem.Preisartikel, selectedDataGrid.AccessibleName, test);
                                if (!deleteResult)
                                {
                                    MessageBox.Show("Löschen nicht möglich. Bitte erneut probieren", "Error", MessageBoxButtons.OK);
                                    return;
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }

                //neue Werte in Listbox anzeigen
                var newDatasource = allRows.Except(inhalt).ToList();
                selectedDataGrid.DataSource = null;
                selectedDataGrid.DataSource = newDatasource.Select(o => new { Value = o }).ToList(); ;

                // neue Werte für Combobox laden 
                var empfehlungen = _empfehlungenRepository.GetAllForOverview(selectedDataGrid.AccessibleName);
                if (empfehlungen != null)
                {
                    if (empfehlungen.TryGetValue(selectedDataGrid.AccessibleName, out var gesamteInhalte))
                    {
                        var auswählbareEmpfehlungen = gesamteInhalte.Except(newDatasource).ToList();

                        //get needed combobox
                        var neededCombobox = groupBoxEmpfehlungen.Controls.OfType<ComboBox>().Where(o => o.AccessibleName == selectedDataGrid.AccessibleName).FirstOrDefault();
                        if (neededCombobox != null)
                        {
                            neededCombobox.DataSource = null;
                            neededCombobox.DataSource = auswählbareEmpfehlungen;
                        }
                    }
                }
            }
        }

        private void AddRelation(ComboBox combobox)
        {
            var inhalt = (string)combobox.SelectedItem;
            if (inhalt != "---" && !string.IsNullOrEmpty(inhalt))
            {
                if (comboBoxArtikelnummer.SelectedItem is MaterialVorschlag selectedItem)
                {
                    // add relation 
                    var addResult = _materialRepository.AddRelation(selectedItem.Preisartikel, combobox.AccessibleName, inhalt);
                    if (!addResult)
                    {
                        MessageBox.Show("Empfehlung konnte nicht hinzugefügt werden", "Fehler", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        //alle relations laden und anzeigen
                        var empfehlungen = _materialRepository.GetByBereich(selectedItem.Preisartikel, combobox.AccessibleName);
                        var dataGridView = groupBoxEmpfehlungen.Controls.OfType<DataGridView>().Where(o => o.AccessibleName == combobox.AccessibleName).FirstOrDefault();
                        if (dataGridView != null)
                        {
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = empfehlungen.Select(o => new { Value = o }).ToList(); ;
                        }
                    }
                }
            }
        }

        private void ComboBoxÄußerer_Einfluss_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxÄußerer_Einfluss);
            }
        }

        private void ComboBoxBedingung_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxBedingung);
            }
        }

        private void ComboBoxBesonderheit_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxBesonderheit);
            }
        }

        private void ComboBoxDruckverfahren_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxDruckverfahren);
            }
        }

        private void ComboBoxKategorie_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxKategorie);
            }
        }

        private void ComboBoxKlebstoff_TextChanged(object sender, EventArgs e)
        {
            AddRelation(comboBoxKlebstoff);
        }

        private void ComboBoxVeredelung_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxVeredelung);
            }
        }

        private void ComboBoxOberfläche_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxOberfläche);
            }
        }

        private void ComboBoxOberfläche_Beschaffenheit_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxOberfläche_Beschaffenheit);
            }
        }

        private void ComboBoxOberfläche_Farbe_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxOberfläche_Farbe);
            }
        }

        private void ComboBoxOberfläche_Form_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxOberfläche_Form);
            }
        }

        private void ComboBoxOberfläche_Zustand_TextChanged(object sender, EventArgs e)
        {
            if (!_initialLoading)
            {
                AddRelation(comboBoxOberfläche_Zustand);
            }
        }
    }
}

