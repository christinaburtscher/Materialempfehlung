namespace Materialempfehlung.UserControls
{
    partial class MaterialSuche
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
            groupBoxÜbersicht = new GroupBox();
            splitContainer1 = new SplitContainer();
            groupBoxInhalte = new GroupBox();
            dataGridViewSuchkriterien = new DataGridView();
            bereichDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inhaltDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empfehlungBindingSource = new BindingSource(components);
            buttonSuche = new Button();
            labelOberfläche_Zustand = new Label();
            comboBoxBedingungen = new ComboBox();
            comboBoxBesonderheit = new ComboBox();
            comboBoxDruckverfahren = new ComboBox();
            comboBoxKategorien = new ComboBox();
            comboBoxKlebstoff = new ComboBox();
            comboBoxVeredelung = new ComboBox();
            comboBoxOberfläche = new ComboBox();
            comboBoxOberfläche_Beschaffenheit = new ComboBox();
            comboBoxOberfläche_Farbe = new ComboBox();
            comboBoxOberfläche_Form = new ComboBox();
            comboBoxOberfläche_Zustand = new ComboBox();
            comboBoxÄußererEinfluss = new ComboBox();
            labelKlebstoff = new Label();
            labelBedingungen = new Label();
            labelOberfläche = new Label();
            labelVeredelung = new Label();
            labelOberfläche_Form = new Label();
            labelOberfläche_Farbe = new Label();
            labelBesonderheit = new Label();
            Kategorien = new Label();
            labelOberfläche_Beschaffenheit = new Label();
            labelDruckverfahren = new Label();
            labelÄußererEinfluss = new Label();
            groupBoxVerfügbareMaterialien = new GroupBox();
            dataGridViewMaterialübersicht = new DataGridView();
            artikelnummerBezeichnungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bezeichnungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qualitätDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bemerkungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lieferzeitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialBindingSource = new BindingSource(components);
            material2EmpfehlungBindingSource = new BindingSource(components);
            groupBoxÜbersicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxInhalte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuchkriterien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empfehlungBindingSource).BeginInit();
            groupBoxVerfügbareMaterialien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterialübersicht).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)material2EmpfehlungBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBoxÜbersicht
            // 
            groupBoxÜbersicht.Controls.Add(splitContainer1);
            groupBoxÜbersicht.Dock = DockStyle.Fill;
            groupBoxÜbersicht.Location = new Point(0, 0);
            groupBoxÜbersicht.Name = "groupBoxÜbersicht";
            groupBoxÜbersicht.Size = new Size(1057, 671);
            groupBoxÜbersicht.TabIndex = 0;
            groupBoxÜbersicht.TabStop = false;
            groupBoxÜbersicht.Text = "Übersicht";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxInhalte);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxVerfügbareMaterialien);
            splitContainer1.Size = new Size(1051, 649);
            splitContainer1.SplitterDistance = 397;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxInhalte
            // 
            groupBoxInhalte.Controls.Add(dataGridViewSuchkriterien);
            groupBoxInhalte.Controls.Add(buttonSuche);
            groupBoxInhalte.Controls.Add(labelOberfläche_Zustand);
            groupBoxInhalte.Controls.Add(comboBoxBedingungen);
            groupBoxInhalte.Controls.Add(comboBoxBesonderheit);
            groupBoxInhalte.Controls.Add(comboBoxDruckverfahren);
            groupBoxInhalte.Controls.Add(comboBoxKategorien);
            groupBoxInhalte.Controls.Add(comboBoxKlebstoff);
            groupBoxInhalte.Controls.Add(comboBoxVeredelung);
            groupBoxInhalte.Controls.Add(comboBoxOberfläche);
            groupBoxInhalte.Controls.Add(comboBoxOberfläche_Beschaffenheit);
            groupBoxInhalte.Controls.Add(comboBoxOberfläche_Farbe);
            groupBoxInhalte.Controls.Add(comboBoxOberfläche_Form);
            groupBoxInhalte.Controls.Add(comboBoxOberfläche_Zustand);
            groupBoxInhalte.Controls.Add(comboBoxÄußererEinfluss);
            groupBoxInhalte.Controls.Add(labelKlebstoff);
            groupBoxInhalte.Controls.Add(labelBedingungen);
            groupBoxInhalte.Controls.Add(labelOberfläche);
            groupBoxInhalte.Controls.Add(labelVeredelung);
            groupBoxInhalte.Controls.Add(labelOberfläche_Form);
            groupBoxInhalte.Controls.Add(labelOberfläche_Farbe);
            groupBoxInhalte.Controls.Add(labelBesonderheit);
            groupBoxInhalte.Controls.Add(Kategorien);
            groupBoxInhalte.Controls.Add(labelOberfläche_Beschaffenheit);
            groupBoxInhalte.Controls.Add(labelDruckverfahren);
            groupBoxInhalte.Controls.Add(labelÄußererEinfluss);
            groupBoxInhalte.Dock = DockStyle.Fill;
            groupBoxInhalte.Location = new Point(0, 0);
            groupBoxInhalte.Name = "groupBoxInhalte";
            groupBoxInhalte.Size = new Size(397, 649);
            groupBoxInhalte.TabIndex = 0;
            groupBoxInhalte.TabStop = false;
            groupBoxInhalte.Text = "Inhalte";
            // 
            // dataGridViewSuchkriterien
            // 
            dataGridViewSuchkriterien.AllowUserToAddRows = false;
            dataGridViewSuchkriterien.AllowUserToDeleteRows = false;
            dataGridViewSuchkriterien.AutoGenerateColumns = false;
            dataGridViewSuchkriterien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuchkriterien.Columns.AddRange(new DataGridViewColumn[] { bereichDataGridViewTextBoxColumn, inhaltDataGridViewTextBoxColumn });
            dataGridViewSuchkriterien.DataSource = empfehlungBindingSource;
            dataGridViewSuchkriterien.Enabled = false;
            dataGridViewSuchkriterien.Location = new Point(11, 22);
            dataGridViewSuchkriterien.Name = "dataGridViewSuchkriterien";
            dataGridViewSuchkriterien.ReadOnly = true;
            dataGridViewSuchkriterien.RowTemplate.Height = 25;
            dataGridViewSuchkriterien.Size = new Size(295, 109);
            dataGridViewSuchkriterien.TabIndex = 26;
            // 
            // bereichDataGridViewTextBoxColumn
            // 
            bereichDataGridViewTextBoxColumn.DataPropertyName = "Bereich";
            bereichDataGridViewTextBoxColumn.HeaderText = "Bereich";
            bereichDataGridViewTextBoxColumn.Name = "bereichDataGridViewTextBoxColumn";
            bereichDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inhaltDataGridViewTextBoxColumn
            // 
            inhaltDataGridViewTextBoxColumn.DataPropertyName = "Inhalt";
            inhaltDataGridViewTextBoxColumn.HeaderText = "Inhalt";
            inhaltDataGridViewTextBoxColumn.Name = "inhaltDataGridViewTextBoxColumn";
            inhaltDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empfehlungBindingSource
            // 
            empfehlungBindingSource.DataSource = typeof(Models.Empfehlung);
            // 
            // buttonSuche
            // 
            buttonSuche.BackColor = Color.DarkOrange;
            buttonSuche.BackgroundImageLayout = ImageLayout.None;
            buttonSuche.FlatStyle = FlatStyle.Flat;
            buttonSuche.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSuche.ForeColor = SystemColors.Control;
            buttonSuche.Location = new Point(324, 22);
            buttonSuche.Name = "buttonSuche";
            buttonSuche.Size = new Size(94, 32);
            buttonSuche.TabIndex = 25;
            buttonSuche.Text = "Suche";
            buttonSuche.UseVisualStyleBackColor = false;
            buttonSuche.Click += ButtonSuche_Click;
            // 
            // labelOberfläche_Zustand
            // 
            labelOberfläche_Zustand.AutoSize = true;
            labelOberfläche_Zustand.Location = new Point(11, 587);
            labelOberfläche_Zustand.Name = "labelOberfläche_Zustand";
            labelOberfläche_Zustand.Size = new Size(65, 30);
            labelOberfläche_Zustand.TabIndex = 24;
            labelOberfläche_Zustand.Text = "Oberfläche\r\nZustand";
            // 
            // comboBoxBedingungen
            // 
            comboBoxBedingungen.AccessibleName = "Bedingung";
            comboBoxBedingungen.FormattingEnabled = true;
            comboBoxBedingungen.Location = new Point(155, 189);
            comboBoxBedingungen.Name = "comboBoxBedingungen";
            comboBoxBedingungen.Size = new Size(151, 23);
            comboBoxBedingungen.TabIndex = 23;
            comboBoxBedingungen.TextChanged += ComboBoxBedingungen_TextChanged;
            // 
            // comboBoxBesonderheit
            // 
            comboBoxBesonderheit.AccessibleName = "Besonderheit";
            comboBoxBesonderheit.FormattingEnabled = true;
            comboBoxBesonderheit.Location = new Point(155, 231);
            comboBoxBesonderheit.Name = "comboBoxBesonderheit";
            comboBoxBesonderheit.Size = new Size(151, 23);
            comboBoxBesonderheit.TabIndex = 22;
            comboBoxBesonderheit.TextChanged += ComboBoxBesonderheit_TextChanged;
            // 
            // comboBoxDruckverfahren
            // 
            comboBoxDruckverfahren.AccessibleName = "Druckverfahren";
            comboBoxDruckverfahren.FormattingEnabled = true;
            comboBoxDruckverfahren.Location = new Point(155, 270);
            comboBoxDruckverfahren.Name = "comboBoxDruckverfahren";
            comboBoxDruckverfahren.Size = new Size(151, 23);
            comboBoxDruckverfahren.TabIndex = 21;
            comboBoxDruckverfahren.TextChanged += ComboBoxDruckverfahren_TextChanged;
            // 
            // comboBoxKategorien
            // 
            comboBoxKategorien.AccessibleName = "Kategorie";
            comboBoxKategorien.FormattingEnabled = true;
            comboBoxKategorien.Location = new Point(155, 309);
            comboBoxKategorien.Name = "comboBoxKategorien";
            comboBoxKategorien.Size = new Size(151, 23);
            comboBoxKategorien.TabIndex = 20;
            comboBoxKategorien.TextChanged += ComboBoxKategorien_TextChanged;
            // 
            // comboBoxKlebstoff
            // 
            comboBoxKlebstoff.AccessibleName = "Klebstoff";
            comboBoxKlebstoff.FormattingEnabled = true;
            comboBoxKlebstoff.Location = new Point(155, 345);
            comboBoxKlebstoff.Name = "comboBoxKlebstoff";
            comboBoxKlebstoff.Size = new Size(151, 23);
            comboBoxKlebstoff.TabIndex = 19;
            comboBoxKlebstoff.TextChanged += ComboBoxKlebstoff_TextChanged;
            // 
            // comboBoxVeredelung
            // 
            comboBoxVeredelung.AccessibleName = "Veredelung";
            comboBoxVeredelung.FormattingEnabled = true;
            comboBoxVeredelung.Location = new Point(152, 385);
            comboBoxVeredelung.Name = "comboBoxVeredelung";
            comboBoxVeredelung.Size = new Size(154, 23);
            comboBoxVeredelung.TabIndex = 18;
            comboBoxVeredelung.TextChanged += ComboBoxVeredelung_TextChanged;
            // 
            // comboBoxOberfläche
            // 
            comboBoxOberfläche.AccessibleName = "Oberfläche";
            comboBoxOberfläche.FormattingEnabled = true;
            comboBoxOberfläche.Location = new Point(152, 422);
            comboBoxOberfläche.Name = "comboBoxOberfläche";
            comboBoxOberfläche.Size = new Size(154, 23);
            comboBoxOberfläche.TabIndex = 17;
            comboBoxOberfläche.TextChanged += ComboBoxOberfläche_TextChanged;
            // 
            // comboBoxOberfläche_Beschaffenheit
            // 
            comboBoxOberfläche_Beschaffenheit.AccessibleName = "Oberfläche_Beschaffenheit";
            comboBoxOberfläche_Beschaffenheit.FormattingEnabled = true;
            comboBoxOberfläche_Beschaffenheit.Location = new Point(152, 466);
            comboBoxOberfläche_Beschaffenheit.Name = "comboBoxOberfläche_Beschaffenheit";
            comboBoxOberfläche_Beschaffenheit.Size = new Size(154, 23);
            comboBoxOberfläche_Beschaffenheit.TabIndex = 16;
            comboBoxOberfläche_Beschaffenheit.TextChanged += ComboBoxOberfläche_Beschaffenheit_TextChanged;
            // 
            // comboBoxOberfläche_Farbe
            // 
            comboBoxOberfläche_Farbe.AccessibleName = "Oberfläche_Farbe";
            comboBoxOberfläche_Farbe.FormattingEnabled = true;
            comboBoxOberfläche_Farbe.Location = new Point(152, 509);
            comboBoxOberfläche_Farbe.Name = "comboBoxOberfläche_Farbe";
            comboBoxOberfläche_Farbe.Size = new Size(154, 23);
            comboBoxOberfläche_Farbe.TabIndex = 15;
            comboBoxOberfläche_Farbe.TextChanged += ComboBoxOberfläche_Farbe_TextChanged;
            // 
            // comboBoxOberfläche_Form
            // 
            comboBoxOberfläche_Form.AccessibleName = "Oberfläche_Form";
            comboBoxOberfläche_Form.FormattingEnabled = true;
            comboBoxOberfläche_Form.Location = new Point(152, 551);
            comboBoxOberfläche_Form.Name = "comboBoxOberfläche_Form";
            comboBoxOberfläche_Form.Size = new Size(154, 23);
            comboBoxOberfläche_Form.TabIndex = 14;
            comboBoxOberfläche_Form.TextChanged += ComboBoxOberfläche_Form_TextChanged;
            // 
            // comboBoxOberfläche_Zustand
            // 
            comboBoxOberfläche_Zustand.AccessibleName = "Oberfläche_Zustand";
            comboBoxOberfläche_Zustand.FormattingEnabled = true;
            comboBoxOberfläche_Zustand.Location = new Point(152, 594);
            comboBoxOberfläche_Zustand.Name = "comboBoxOberfläche_Zustand";
            comboBoxOberfläche_Zustand.Size = new Size(154, 23);
            comboBoxOberfläche_Zustand.TabIndex = 13;
            comboBoxOberfläche_Zustand.TextChanged += ComboBoxOberfläche_Zustand_TextChanged;
            // 
            // comboBoxÄußererEinfluss
            // 
            comboBoxÄußererEinfluss.AccessibleName = "Äußerer_Einfluss";
            comboBoxÄußererEinfluss.FormattingEnabled = true;
            comboBoxÄußererEinfluss.Location = new Point(157, 142);
            comboBoxÄußererEinfluss.Name = "comboBoxÄußererEinfluss";
            comboBoxÄußererEinfluss.Size = new Size(149, 23);
            comboBoxÄußererEinfluss.TabIndex = 12;
            comboBoxÄußererEinfluss.TextChanged += ComboBoxÄußererEinfluss_TextChanged;
            // 
            // labelKlebstoff
            // 
            labelKlebstoff.AccessibleName = "Klebstoff";
            labelKlebstoff.AutoSize = true;
            labelKlebstoff.Location = new Point(11, 353);
            labelKlebstoff.Name = "labelKlebstoff";
            labelKlebstoff.Size = new Size(54, 15);
            labelKlebstoff.TabIndex = 11;
            labelKlebstoff.Text = "Klebstoff";
            // 
            // labelBedingungen
            // 
            labelBedingungen.AutoSize = true;
            labelBedingungen.Location = new Point(11, 182);
            labelBedingungen.Name = "labelBedingungen";
            labelBedingungen.Size = new Size(81, 30);
            labelBedingungen.TabIndex = 10;
            labelBedingungen.Text = "Bedingungen \r\nEtikettierung\r\n";
            // 
            // labelOberfläche
            // 
            labelOberfläche.AutoSize = true;
            labelOberfläche.Location = new Point(11, 430);
            labelOberfläche.Name = "labelOberfläche";
            labelOberfläche.Size = new Size(65, 15);
            labelOberfläche.TabIndex = 9;
            labelOberfläche.Text = "Oberfläche";
            // 
            // labelVeredelung
            // 
            labelVeredelung.AutoSize = true;
            labelVeredelung.Location = new Point(11, 393);
            labelVeredelung.Name = "labelVeredelung";
            labelVeredelung.Size = new Size(66, 15);
            labelVeredelung.TabIndex = 8;
            labelVeredelung.Text = "Veredelung";
            // 
            // labelOberfläche_Form
            // 
            labelOberfläche_Form.AutoSize = true;
            labelOberfläche_Form.Location = new Point(11, 544);
            labelOberfläche_Form.Name = "labelOberfläche_Form";
            labelOberfläche_Form.Size = new Size(65, 30);
            labelOberfläche_Form.TabIndex = 6;
            labelOberfläche_Form.Text = "Oberfläche\r\nForm\r\n";
            // 
            // labelOberfläche_Farbe
            // 
            labelOberfläche_Farbe.AutoSize = true;
            labelOberfläche_Farbe.Location = new Point(11, 502);
            labelOberfläche_Farbe.Name = "labelOberfläche_Farbe";
            labelOberfläche_Farbe.Size = new Size(68, 30);
            labelOberfläche_Farbe.TabIndex = 5;
            labelOberfläche_Farbe.Text = "Oberfläche \r\nFarbe";
            // 
            // labelBesonderheit
            // 
            labelBesonderheit.AutoSize = true;
            labelBesonderheit.Location = new Point(11, 239);
            labelBesonderheit.Name = "labelBesonderheit";
            labelBesonderheit.Size = new Size(89, 15);
            labelBesonderheit.TabIndex = 4;
            labelBesonderheit.Text = "Besonderheiten";
            // 
            // Kategorien
            // 
            Kategorien.AutoSize = true;
            Kategorien.Location = new Point(11, 317);
            Kategorien.Name = "Kategorien";
            Kategorien.Size = new Size(64, 15);
            Kategorien.TabIndex = 3;
            Kategorien.Text = "Kategorien";
            // 
            // labelOberfläche_Beschaffenheit
            // 
            labelOberfläche_Beschaffenheit.AutoSize = true;
            labelOberfläche_Beschaffenheit.Location = new Point(11, 459);
            labelOberfläche_Beschaffenheit.Name = "labelOberfläche_Beschaffenheit";
            labelOberfläche_Beschaffenheit.Size = new Size(85, 30);
            labelOberfläche_Beschaffenheit.TabIndex = 2;
            labelOberfläche_Beschaffenheit.Text = "Oberfläche\r\nBeschaffenheit";
            // 
            // labelDruckverfahren
            // 
            labelDruckverfahren.AutoSize = true;
            labelDruckverfahren.Location = new Point(11, 278);
            labelDruckverfahren.Name = "labelDruckverfahren";
            labelDruckverfahren.Size = new Size(88, 15);
            labelDruckverfahren.TabIndex = 1;
            labelDruckverfahren.Text = "Druckverfahren";
            // 
            // labelÄußererEinfluss
            // 
            labelÄußererEinfluss.AutoSize = true;
            labelÄußererEinfluss.Location = new Point(11, 150);
            labelÄußererEinfluss.Name = "labelÄußererEinfluss";
            labelÄußererEinfluss.Size = new Size(94, 15);
            labelÄußererEinfluss.TabIndex = 0;
            labelÄußererEinfluss.Text = "Äußere Einflüsse";
            // 
            // groupBoxVerfügbareMaterialien
            // 
            groupBoxVerfügbareMaterialien.Controls.Add(dataGridViewMaterialübersicht);
            groupBoxVerfügbareMaterialien.Dock = DockStyle.Fill;
            groupBoxVerfügbareMaterialien.Location = new Point(0, 0);
            groupBoxVerfügbareMaterialien.Name = "groupBoxVerfügbareMaterialien";
            groupBoxVerfügbareMaterialien.Size = new Size(650, 649);
            groupBoxVerfügbareMaterialien.TabIndex = 0;
            groupBoxVerfügbareMaterialien.TabStop = false;
            groupBoxVerfügbareMaterialien.Text = "verfügbare Materialien";
            // 
            // dataGridViewMaterialübersicht
            // 
            dataGridViewMaterialübersicht.AllowUserToAddRows = false;
            dataGridViewMaterialübersicht.AllowUserToDeleteRows = false;
            dataGridViewMaterialübersicht.AutoGenerateColumns = false;
            dataGridViewMaterialübersicht.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterialübersicht.Columns.AddRange(new DataGridViewColumn[] { artikelnummerBezeichnungDataGridViewTextBoxColumn, bezeichnungDataGridViewTextBoxColumn, qualitätDataGridViewTextBoxColumn, bemerkungDataGridViewTextBoxColumn, preisDataGridViewTextBoxColumn, lieferzeitDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridViewMaterialübersicht.DataSource = materialBindingSource;
            dataGridViewMaterialübersicht.Dock = DockStyle.Fill;
            dataGridViewMaterialübersicht.Location = new Point(3, 19);
            dataGridViewMaterialübersicht.Name = "dataGridViewMaterialübersicht";
            dataGridViewMaterialübersicht.ReadOnly = true;
            dataGridViewMaterialübersicht.RowTemplate.Height = 25;
            dataGridViewMaterialübersicht.Size = new Size(644, 627);
            dataGridViewMaterialübersicht.TabIndex = 0;
            // 
            // artikelnummerBezeichnungDataGridViewTextBoxColumn
            // 
            artikelnummerBezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Artikelnummer_Bezeichnung";
            artikelnummerBezeichnungDataGridViewTextBoxColumn.HeaderText = "Artikelnummer_Bezeichnung";
            artikelnummerBezeichnungDataGridViewTextBoxColumn.Name = "artikelnummerBezeichnungDataGridViewTextBoxColumn";
            artikelnummerBezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualitätDataGridViewTextBoxColumn
            // 
            qualitätDataGridViewTextBoxColumn.DataPropertyName = "Qualität";
            qualitätDataGridViewTextBoxColumn.HeaderText = "Qualität";
            qualitätDataGridViewTextBoxColumn.Name = "qualitätDataGridViewTextBoxColumn";
            qualitätDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bemerkungDataGridViewTextBoxColumn
            // 
            bemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung";
            bemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung";
            bemerkungDataGridViewTextBoxColumn.Name = "bemerkungDataGridViewTextBoxColumn";
            bemerkungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preisDataGridViewTextBoxColumn
            // 
            preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            preisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lieferzeitDataGridViewTextBoxColumn
            // 
            lieferzeitDataGridViewTextBoxColumn.DataPropertyName = "Lieferzeit";
            lieferzeitDataGridViewTextBoxColumn.HeaderText = "Lieferzeit";
            lieferzeitDataGridViewTextBoxColumn.Name = "lieferzeitDataGridViewTextBoxColumn";
            lieferzeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(Models.Material);
            // 
            // material2EmpfehlungBindingSource
            // 
            material2EmpfehlungBindingSource.DataSource = typeof(Models.Material2Empfehlung);
            // 
            // MaterialSuche
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxÜbersicht);
            Name = "MaterialSuche";
            Size = new Size(1057, 671);
            groupBoxÜbersicht.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxInhalte.ResumeLayout(false);
            groupBoxInhalte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuchkriterien).EndInit();
            ((System.ComponentModel.ISupportInitialize)empfehlungBindingSource).EndInit();
            groupBoxVerfügbareMaterialien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterialübersicht).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)material2EmpfehlungBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxÜbersicht;
        private BindingSource material2EmpfehlungBindingSource;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxInhalte;
        private Button buttonSuche;
        private Label labelOberfläche_Zustand;
        private ComboBox comboBoxBedingungen;
        private ComboBox comboBoxBesonderheit;
        private ComboBox comboBoxDruckverfahren;
        private ComboBox comboBoxKategorien;
        private ComboBox comboBoxKlebstoff;
        private ComboBox comboBoxVeredelung;
        private ComboBox comboBoxOberfläche;
        private ComboBox comboBoxOberfläche_Beschaffenheit;
        private ComboBox comboBoxOberfläche_Farbe;
        private ComboBox comboBoxOberfläche_Form;
        private ComboBox comboBoxOberfläche_Zustand;
        private ComboBox comboBoxÄußererEinfluss;
        private Label labelKlebstoff;
        private Label labelBedingungen;
        private Label labelOberfläche;
        private Label labelVeredelung;
        private Label labelOberfläche_Form;
        private Label labelOberfläche_Farbe;
        private Label labelBesonderheit;
        private Label Kategorien;
        private Label labelOberfläche_Beschaffenheit;
        private Label labelDruckverfahren;
        private Label labelÄußererEinfluss;
        private GroupBox groupBoxVerfügbareMaterialien;
        private DataGridView dataGridViewSuchkriterien;
        private BindingSource empfehlungBindingSource;
        private DataGridView dataGridViewMaterialübersicht;
        private DataGridViewTextBoxColumn artikelnummerBezeichnungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qualitätDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bemerkungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lieferzeitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource materialBindingSource;
        private DataGridViewTextBoxColumn bereichDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inhaltDataGridViewTextBoxColumn;
    }
}
