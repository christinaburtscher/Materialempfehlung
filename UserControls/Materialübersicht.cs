using Materialempfehlung.Models;
using Materialempfehlung.Repository;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Runtime.CompilerServices;

namespace Materialempfehlung
{
    public partial class Materialübersicht : UserControl
    {
        private readonly MaterialRepository _materialRepository;
        private readonly EmpfehlungenRepository _empfehlungenRepository;
        private ListBox _selectedListBox = new();
        private bool _initialLoading = false;

        public Materialübersicht()
        {
            InitializeComponent();
            _materialRepository = new MaterialRepository();
            _empfehlungenRepository = new EmpfehlungenRepository();
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
            var items = _selectedListBox.Items.Cast<string>().ToList();
            if (comboBoxArtikelnummer.SelectedItem is MaterialVorschlag selectedItem)
            {
                var materialExistiert = _materialRepository.MaterialExistiert(selectedItem.Preisartikel);
                if (!materialExistiert)
                {
                    buttonMaterialübersichtSpeichern.Visible = true;
                    errorProviderMaterialübersicht.SetError(_selectedListBox, "Material muss zuerst gespeichert werden");
                    return;
                }

                var empfehlungHinzufügen = new EmpfehlungHinzufügen(selectedItem, _selectedListBox.AccessibleName, items);
                var result = empfehlungHinzufügen.ShowDialog();
                if (result == DialogResult.OK)
                {

                    //neue Werte in Listbox anzeigen
                    var empfehlungen = _materialRepository.GetByBereich(selectedItem.Preisartikel, _selectedListBox.AccessibleName);
                    _selectedListBox.DataSource = null;
                    _selectedListBox.DataSource = empfehlungen;
                }
            }
        }

        private void EntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!buttonMaterialübersichtSpeichern.Visible)
            {
                errorProviderMaterialübersicht.SetError(_selectedListBox, "Material muss zuerst gespeichert werden");
                return;
            }

            var listBoxName = _selectedListBox.AccessibleName;
            var selectedRelation = (string)_selectedListBox.SelectedItem;
            if (string.IsNullOrEmpty(selectedRelation))
            {
                errorProviderMaterialübersicht.SetError(_selectedListBox, "Kein Inhalt ausgewählt");
                return;
            }

