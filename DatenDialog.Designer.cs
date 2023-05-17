namespace Materialempfehlung
{
    partial class DatenDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBoxEmpfehlungBearbeiten = new GroupBox();
            comboBoxDatenDialogBereich = new ComboBox();
            buttonEmpfehlungDetailSpeichern = new Button();
            textBoxDetailBearbeiten = new TextBox();
            labelEmpfehlungDetailBearbeiten = new Label();
            labelEmpfehlungBereichBearbeiten = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBoxEmpfehlungBearbeiten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEmpfehlungBearbeiten
            // 
            groupBoxEmpfehlungBearbeiten.Controls.Add(comboBoxDatenDialogBereich);
            groupBoxEmpfehlungBearbeiten.Controls.Add(buttonEmpfehlungDetailSpeichern);
            groupBoxEmpfehlungBearbeiten.Controls.Add(textBoxDetailBearbeiten);
            groupBoxEmpfehlungBearbeiten.Controls.Add(labelEmpfehlungDetailBearbeiten);
            groupBoxEmpfehlungBearbeiten.Controls.Add(labelEmpfehlungBereichBearbeiten);
            groupBoxEmpfehlungBearbeiten.Dock = DockStyle.Fill;
            groupBoxEmpfehlungBearbeiten.Location = new Point(0, 0);
            groupBoxEmpfehlungBearbeiten.Name = "groupBoxEmpfehlungBearbeiten";
            groupBoxEmpfehlungBearbeiten.Size = new Size(348, 129);
            groupBoxEmpfehlungBearbeiten.TabIndex = 1;
            groupBoxEmpfehlungBearbeiten.TabStop = false;
            groupBoxEmpfehlungBearbeiten.Text = "Bearbeitung";
            // 
            // comboBoxDatenDialogBereich
            // 
            comboBoxDatenDialogBereich.FormattingEnabled = true;
            comboBoxDatenDialogBereich.Items.AddRange(new object[] { "ÄußererEinfluss", "Bedingung", "Besonderheit", "Druckverfahren", "Kategorie", "Klebstoff", "Oberfläche", "OberflächeBeschaffenheit", "OberflächeFarbe", "OberflächeForm", "OberflächeZustand", "Veredelung" });
            comboBoxDatenDialogBereich.Location = new Point(67, 31);
            comboBoxDatenDialogBereich.Name = "comboBoxDatenDialogBereich";
            comboBoxDatenDialogBereich.Size = new Size(176, 23);
            comboBoxDatenDialogBereich.TabIndex = 5;
            // 
            // buttonEmpfehlungDetailSpeichern
            // 
            buttonEmpfehlungDetailSpeichern.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEmpfehlungDetailSpeichern.BackColor = Color.DarkOrange;
            buttonEmpfehlungDetailSpeichern.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmpfehlungDetailSpeichern.ForeColor = SystemColors.Control;
            buttonEmpfehlungDetailSpeichern.Location = new Point(236, 92);
            buttonEmpfehlungDetailSpeichern.Name = "buttonEmpfehlungDetailSpeichern";
            buttonEmpfehlungDetailSpeichern.Size = new Size(106, 32);
            buttonEmpfehlungDetailSpeichern.TabIndex = 4;
            buttonEmpfehlungDetailSpeichern.Text = "Speichern";
            buttonEmpfehlungDetailSpeichern.UseVisualStyleBackColor = false;
            buttonEmpfehlungDetailSpeichern.Click += buttonEmpfehlungDetailSpeichern_Click;
            // 
            // textBoxDetailBearbeiten
            // 
            textBoxDetailBearbeiten.Location = new Point(67, 63);
            textBoxDetailBearbeiten.Name = "textBoxDetailBearbeiten";
            textBoxDetailBearbeiten.Size = new Size(176, 23);
            textBoxDetailBearbeiten.TabIndex = 3;
            // 
            // labelEmpfehlungDetailBearbeiten
            // 
            labelEmpfehlungDetailBearbeiten.AutoSize = true;
            labelEmpfehlungDetailBearbeiten.Location = new Point(6, 71);
            labelEmpfehlungDetailBearbeiten.Name = "labelEmpfehlungDetailBearbeiten";
            labelEmpfehlungDetailBearbeiten.Size = new Size(37, 15);
            labelEmpfehlungDetailBearbeiten.TabIndex = 1;
            labelEmpfehlungDetailBearbeiten.Text = "Detail";
            // 
            // labelEmpfehlungBereichBearbeiten
            // 
            labelEmpfehlungBereichBearbeiten.AutoSize = true;
            labelEmpfehlungBereichBearbeiten.Location = new Point(6, 39);
            labelEmpfehlungBereichBearbeiten.Name = "labelEmpfehlungBereichBearbeiten";
            labelEmpfehlungBereichBearbeiten.Size = new Size(46, 15);
            labelEmpfehlungBereichBearbeiten.TabIndex = 0;
            labelEmpfehlungBereichBearbeiten.Text = "Bereich";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DatenDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 129);
            Controls.Add(groupBoxEmpfehlungBearbeiten);
            Name = "DatenDialog";
            Text = "DatenDialog";
            groupBoxEmpfehlungBearbeiten.ResumeLayout(false);
            groupBoxEmpfehlungBearbeiten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEmpfehlungBearbeiten;
        private Button buttonEmpfehlungDetailSpeichern;
        private TextBox textBoxDetailBearbeiten;
        private Label labelEmpfehlungDetailBearbeiten;
        private Label labelEmpfehlungBereichBearbeiten;
        private ErrorProvider errorProvider1;
        private ComboBox comboBoxDatenDialogBereich;
    }
}