namespace Materialempfehlung
{
    partial class Monitor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            groupBoxSuche = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            comboBoxBereiche = new ComboBox();
            buttonSuche = new Button();
            labelArtikelnummer = new Label();
            textBoxMaterialSuche = new TextBox();
            groupBoxÜbersicht = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxSuche.SuspendLayout();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(groupBoxSuche);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxÜbersicht);
            splitContainer1.Size = new Size(983, 611);
            splitContainer1.SplitterDistance = 85;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxSuche
            // 
            groupBoxSuche.Controls.Add(button1);
            groupBoxSuche.Controls.Add(label1);
            groupBoxSuche.Controls.Add(comboBoxBereiche);
            groupBoxSuche.Controls.Add(buttonSuche);
            groupBoxSuche.Controls.Add(labelArtikelnummer);
            groupBoxSuche.Controls.Add(textBoxMaterialSuche);
            groupBoxSuche.Dock = DockStyle.Fill;
            groupBoxSuche.Location = new Point(0, 0);
            groupBoxSuche.Name = "groupBoxSuche";
            groupBoxSuche.Size = new Size(983, 85);
            groupBoxSuche.TabIndex = 0;
            groupBoxSuche.TabStop = false;
            groupBoxSuche.Text = "Suche";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.IBeam;
            button1.FlatAppearance.BorderColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(609, 9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(99, 51);
            button1.TabIndex = 6;
            button1.Text = "Bereiche Suche";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(378, 30);
            label1.Name = "label1";
            label1.Size = new Size(69, 16);
            label1.TabIndex = 5;
            label1.Text = "Bereiche";
            // 
            // comboBoxBereiche
            // 
            comboBoxBereiche.FormattingEnabled = true;
            comboBoxBereiche.Location = new Point(453, 23);
            comboBoxBereiche.Name = "comboBoxBereiche";
            comboBoxBereiche.Size = new Size(121, 23);
            comboBoxBereiche.TabIndex = 3;
            // 
            // buttonSuche
            // 
            buttonSuche.BackColor = Color.DarkOrange;
            buttonSuche.BackgroundImageLayout = ImageLayout.None;
            buttonSuche.Cursor = Cursors.IBeam;
            buttonSuche.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonSuche.FlatAppearance.BorderSize = 0;
            buttonSuche.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSuche.ForeColor = SystemColors.Window;
            buttonSuche.Location = new Point(233, 9);
            buttonSuche.Margin = new Padding(0);
            buttonSuche.Name = "buttonSuche";
            buttonSuche.RightToLeft = RightToLeft.Yes;
            buttonSuche.Size = new Size(127, 51);
            buttonSuche.TabIndex = 2;
            buttonSuche.Text = "Artikelnummer Suche";
            buttonSuche.TextAlign = ContentAlignment.BottomCenter;
            buttonSuche.UseVisualStyleBackColor = false;
            buttonSuche.Click += ButtonSuche_Click;
            // 
            // labelArtikelnummer
            // 
            labelArtikelnummer.AutoSize = true;
            labelArtikelnummer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelArtikelnummer.Location = new Point(3, 30);
            labelArtikelnummer.Name = "labelArtikelnummer";
            labelArtikelnummer.Size = new Size(105, 16);
            labelArtikelnummer.TabIndex = 1;
            labelArtikelnummer.Text = "Artikelnummer";
            // 
            // textBoxMaterialSuche
            // 
            textBoxMaterialSuche.Location = new Point(114, 22);
            textBoxMaterialSuche.Name = "textBoxMaterialSuche";
            textBoxMaterialSuche.Size = new Size(100, 23);
            textBoxMaterialSuche.TabIndex = 0;
            // 
            // groupBoxÜbersicht
            // 
            groupBoxÜbersicht.Dock = DockStyle.Fill;
            groupBoxÜbersicht.Location = new Point(0, 0);
            groupBoxÜbersicht.Name = "groupBoxÜbersicht";
            groupBoxÜbersicht.Size = new Size(983, 522);
            groupBoxÜbersicht.TabIndex = 0;
            groupBoxÜbersicht.TabStop = false;
            groupBoxÜbersicht.Text = "Übersicht";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 611);
            Controls.Add(splitContainer1);
            Name = "Form";
            Text = "Materialempfehlung";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxSuche.ResumeLayout(false);
            groupBoxSuche.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBoxSuche;
        private GroupBox groupBoxÜbersicht;
        private Button button1;
        private Label label1;
        private ComboBox comboBoxBereiche;
        private Button buttonSuche;
        private Label labelArtikelnummer;
        private TextBox textBoxMaterialSuche;
    }
}