            if (comboBoxArtikelnummer.SelectedItem is MaterialVorschlag selectedItem)
            {
                var deleteResult = _materialRepository.RemoveRelation(selectedItem.Preisartikel, listBoxName, selectedRelation);
                if (!deleteResult)
                {
                    errorProviderMaterialübersicht.SetError(_selectedListBox, "Inhalt konnte nicht entfernt werden. Bitte nochmal probieren");
                }
            }
            else
            {
                errorProviderMaterialübersicht.SetError(comboBoxArtikelnummer, "Keine Artiklenummer ausgewählt");
                return;
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
                        ListboxAktiv(true);
                        FelderBefüllen(material);

                        var relations = _materialRepository.EmpfehlungenFürPreisartikel(selectedVorschlag.Preisartikel);

                        // Empfehlung für Klebstoff zur Ansicht hinzufügen
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
                        var listboxes = groupBoxEmpfehlungen.Controls.OfType<ListBox>().Select(o => o.AccessibilityObject).Where(w => !string.IsNullOrEmpty(w.Name)).Select(v => v.Name);
                        foreach (var listbox in listboxes)
                        {
                            if (!string.IsNullOrEmpty(listbox))
                            {
                                // get all matching relations 
                                var empfehlungen = relations.Where(o => o.Bereich == listbox).Select(v => v.Inhalt).Distinct().ToList();
                                var neededListbox = groupBoxEmpfehlungen.Controls.OfType<ListBox>().Where(o => o.AccessibleName == listbox).FirstOrDefault();
                                if (neededListbox != null)
                                {
                                    neededListbox.DataSource = null;
                                    neededListbox.DataSource = empfehlungen;

                                    if (gesamteEmpfehlungen.TryGetValue(neededListbox.AccessibleName, out var gesamteInhalte))
                                    {
                                        var bestehendeEmpfehlungen = relations.Where(o => o.Bereich == neededListbox.AccessibleName).Select(v => v.Inhalt).ToList();
                                        var newDataSource = gesamteInhalte.Except(bestehendeEmpfehlungen).ToList();

                                        //get needed combobox
                                        var neededCombobox = groupBoxEmpfehlungen.Controls.OfType<ComboBox>().Where(o => o.AccessibleName == listbox).FirstOrDefault();
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
                        ListboxAktiv(false);
                    }
                }
            }
        }

        private void ListboxAktiv(bool aktiv)
        {
            listBoxBedingungen.Enabled = aktiv;
            listBoxBesonderheiten.Enabled = aktiv;
            listBoxDruckverfahren.Enabled = aktiv;
            listBoxKategorien.Enabled = aktiv;
            listBoxKlebstoff.Enabled = aktiv;
            listBoxOberfläche.Enabled = aktiv;
            listBoxOberflächeBeschaffenheit.Enabled = aktiv;
            listBoxOberflächeFarbe.Enabled = aktiv;
            listBoxOberflächeForm.Enabled = aktiv;
            listBoxOberflächeZustand.Enabled = aktiv;
            listBoxVeredelung.Enabled = aktiv;
            listBoxÄußereEinflüsse.Enabled = aktiv;
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
            if (text.Length >= 10)
            {
                buttonMaterialübersichtSpeichern.Visible = true;
            }
        }

        private void ListBoxÄußereEinflüsse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxÄußereEinflüsse;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxBedingungen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxBedingungen;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxBesonderheiten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxBesonderheiten;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxDruckverfahren_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxDruckverfahren;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxKategorien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxKategorien;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxKlebstoff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxKlebstoff;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxVeredelung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxVeredelung;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxOberfläche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxOberfläche;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxOberflächeBeschaffenheit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxOberflächeBeschaffenheit;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxOberflächeFarbe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxOberflächeFarbe;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxOberflächeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxOberflächeForm;
                DeleteRelation(_selectedListBox);
            }
        }

        private void ListBoxOberflächeZustand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _selectedListBox = listBoxOberflächeZustand;
                DeleteRelation(_selectedListBox);
            }
        }

        private void DeleteRelation(ListBox selectedListBox)
        {
            if (comboBoxArtikelnummer.SelectedItem is MaterialVorschlag selectedItem)
            {
                //get selected item
                var inhalt = selectedListBox.SelectedItems.Cast<string>().ToList();
                foreach (var item in inhalt)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        var result = MessageBox.Show($"Soll die Empfehlung '{item}' wirklich gelöscht werden?", "Frage", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //relation löschen
                            var deleteResult = _materialRepository.EmpfehlungenLöschen(selectedItem.Preisartikel, selectedListBox.AccessibleName, item);
                            if (!deleteResult)
                            {
                                MessageBox.Show("Löschen nicht möglich. Bitte erneut probieren", "Error", MessageBoxButtons.OK);
                                return;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                //neue Werte in Listbox anzeigen
                var items = selectedListBox.SelectedItems.Cast<string>().ToList();
                var newDatasource = items.Except(items).ToList();
                selectedListBox.DataSource = null;
                selectedListBox.DataSource = newDatasource;
            }
        }

        private void AddRelation(ComboBox combobox)
        {
            var inhalt = (string)combobox.SelectedItem;
            if (string.IsNullOrEmpty(inhalt))
            {
                errorProviderMaterialübersicht.SetError(combobox, "Ein Inhalt muss ausgewählt werden");
                return;
            }

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
                    var listBox = groupBoxEmpfehlungen.Controls.OfType<ListBox>().Where(o => o.AccessibleName == combobox.AccessibleName).FirstOrDefault();
                    if (listBox != null)
                    {
                        listBox.DataSource = null;
                        listBox.DataSource = empfehlungen;
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
            if (!_initialLoading)
            {
                AddRelation(comboBoxKlebstoff);
            }
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

