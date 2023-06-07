namespace Materialempfehlung.Forms
{
    partial class EmpfehlungenErsetzen
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
            labelBereich = new Label();
            labelInhalt = new Label();
            labelNeuerInhalt = new Label();
            textBoxBereich = new TextBox();
            textBoxInhalt = new TextBox();
            checkBoxVerbindungenErsetzen = new CheckBox();
            comboBoxInhalte = new ComboBox();
            buttonSpeichern = new Button();
            SuspendLayout();
            // 
            // labelBereich
            // 
            labelBereich.AutoSize = true;
            labelBereich.Location = new Point(12, 31);
            labelBereich.Name = "labelBereich";
            labelBereich.Size = new Size(46, 15);
            labelBereich.TabIndex = 0;
            labelBereich.Text = "Bereich";
            // 
            // labelInhalt
            // 
            labelInhalt.AutoSize = true;
            labelInhalt.Location = new Point(12, 77);
            labelInhalt.Name = "labelInhalt";
            labelInhalt.Size = new Size(37, 15);
            labelInhalt.TabIndex = 1;
            labelInhalt.Text = "Inhalt";
            // 
            // labelNeuerInhalt
            // 
            labelNeuerInhalt.AutoSize = true;
            labelNeuerInhalt.Location = new Point(12, 159);
            labelNeuerInhalt.Name = "labelNeuerInhalt";
            labelNeuerInhalt.Size = new Size(70, 15);
            labelNeuerInhalt.TabIndex = 2;
            labelNeuerInhalt.Text = "neuer Inhalt";
            // 
            // textBoxBereich
            // 
            textBoxBereich.Location = new Point(109, 21);
            textBoxBereich.Name = "textBoxBereich";
            textBoxBereich.Size = new Size(165, 23);
            textBoxBereich.TabIndex = 4;
            // 
            // textBoxInhalt
            // 
            textBoxInhalt.Location = new Point(109, 67);
            textBoxInhalt.Name = "textBoxInhalt";
            textBoxInhalt.Size = new Size(165, 23);
            textBoxInhalt.TabIndex = 5;
            // 
            // checkBoxVerbindungenErsetzen
            // 
            checkBoxVerbindungenErsetzen.AutoSize = true;
            checkBoxVerbindungenErsetzen.Location = new Point(109, 111);
            checkBoxVerbindungenErsetzen.Name = "checkBoxVerbindungenErsetzen";
            checkBoxVerbindungenErsetzen.Size = new Size(167, 19);
            checkBoxVerbindungenErsetzen.TabIndex = 7;
            checkBoxVerbindungenErsetzen.Text = "alle Verbindungen ersetzen";
            checkBoxVerbindungenErsetzen.UseVisualStyleBackColor = true;
            checkBoxVerbindungenErsetzen.CheckedChanged += CheckBoxVerbindungenErsetzen_CheckedChanged;
            // 
            // comboBoxInhalte
            // 
            comboBoxInhalte.FormattingEnabled = true;
            comboBoxInhalte.Location = new Point(109, 151);
            comboBoxInhalte.Name = "comboBoxInhalte";
            comboBoxInhalte.Size = new Size(165, 23);
            comboBoxInhalte.TabIndex = 8;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.BackColor = Color.DarkOrange;
            buttonSpeichern.FlatStyle = FlatStyle.Flat;
            buttonSpeichern.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSpeichern.ForeColor = SystemColors.Control;
            buttonSpeichern.Location = new Point(309, 21);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(90, 69);
            buttonSpeichern.TabIndex = 9;
            buttonSpeichern.Text = "Löschen / Ersetzen";
            buttonSpeichern.UseVisualStyleBackColor = false;
            buttonSpeichern.Click += ButtonSpeichern_Click;
            // 
            // EmpfehlungenErsetzen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 190);
            Controls.Add(buttonSpeichern);
            Controls.Add(comboBoxInhalte);
            Controls.Add(checkBoxVerbindungenErsetzen);
            Controls.Add(textBoxInhalt);
            Controls.Add(textBoxBereich);
            Controls.Add(labelNeuerInhalt);
            Controls.Add(labelInhalt);
            Controls.Add(labelBereich);
            Name = "EmpfehlungenErsetzen";
            Text = "EmpfehlungenErsetzen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBereich;
        private Label labelInhalt;
        private Label labelNeuerInhalt;
        private TextBox textBoxBereich;
        private TextBox textBoxInhalt;
        private CheckBox checkBoxVerbindungenErsetzen;
        private ComboBox comboBoxInhalte;
        private Button buttonSpeichern;
    }
}