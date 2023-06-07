namespace Materialempfehlung
{
    partial class Materialübersicht
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label labelBesonderheiten;
            label12 = new Label();
            labelOberfläche_Zustand = new Label();
            labelOberfläche_Form = new Label();
            label9 = new Label();
            labelOberfläche_Beschaffenheit = new Label();
            groupBoxEmpfehlungen = new GroupBox();
            comboBoxOberfläche_Zustand = new ComboBox();
            comboBoxOberfläche_Form = new ComboBox();
            comboBoxOberfläche_Farbe = new ComboBox();
            comboBoxOberfläche_Beschaffenheit = new ComboBox();
            comboBoxOberfläche = new ComboBox();
            comboBoxVeredelung = new ComboBox();
            comboBoxKlebstoff = new ComboBox();
            comboBoxÄußerer_Einfluss = new ComboBox();
            comboBoxBedingung = new ComboBox();
            comboBoxBesonderheit = new ComboBox();
            comboBoxDruckverfahren = new ComboBox();
            comboBoxKategorie = new ComboBox();
            listBoxOberflächeZustand = new ListBox();
            listBoxOberflächeForm = new ListBox();
            listBoxOberflächeFarbe = new ListBox();
            listBoxOberflächeBeschaffenheit = new ListBox();
            listBoxOberfläche = new ListBox();
            listBoxVeredelung = new ListBox();
            listBoxKlebstoff = new ListBox();
            listBoxKategorien = new ListBox();
            listBoxDruckverfahren = new ListBox();
            listBoxBesonderheiten = new ListBox();
            listBoxBedingungen = new ListBox();
            listBoxÄußereEinflüsse = new ListBox();
            labelOberfläche = new Label();
            labelKlebstoff = new Label();
            labelKategorien = new Label();
            labelDruckverfahren = new Label();
            label2 = new Label();
            labelÄußereEinflüsse = new Label();
            splitContainer1 = new SplitContainer();
            groupBoxInformationen = new GroupBox();
            comboBoxArtikelnummer = new ComboBox();
            textBoxFarbe = new TextBox();
            labelFarbe = new Label();
            textBoxStatus = new TextBox();
            labelStatus = new Label();
            buttonMaterialübersichtSpeichern = new Button();
            textBoxLieferzeit = new TextBox();
            textBoxPreis = new TextBox();
            textBoxBemerkung = new TextBox();
            textBoxQualität = new TextBox();
            textBoxBezeichnung = new TextBox();
            labelLieferzeit = new Label();
            labelBemerkung = new Label();
            labelQualität = new Label();
            labelPreis = new Label();
            labelBezeichnung = new Label();
            labelArtikelnummer = new Label();
            errorProviderMaterialübersicht = new ErrorProvider(components);
            labelInaktiv = new Label();
            labelBesonderheiten = new Label();
            groupBoxEmpfehlungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxInformationen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderMaterialübersicht).BeginInit();
            SuspendLayout();
            // 
            // labelBesonderheiten
            // 
            labelBesonderheiten.AutoSize = true;
            labelBesonderheiten.Location = new Point(9, 256);
            labelBesonderheiten.Name = "labelBesonderheiten";
            labelBesonderheiten.Size = new Size(89, 15);
            labelBesonderheiten.TabIndex = 2;
            labelBesonderheiten.Text = "Besonderheiten";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(350, 154);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 11;
            label12.Text = "Veredelung";
            // 
            // labelOberfläche_Zustand
            // 
            labelOberfläche_Zustand.AutoSize = true;
            labelOberfläche_Zustand.Location = new Point(650, 461);
            labelOberfläche_Zustand.Name = "labelOberfläche_Zustand";
            labelOberfläche_Zustand.Size = new Size(68, 30);
            labelOberfläche_Zustand.TabIndex = 10;
            labelOberfläche_Zustand.Text = "Oberfläche \r\nZustand";
            // 
            // labelOberfläche_Form
            // 
            labelOberfläche_Form.AutoSize = true;
            labelOberfläche_Form.Location = new Point(654, 358);
            labelOberfläche_Form.Name = "labelOberfläche_Form";
            labelOberfläche_Form.Size = new Size(65, 30);
            labelOberfläche_Form.TabIndex = 9;
            labelOberfläche_Form.Text = "Oberfläche\r\nForm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(654, 256);
            label9.Name = "label9";
            label9.Size = new Size(68, 30);
            label9.TabIndex = 8;
            label9.Text = "Oberfläche \r\nFarbe";
            // 
            // labelOberfläche_Beschaffenheit
            // 
            labelOberfläche_Beschaffenheit.AutoSize = true;
            labelOberfläche_Beschaffenheit.Location = new Point(653, 150);
            labelOberfläche_Beschaffenheit.Name = "labelOberfläche_Beschaffenheit";
            labelOberfläche_Beschaffenheit.Size = new Size(85, 30);
            labelOberfläche_Beschaffenheit.TabIndex = 7;
            labelOberfläche_Beschaffenheit.Text = "Oberfläche \r\nBeschaffenheit";
            // 
            // groupBoxEmpfehlungen
            // 
            groupBoxEmpfehlungen.Controls.Add(comboBoxOberfläche_Zustand);
            groupBoxEmpfehlungen.Controls.Add(comboBoxOberfläche_Form);
            groupBoxEmpfehlungen.Controls.Add(comboBoxOberfläche_Farbe);
            groupBoxEmpfehlungen.Controls.Add(comboBoxOberfläche_Beschaffenheit);
            groupBoxEmpfehlungen.Controls.Add(comboBoxOberfläche);
            groupBoxEmpfehlungen.Controls.Add(comboBoxVeredelung);
            groupBoxEmpfehlungen.Controls.Add(comboBoxKlebstoff);
            groupBoxEmpfehlungen.Controls.Add(comboBoxÄußerer_Einfluss);
            groupBoxEmpfehlungen.Controls.Add(comboBoxBedingung);
            groupBoxEmpfehlungen.Controls.Add(comboBoxBesonderheit);
            groupBoxEmpfehlungen.Controls.Add(comboBoxDruckverfahren);
            groupBoxEmpfehlungen.Controls.Add(comboBoxKategorie);
            groupBoxEmpfehlungen.Controls.Add(listBoxOberflächeZustand);
            groupBoxEmpfehlungen.Controls.Add(listBoxOberflächeForm);
            groupBoxEmpfehlungen.Controls.Add(listBoxOberflächeFarbe);
            groupBoxEmpfehlungen.Controls.Add(listBoxOberflächeBeschaffenheit);
            groupBoxEmpfehlungen.Controls.Add(listBoxOberfläche);
            groupBoxEmpfehlungen.Controls.Add(listBoxVeredelung);
            groupBoxEmpfehlungen.Controls.Add(listBoxKlebstoff);
            groupBoxEmpfehlungen.Controls.Add(listBoxKategorien);
            groupBoxEmpfehlungen.Controls.Add(listBoxDruckverfahren);
            groupBoxEmpfehlungen.Controls.Add(listBoxBesonderheiten);
            groupBoxEmpfehlungen.Controls.Add(listBoxBedingungen);
            groupBoxEmpfehlungen.Controls.Add(listBoxÄußereEinflüsse);
            groupBoxEmpfehlungen.Controls.Add(label12);
            groupBoxEmpfehlungen.Controls.Add(labelOberfläche_Zustand);
            groupBoxEmpfehlungen.Controls.Add(labelOberfläche_Form);
            groupBoxEmpfehlungen.Controls.Add(label9);
            groupBoxEmpfehlungen.Controls.Add(labelOberfläche_Beschaffenheit);
            groupBoxEmpfehlungen.Controls.Add(labelOberfläche);
            groupBoxEmpfehlungen.Controls.Add(labelKlebstoff);
            groupBoxEmpfehlungen.Controls.Add(labelKategorien);
            groupBoxEmpfehlungen.Controls.Add(labelDruckverfahren);
            groupBoxEmpfehlungen.Controls.Add(labelBesonderheiten);
            groupBoxEmpfehlungen.Controls.Add(label2);
            groupBoxEmpfehlungen.Controls.Add(labelÄußereEinflüsse);
            groupBoxEmpfehlungen.Dock = DockStyle.Fill;
            groupBoxEmpfehlungen.Location = new Point(0, 0);
            groupBoxEmpfehlungen.Name = "groupBoxEmpfehlungen";
            groupBoxEmpfehlungen.Size = new Size(1019, 591);
            groupBoxEmpfehlungen.TabIndex = 0;
            groupBoxEmpfehlungen.TabStop = false;
            groupBoxEmpfehlungen.Text = "Empfehlungen";
            // 
            // comboBoxOberfläche_Zustand
            // 
            comboBoxOberfläche_Zustand.AccessibleName = "Oberfläche_Zustand";
            comboBoxOberfläche_Zustand.FormattingEnabled = true;
            comboBoxOberfläche_Zustand.Location = new Point(745, 461);
            comboBoxOberfläche_Zustand.Name = "comboBoxOberfläche_Zustand";
            comboBoxOberfläche_Zustand.Size = new Size(187, 23);
            comboBoxOberfläche_Zustand.TabIndex = 42;
            comboBoxOberfläche_Zustand.TextChanged += ComboBoxOberfläche_Zustand_TextChanged;
            // 
            // comboBoxOberfläche_Form
            // 
            comboBoxOberfläche_Form.AccessibleName = "Oberfläche_Form";
            comboBoxOberfläche_Form.FormattingEnabled = true;
            comboBoxOberfläche_Form.Location = new Point(746, 358);
            comboBoxOberfläche_Form.Name = "comboBoxOberfläche_Form";
            comboBoxOberfläche_Form.Size = new Size(186, 23);
            comboBoxOberfläche_Form.TabIndex = 41;
            comboBoxOberfläche_Form.TextChanged += ComboBoxOberfläche_Form_TextChanged;
            // 
            // comboBoxOberfläche_Farbe
            // 
            comboBoxOberfläche_Farbe.AccessibleName = "Oberfläche_Farbe";
            comboBoxOberfläche_Farbe.FormattingEnabled = true;
            comboBoxOberfläche_Farbe.Location = new Point(745, 256);
            comboBoxOberfläche_Farbe.Name = "comboBoxOberfläche_Farbe";
            comboBoxOberfläche_Farbe.Size = new Size(187, 23);
            comboBoxOberfläche_Farbe.TabIndex = 40;
            comboBoxOberfläche_Farbe.TextChanged += ComboBoxOberfläche_Farbe_TextChanged;
            // 
            // comboBoxOberfläche_Beschaffenheit
            // 
            comboBoxOberfläche_Beschaffenheit.AccessibleName = "Oberfläche_Beschaffenheit";
            comboBoxOberfläche_Beschaffenheit.FormattingEnabled = true;
            comboBoxOberfläche_Beschaffenheit.Location = new Point(745, 155);
            comboBoxOberfläche_Beschaffenheit.Name = "comboBoxOberfläche_Beschaffenheit";
            comboBoxOberfläche_Beschaffenheit.Size = new Size(187, 23);
            comboBoxOberfläche_Beschaffenheit.TabIndex = 39;
            comboBoxOberfläche_Beschaffenheit.TextChanged += ComboBoxOberfläche_Beschaffenheit_TextChanged;
            // 
            // comboBoxOberfläche
            // 
            comboBoxOberfläche.AccessibleName = "Oberfläche";
            comboBoxOberfläche.FormattingEnabled = true;
            comboBoxOberfläche.Location = new Point(744, 38);
            comboBoxOberfläche.Name = "comboBoxOberfläche";
            comboBoxOberfläche.Size = new Size(188, 23);
            comboBoxOberfläche.TabIndex = 38;
            comboBoxOberfläche.TextChanged += ComboBoxOberfläche_TextChanged;
            // 
            // comboBoxVeredelung
            // 
            comboBoxVeredelung.AccessibleName = "Veredelung";
            comboBoxVeredelung.FormattingEnabled = true;
            comboBoxVeredelung.Location = new Point(443, 155);
            comboBoxVeredelung.Name = "comboBoxVeredelung";
            comboBoxVeredelung.Size = new Size(185, 23);
            comboBoxVeredelung.TabIndex = 37;
            comboBoxVeredelung.TextChanged += ComboBoxVeredelung_TextChanged;
            // 
            // comboBoxKlebstoff
            // 
            comboBoxKlebstoff.AccessibleName = "Klebstoff";
            comboBoxKlebstoff.FormattingEnabled = true;
            comboBoxKlebstoff.Location = new Point(443, 37);
            comboBoxKlebstoff.Name = "comboBoxKlebstoff";
            comboBoxKlebstoff.Size = new Size(186, 23);
            comboBoxKlebstoff.TabIndex = 36;
            comboBoxKlebstoff.TextChanged += ComboBoxKlebstoff_TextChanged;
            // 
            // comboBoxÄußerer_Einfluss
            // 
            comboBoxÄußerer_Einfluss.AccessibleName = "Äußerer_Einfluss";
            comboBoxÄußerer_Einfluss.FormattingEnabled = true;
            comboBoxÄußerer_Einfluss.Location = new Point(143, 38);
            comboBoxÄußerer_Einfluss.Name = "comboBoxÄußerer_Einfluss";
            comboBoxÄußerer_Einfluss.Size = new Size(185, 23);
            comboBoxÄußerer_Einfluss.TabIndex = 35;
            comboBoxÄußerer_Einfluss.TextChanged += ComboBoxÄußerer_Einfluss_TextChanged;
            // 
            // comboBoxBedingung
            // 
            comboBoxBedingung.AccessibleName = "Bedingung";
            comboBoxBedingung.FormattingEnabled = true;
            comboBoxBedingung.Location = new Point(143, 155);
            comboBoxBedingung.Name = "comboBoxBedingung";
            comboBoxBedingung.Size = new Size(185, 23);
            comboBoxBedingung.TabIndex = 34;
            comboBoxBedingung.TextChanged += ComboBoxBedingung_TextChanged;
            // 
            // comboBoxBesonderheit
            // 
            comboBoxBesonderheit.AccessibleName = "Besonderheit";
            comboBoxBesonderheit.FormattingEnabled = true;
            comboBoxBesonderheit.Location = new Point(143, 256);
            comboBoxBesonderheit.Name = "comboBoxBesonderheit";
            comboBoxBesonderheit.Size = new Size(185, 23);
            comboBoxBesonderheit.TabIndex = 33;
            comboBoxBesonderheit.TextChanged += ComboBoxBesonderheit_TextChanged;
            // 
            // comboBoxDruckverfahren
            // 
            comboBoxDruckverfahren.AccessibleName = "Druckverfahren";
            comboBoxDruckverfahren.FormattingEnabled = true;
            comboBoxDruckverfahren.Location = new Point(143, 358);
            comboBoxDruckverfahren.Name = "comboBoxDruckverfahren";
            comboBoxDruckverfahren.Size = new Size(185, 23);
            comboBoxDruckverfahren.TabIndex = 32;
            comboBoxDruckverfahren.TextChanged += ComboBoxDruckverfahren_TextChanged;
            // 
            // comboBoxKategorie
            // 
            comboBoxKategorie.AccessibleName = "Kategorie";
            comboBoxKategorie.FormattingEnabled = true;
            comboBoxKategorie.Location = new Point(143, 461);
            comboBoxKategorie.Name = "comboBoxKategorie";
            comboBoxKategorie.Size = new Size(185, 23);
            comboBoxKategorie.TabIndex = 31;
            comboBoxKategorie.TextChanged += ComboBoxKategorie_TextChanged;
            // 
            // listBoxOberflächeZustand
            // 
            listBoxOberflächeZustand.AccessibleName = "Oberfläche_Zustand";
            listBoxOberflächeZustand.FormattingEnabled = true;
            listBoxOberflächeZustand.ItemHeight = 15;
            listBoxOberflächeZustand.Location = new Point(744, 488);
            listBoxOberflächeZustand.Name = "listBoxOberflächeZustand";
            listBoxOberflächeZustand.SelectionMode = SelectionMode.MultiSimple;
            listBoxOberflächeZustand.Size = new Size(187, 79);
            listBoxOberflächeZustand.TabIndex = 25;
            listBoxOberflächeZustand.KeyDown += ListBoxOberflächeZustand_KeyDown;
            // 
            // listBoxOberflächeForm
            // 
            listBoxOberflächeForm.AccessibleName = "Oberfläche_Form";
            listBoxOberflächeForm.FormattingEnabled = true;
            listBoxOberflächeForm.ItemHeight = 15;
            listBoxOberflächeForm.Location = new Point(746, 385);
            listBoxOberflächeForm.Name = "listBoxOberflächeForm";
            listBoxOberflächeForm.SelectionMode = SelectionMode.MultiSimple;
            listBoxOberflächeForm.Size = new Size(185, 64);
            listBoxOberflächeForm.TabIndex = 26;
            listBoxOberflächeForm.KeyDown += ListBoxOberflächeForm_KeyDown;
            // 
            // listBoxOberflächeFarbe
            // 
            listBoxOberflächeFarbe.AccessibleName = "Oberfläche_Farbe";
            listBoxOberflächeFarbe.FormattingEnabled = true;
            listBoxOberflächeFarbe.ItemHeight = 15;
            listBoxOberflächeFarbe.Location = new Point(744, 283);
            listBoxOberflächeFarbe.Name = "listBoxOberflächeFarbe";
            listBoxOberflächeFarbe.SelectionMode = SelectionMode.MultiSimple;
            listBoxOberflächeFarbe.Size = new Size(188, 64);
            listBoxOberflächeFarbe.TabIndex = 27;
            listBoxOberflächeFarbe.KeyDown += ListBoxOberflächeFarbe_KeyDown;
            // 
            // listBoxOberflächeBeschaffenheit
            // 
            listBoxOberflächeBeschaffenheit.AccessibleName = "Oberfläche_Beschaffenheit";
            listBoxOberflächeBeschaffenheit.FormattingEnabled = true;
            listBoxOberflächeBeschaffenheit.ItemHeight = 15;
            listBoxOberflächeBeschaffenheit.Location = new Point(744, 182);
            listBoxOberflächeBeschaffenheit.Name = "listBoxOberflächeBeschaffenheit";
            listBoxOberflächeBeschaffenheit.SelectionMode = SelectionMode.MultiSimple;
            listBoxOberflächeBeschaffenheit.Size = new Size(187, 64);
            listBoxOberflächeBeschaffenheit.TabIndex = 28;
            listBoxOberflächeBeschaffenheit.KeyDown += ListBoxOberflächeBeschaffenheit_KeyDown;
            // 
            // listBoxOberfläche
            // 
            listBoxOberfläche.AccessibleName = "Oberfläche";
            listBoxOberfläche.FormattingEnabled = true;
            listBoxOberfläche.ItemHeight = 15;
            listBoxOberfläche.Location = new Point(745, 65);
            listBoxOberfläche.Name = "listBoxOberfläche";
            listBoxOberfläche.SelectionMode = SelectionMode.MultiSimple;
            listBoxOberfläche.Size = new Size(187, 79);
            listBoxOberfläche.TabIndex = 25;
            listBoxOberfläche.KeyDown += ListBoxOberfläche_KeyDown;
            // 
            // listBoxVeredelung
            // 
            listBoxVeredelung.AccessibleName = "Veredelung";
            listBoxVeredelung.FormattingEnabled = true;
            listBoxVeredelung.ItemHeight = 15;
            listBoxVeredelung.Location = new Point(443, 182);
            listBoxVeredelung.Name = "listBoxVeredelung";
            listBoxVeredelung.SelectionMode = SelectionMode.MultiSimple;
            listBoxVeredelung.Size = new Size(185, 64);
            listBoxVeredelung.TabIndex = 30;
            listBoxVeredelung.KeyDown += ListBoxVeredelung_KeyDown;
            // 
            // listBoxKlebstoff
            // 
            listBoxKlebstoff.AccessibleName = "Klebstoff";
            listBoxKlebstoff.FormattingEnabled = true;
            listBoxKlebstoff.ItemHeight = 15;
            listBoxKlebstoff.Location = new Point(443, 65);
            listBoxKlebstoff.Name = "listBoxKlebstoff";
            listBoxKlebstoff.SelectionMode = SelectionMode.MultiSimple;
            listBoxKlebstoff.Size = new Size(185, 79);
            listBoxKlebstoff.TabIndex = 29;
            listBoxKlebstoff.KeyDown += ListBoxKlebstoff_KeyDown;
            // 
            // listBoxKategorien
            // 
            listBoxKategorien.FormattingEnabled = true;
            listBoxKategorien.ItemHeight = 15;
            listBoxKategorien.Location = new Point(143, 488);
            listBoxKategorien.Name = "listBoxKategorien";
            listBoxKategorien.SelectionMode = SelectionMode.MultiSimple;
            listBoxKategorien.Size = new Size(185, 79);
            listBoxKategorien.TabIndex = 28;
            listBoxKategorien.KeyDown += ListBoxKategorien_KeyDown;
            // 
            // listBoxDruckverfahren
            // 
            listBoxDruckverfahren.AccessibleName = "Druckverfahren";
            listBoxDruckverfahren.FormattingEnabled = true;
            listBoxDruckverfahren.ItemHeight = 15;
            listBoxDruckverfahren.Location = new Point(143, 385);
            listBoxDruckverfahren.Name = "listBoxDruckverfahren";
            listBoxDruckverfahren.SelectionMode = SelectionMode.MultiSimple;
            listBoxDruckverfahren.Size = new Size(185, 64);
            listBoxDruckverfahren.TabIndex = 27;
            listBoxDruckverfahren.KeyDown += ListBoxDruckverfahren_KeyDown;
            // 
            // listBoxBesonderheiten
            // 
            listBoxBesonderheiten.AccessibleName = "Besonderheit";
            listBoxBesonderheiten.FormattingEnabled = true;
            listBoxBesonderheiten.ItemHeight = 15;
            listBoxBesonderheiten.Location = new Point(143, 283);
            listBoxBesonderheiten.Name = "listBoxBesonderheiten";
            listBoxBesonderheiten.SelectionMode = SelectionMode.MultiSimple;
            listBoxBesonderheiten.Size = new Size(185, 64);
            listBoxBesonderheiten.TabIndex = 26;
            listBoxBesonderheiten.KeyDown += ListBoxBesonderheiten_KeyDown;
            // 
            // listBoxBedingungen
            // 
            listBoxBedingungen.AccessibleName = "Bedingung";
            listBoxBedingungen.FormattingEnabled = true;
            listBoxBedingungen.ItemHeight = 15;
            listBoxBedingungen.Location = new Point(143, 182);
            listBoxBedingungen.Name = "listBoxBedingungen";
            listBoxBedingungen.SelectionMode = SelectionMode.MultiSimple;
            listBoxBedingungen.Size = new Size(185, 64);
            listBoxBedingungen.TabIndex = 25;
            listBoxBedingungen.KeyDown += ListBoxBedingungen_KeyDown;
            // 
            // listBoxÄußereEinflüsse
            // 
            listBoxÄußereEinflüsse.AccessibleName = "Äußerer_Einfluss";
            listBoxÄußereEinflüsse.FormattingEnabled = true;
            listBoxÄußereEinflüsse.ItemHeight = 15;
            listBoxÄußereEinflüsse.Location = new Point(143, 65);
            listBoxÄußereEinflüsse.Name = "listBoxÄußereEinflüsse";
            listBoxÄußereEinflüsse.SelectionMode = SelectionMode.MultiSimple;
            listBoxÄußereEinflüsse.Size = new Size(185, 79);
            listBoxÄußereEinflüsse.TabIndex = 25;
            listBoxÄußereEinflüsse.KeyDown += ListBoxÄußereEinflüsse_KeyDown;
            // 
            // labelOberfläche
            // 
            labelOberfläche.AutoSize = true;
            labelOberfläche.Location = new Point(654, 38);
            labelOberfläche.Name = "labelOberfläche";
            labelOberfläche.Size = new Size(65, 15);
            labelOberfläche.TabIndex = 6;
            labelOberfläche.Text = "Oberfläche";
            // 
            // labelKlebstoff
            // 
            labelKlebstoff.AutoSize = true;
            labelKlebstoff.Location = new Point(350, 38);
            labelKlebstoff.Name = "labelKlebstoff";
            labelKlebstoff.Size = new Size(54, 15);
            labelKlebstoff.TabIndex = 5;
            labelKlebstoff.Text = "Klebstoff";
            // 
            // labelKategorien
            // 
            labelKategorien.AutoSize = true;
            labelKategorien.Location = new Point(10, 461);
            labelKategorien.Name = "labelKategorien";
            labelKategorien.Size = new Size(64, 15);
            labelKategorien.TabIndex = 4;
            labelKategorien.Text = "Kategorien";
            // 
            // labelDruckverfahren
            // 
            labelDruckverfahren.AutoSize = true;
            labelDruckverfahren.Location = new Point(10, 358);
            labelDruckverfahren.Name = "labelDruckverfahren";
            labelDruckverfahren.Size = new Size(88, 15);
            labelDruckverfahren.TabIndex = 3;
            labelDruckverfahren.Text = "Druckverfahren";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 155);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 1;
            label2.Text = "Bedingungen \r\nEtikettierung";
            // 
            // labelÄußereEinflüsse
            // 
            labelÄußereEinflüsse.AutoSize = true;
            labelÄußereEinflüsse.Location = new Point(9, 38);
            labelÄußereEinflüsse.Name = "labelÄußereEinflüsse";
            labelÄußereEinflüsse.Size = new Size(94, 15);
            labelÄußereEinflüsse.TabIndex = 0;
            labelÄußereEinflüsse.Text = "Äußere Einflüsse";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxInformationen);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxEmpfehlungen);
            splitContainer1.Size = new Size(1019, 854);
            splitContainer1.SplitterDistance = 259;
            splitContainer1.TabIndex = 1;
            // 
            // groupBoxInformationen
            // 
            groupBoxInformationen.Controls.Add(labelInaktiv);
            groupBoxInformationen.Controls.Add(comboBoxArtikelnummer);
            groupBoxInformationen.Controls.Add(textBoxFarbe);
            groupBoxInformationen.Controls.Add(labelFarbe);
            groupBoxInformationen.Controls.Add(textBoxStatus);
            groupBoxInformationen.Controls.Add(labelStatus);
            groupBoxInformationen.Controls.Add(buttonMaterialübersichtSpeichern);
            groupBoxInformationen.Controls.Add(textBoxLieferzeit);
            groupBoxInformationen.Controls.Add(textBoxPreis);
            groupBoxInformationen.Controls.Add(textBoxBemerkung);
            groupBoxInformationen.Controls.Add(textBoxQualität);
            groupBoxInformationen.Controls.Add(textBoxBezeichnung);
            groupBoxInformationen.Controls.Add(labelLieferzeit);
            groupBoxInformationen.Controls.Add(labelBemerkung);
            groupBoxInformationen.Controls.Add(labelQualität);
            groupBoxInformationen.Controls.Add(labelPreis);
            groupBoxInformationen.Controls.Add(labelBezeichnung);
            groupBoxInformationen.Controls.Add(labelArtikelnummer);
            groupBoxInformationen.Dock = DockStyle.Fill;
            groupBoxInformationen.Location = new Point(0, 0);
            groupBoxInformationen.Name = "groupBoxInformationen";
            groupBoxInformationen.Size = new Size(1019, 259);
            groupBoxInformationen.TabIndex = 0;
            groupBoxInformationen.TabStop = false;
            groupBoxInformationen.Text = "Allgemeine Informationen";
            // 
            // comboBoxArtikelnummer
            // 
            comboBoxArtikelnummer.FormattingEnabled = true;
            comboBoxArtikelnummer.Location = new Point(132, 27);
            comboBoxArtikelnummer.Name = "comboBoxArtikelnummer";
            comboBoxArtikelnummer.Size = new Size(196, 23);
            comboBoxArtikelnummer.TabIndex = 30;
            comboBoxArtikelnummer.Leave += ComboBoxArtikelnummer_Leave;
            // 
            // textBoxFarbe
            // 
            textBoxFarbe.Location = new Point(478, 54);
            textBoxFarbe.Name = "textBoxFarbe";
            textBoxFarbe.ReadOnly = true;
            textBoxFarbe.Size = new Size(196, 23);
            textBoxFarbe.TabIndex = 28;
            // 
            // labelFarbe
            // 
            labelFarbe.AutoSize = true;
            labelFarbe.Location = new Point(359, 61);
            labelFarbe.Name = "labelFarbe";
            labelFarbe.Size = new Size(36, 15);
            labelFarbe.TabIndex = 27;
            labelFarbe.Text = "Farbe";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(132, 120);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(196, 23);
            textBoxStatus.TabIndex = 26;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(10, 120);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 25;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonMaterialübersichtSpeichern
            // 
            buttonMaterialübersichtSpeichern.BackColor = Color.DarkOrange;
            buttonMaterialübersichtSpeichern.FlatStyle = FlatStyle.Flat;
            buttonMaterialübersichtSpeichern.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMaterialübersichtSpeichern.ForeColor = SystemColors.Control;
            buttonMaterialübersichtSpeichern.Location = new Point(809, 170);
            buttonMaterialübersichtSpeichern.Name = "buttonMaterialübersichtSpeichern";
            buttonMaterialübersichtSpeichern.Size = new Size(105, 36);
            buttonMaterialübersichtSpeichern.TabIndex = 24;
            buttonMaterialübersichtSpeichern.Text = "Speichern";
            buttonMaterialübersichtSpeichern.UseVisualStyleBackColor = false;
            buttonMaterialübersichtSpeichern.Click += ButtonMaterialübersichtSpeichern_Click;
            // 
            // textBoxLieferzeit
            // 
            textBoxLieferzeit.Location = new Point(478, 118);
            textBoxLieferzeit.Name = "textBoxLieferzeit";
            textBoxLieferzeit.ReadOnly = true;
            textBoxLieferzeit.Size = new Size(196, 23);
            textBoxLieferzeit.TabIndex = 23;
            // 
            // textBoxPreis
            // 
            textBoxPreis.Location = new Point(478, 89);
            textBoxPreis.Name = "textBoxPreis";
            textBoxPreis.ReadOnly = true;
            textBoxPreis.Size = new Size(196, 23);
            textBoxPreis.TabIndex = 22;
            // 
            // textBoxBemerkung
            // 
            textBoxBemerkung.Location = new Point(132, 155);
            textBoxBemerkung.Multiline = true;
            textBoxBemerkung.Name = "textBoxBemerkung";
            textBoxBemerkung.Size = new Size(196, 51);
            textBoxBemerkung.TabIndex = 21;
            textBoxBemerkung.Leave += TextBoxBemerkung_Leave;
            // 
            // textBoxQualität
            // 
            textBoxQualität.Location = new Point(132, 88);
            textBoxQualität.Name = "textBoxQualität";
            textBoxQualität.ReadOnly = true;
            textBoxQualität.Size = new Size(196, 23);
            textBoxQualität.TabIndex = 20;
            // 
            // textBoxBezeichnung
            // 
            textBoxBezeichnung.Location = new Point(132, 59);
            textBoxBezeichnung.Multiline = true;
            textBoxBezeichnung.Name = "textBoxBezeichnung";
            textBoxBezeichnung.ReadOnly = true;
            textBoxBezeichnung.Size = new Size(196, 23);
            textBoxBezeichnung.TabIndex = 19;
            // 
            // labelLieferzeit
            // 
            labelLieferzeit.AutoSize = true;
            labelLieferzeit.Location = new Point(359, 124);
            labelLieferzeit.Name = "labelLieferzeit";
            labelLieferzeit.Size = new Size(101, 15);
            labelLieferzeit.TabIndex = 17;
            labelLieferzeit.Text = "Lieferzeit in Tagen";
            // 
            // labelBemerkung
            // 
            labelBemerkung.AutoSize = true;
            labelBemerkung.Location = new Point(10, 158);
            labelBemerkung.Name = "labelBemerkung";
            labelBemerkung.Size = new Size(68, 15);
            labelBemerkung.TabIndex = 16;
            labelBemerkung.Text = "Bemerkung";
            // 
            // labelQualität
            // 
            labelQualität.AutoSize = true;
            labelQualität.Location = new Point(10, 89);
            labelQualität.Name = "labelQualität";
            labelQualität.Size = new Size(49, 15);
            labelQualität.TabIndex = 15;
            labelQualität.Text = "Qualität";
            // 
            // labelPreis
            // 
            labelPreis.AutoSize = true;
            labelPreis.Location = new Point(359, 96);
            labelPreis.Name = "labelPreis";
            labelPreis.Size = new Size(54, 15);
            labelPreis.TabIndex = 14;
            labelPreis.Text = "Preis in €";
            // 
            // labelBezeichnung
            // 
            labelBezeichnung.AutoSize = true;
            labelBezeichnung.Location = new Point(8, 62);
            labelBezeichnung.Name = "labelBezeichnung";
            labelBezeichnung.Size = new Size(75, 15);
            labelBezeichnung.TabIndex = 13;
            labelBezeichnung.Text = "Bezeichnung";
            // 
            // labelArtikelnummer
            // 
            labelArtikelnummer.AutoSize = true;
            labelArtikelnummer.Location = new Point(8, 30);
            labelArtikelnummer.Name = "labelArtikelnummer";
            labelArtikelnummer.Size = new Size(87, 15);
            labelArtikelnummer.TabIndex = 12;
            labelArtikelnummer.Text = "Artikelnummer";
            // 
            // errorProviderMaterialübersicht
            // 
            errorProviderMaterialübersicht.ContainerControl = this;
            // 
            // labelInaktiv
            // 
            labelInaktiv.AutoSize = true;
            labelInaktiv.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelInaktiv.Location = new Point(359, 27);
            labelInaktiv.Name = "labelInaktiv";
            labelInaktiv.Size = new Size(358, 16);
            labelInaktiv.TabIndex = 31;
            labelInaktiv.Text = "Material ist inaktiv und kann nicht verändert werden";
            // 
            // Materialübersicht
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "Materialübersicht";
            Size = new Size(1019, 854);
            groupBoxEmpfehlungen.ResumeLayout(false);
            groupBoxEmpfehlungen.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxInformationen.ResumeLayout(false);
            groupBoxInformationen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderMaterialübersicht).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label12;
        private Label labelOberfläche_Zustand;
        private Label labelOberfläche_Form;
        private Label label9;
        private Label labelOberfläche_Beschaffenheit;
        private GroupBox groupBoxEmpfehlungen;
        private Label labelOberfläche;
        private Label labelKlebstoff;
        private Label labelKategorien;
        private Label labelDruckverfahren;
        private Label label2;
        private Label labelÄußereEinflüsse;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxInformationen;
        private TextBox textBoxLieferzeit;
        private TextBox textBoxPreis;
        private TextBox textBoxBemerkung;
        private TextBox textBoxQualität;
        private TextBox textBoxBezeichnung;
        private Label labelLieferzeit;
        private Label labelBemerkung;
        private Label labelQualität;
        private Label labelPreis;
        private Label labelBezeichnung;
        private Label labelArtikelnummer;
        private ErrorProvider errorProviderMaterialübersicht;
        private Button buttonMaterialübersichtSpeichern;
        private ListBox listBoxÄußereEinflüsse;
        private ListBox listBoxBedingungen;
        private ListBox listBoxBesonderheiten;
        private ListBox listBoxDruckverfahren;
        private ListBox listBoxKategorien;
        private ListBox listBoxKlebstoff;
        private ListBox listBoxVeredelung;
        private ListBox listBoxOberfläche;
        private ListBox listBoxOberflächeBeschaffenheit;
        private ListBox listBoxOberflächeFarbe;
        private ListBox listBoxOberflächeForm;
        private ListBox listBoxOberflächeZustand;
        private TextBox textBoxStatus;
        private Label labelStatus;
        private TextBox textBoxFarbe;
        private Label labelFarbe;
        private ComboBox comboBoxArtikelnummer;
        private ComboBox comboBoxDruckverfahren;
        private ComboBox comboBoxKategorie;
        private ComboBox comboBoxKlebstoff;
        private ComboBox comboBoxÄußerer_Einfluss;
        private ComboBox comboBoxBedingung;
        private ComboBox comboBoxBesonderheit;
        private ComboBox comboBoxOberfläche_Form;
        private ComboBox comboBoxOberfläche_Farbe;
        private ComboBox comboBoxOberfläche_Beschaffenheit;
        private ComboBox comboBoxOberfläche;
        private ComboBox comboBoxVeredelung;
        private ComboBox comboBoxOberfläche_Zustand;
        private Label labelInaktiv;
    }
}
