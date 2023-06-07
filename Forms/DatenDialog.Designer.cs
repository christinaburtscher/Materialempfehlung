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
            textBoxBemerkung = new TextBox();
            labelBemerkung = new Label();
            textBoxBereich = new TextBox();
            buttonEmpfehlungDetailSpeichern = new Button();
            textBoxInhalt = new TextBox();
            labelEmpfehlungInhalt = new Label();
            labelEmpfehlungBereichBearbeiten = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBoxEmpfehlungBearbeiten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEmpfehlungBearbeiten
            // 
            groupBoxEmpfehlungBearbeiten.Controls.Add(textBoxBemerkung);
            groupBoxEmpfehlungBearbeiten.Controls.Add(labelBemerkung);
            groupBoxEmpfehlungBearbeiten.Controls.Add(textBoxBereich);
            groupBoxEmpfehlungBearbeiten.Controls.Add(buttonEmpfehlungDetailSpeichern);
            groupBoxEmpfehlungBearbeiten.Controls.Add(textBoxInhalt);
            groupBoxEmpfehlungBearbeiten.Controls.Add(labelEmpfehlungInhalt);
            groupBoxEmpfehlungBearbeiten.Controls.Add(labelEmpfehlungBereichBearbeiten);
            groupBoxEmpfehlungBearbeiten.Dock = DockStyle.Fill;
            groupBoxEmpfehlungBearbeiten.Location = new Point(0, 0);
            groupBoxEmpfehlungBearbeiten.Name = "groupBoxEmpfehlungBearbeiten";
            groupBoxEmpfehlungBearbeiten.Size = new Size(372, 198);
            groupBoxEmpfehlungBearbeiten.TabIndex = 1;
            groupBoxEmpfehlungBearbeiten.TabStop = false;
            groupBoxEmpfehlungBearbeiten.Text = "Bearbeitung";
            // 
            // textBoxBemerkung
            // 
            textBoxBemerkung.Location = new Point(76, 97);
            textBoxBemerkung.Multiline = true;
            textBoxBemerkung.Name = "textBoxBemerkung";
            textBoxBemerkung.Size = new Size(176, 58);
            textBoxBemerkung.TabIndex = 7;
            // 
            // labelBemerkung
            // 
            labelBemerkung.AutoSize = true;
            labelBemerkung.Location = new Point(6, 105);
            labelBemerkung.Name = "labelBemerkung";
            labelBemerkung.Size = new Size(68, 15);
            labelBemerkung.TabIndex = 6;
            labelBemerkung.Text = "Bemerkung";
            // 
            // textBoxBereich
            // 
            textBoxBereich.Location = new Point(76, 31);
            textBoxBereich.Name = "textBoxBereich";
            textBoxBereich.Size = new Size(176, 23);
            textBoxBereich.TabIndex = 5;
            // 
            // buttonEmpfehlungDetailSpeichern
            // 
            buttonEmpfehlungDetailSpeichern.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEmpfehlungDetailSpeichern.BackColor = Color.DarkOrange;
            buttonEmpfehlungDetailSpeichern.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmpfehlungDetailSpeichern.ForeColor = SystemColors.Control;
            buttonEmpfehlungDetailSpeichern.Location = new Point(260, 161);
            buttonEmpfehlungDetailSpeichern.Name = "buttonEmpfehlungDetailSpeichern";
            buttonEmpfehlungDetailSpeichern.Size = new Size(106, 32);
            buttonEmpfehlungDetailSpeichern.TabIndex = 4;
            buttonEmpfehlungDetailSpeichern.Text = "Speichern";
            buttonEmpfehlungDetailSpeichern.UseVisualStyleBackColor = false;
            buttonEmpfehlungDetailSpeichern.Click += ButtonEmpfehlungDetailSpeichern_Click;
            // 
            // textBoxInhalt
            // 
            textBoxInhalt.Location = new Point(76, 63);
            textBoxInhalt.Name = "textBoxInhalt";
            textBoxInhalt.Size = new Size(176, 23);
            textBoxInhalt.TabIndex = 3;
            // 
            // labelEmpfehlungInhalt
            // 
            labelEmpfehlungInhalt.AutoSize = true;
            labelEmpfehlungInhalt.Location = new Point(6, 71);
            labelEmpfehlungInhalt.Name = "labelEmpfehlungInhalt";
            labelEmpfehlungInhalt.Size = new Size(37, 15);
            labelEmpfehlungInhalt.TabIndex = 1;
            labelEmpfehlungInhalt.Text = "Inhalt";
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
            ClientSize = new Size(372, 198);
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
        private TextBox textBoxInhalt;
        private Label labelEmpfehlungInhalt;
        private Label labelEmpfehlungBereichBearbeiten;
        private ErrorProvider errorProvider1;
        private TextBox textBoxBereich;
        private TextBox textBoxBemerkung;
        private Label labelBemerkung;
    }
}