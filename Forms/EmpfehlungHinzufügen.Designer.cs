namespace Materialempfehlung
{
    partial class EmpfehlungHinzufügen
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
            labelEmpfehlungHinzuügen = new Label();
            textBoxEmpfehlungHinzufügenBereich = new TextBox();
            labelEmpfehlungHinzuügenFelder = new Label();
            listBoxEmpfehlungHinzufügenAuswahl = new ListBox();
            buttonHinzufügen = new Button();
            errorProviderEmpfehlungHinzufügen = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderEmpfehlungHinzufügen).BeginInit();
            SuspendLayout();
            // 
            // labelEmpfehlungHinzuügen
            // 
            labelEmpfehlungHinzuügen.AutoSize = true;
            labelEmpfehlungHinzuügen.Location = new Point(12, 26);
            labelEmpfehlungHinzuügen.Name = "labelEmpfehlungHinzuügen";
            labelEmpfehlungHinzuügen.Size = new Size(46, 15);
            labelEmpfehlungHinzuügen.TabIndex = 0;
            labelEmpfehlungHinzuügen.Text = "Bereich";
            // 
            // textBoxEmpfehlungHinzufügenBereich
            // 
            textBoxEmpfehlungHinzufügenBereich.Location = new Point(74, 18);
            textBoxEmpfehlungHinzufügenBereich.Name = "textBoxEmpfehlungHinzufügenBereich";
            textBoxEmpfehlungHinzufügenBereich.Size = new Size(152, 23);
            textBoxEmpfehlungHinzufügenBereich.TabIndex = 1;
            // 
            // labelEmpfehlungHinzuügenFelder
            // 
            labelEmpfehlungHinzuügenFelder.AutoSize = true;
            labelEmpfehlungHinzuügenFelder.Location = new Point(12, 62);
            labelEmpfehlungHinzuügenFelder.Name = "labelEmpfehlungHinzuügenFelder";
            labelEmpfehlungHinzuügenFelder.Size = new Size(39, 15);
            labelEmpfehlungHinzuügenFelder.TabIndex = 2;
            labelEmpfehlungHinzuügenFelder.Text = "Felder";
            // 
            // listBoxEmpfehlungHinzufügenAuswahl
            // 
            listBoxEmpfehlungHinzufügenAuswahl.FormattingEnabled = true;
            listBoxEmpfehlungHinzufügenAuswahl.ItemHeight = 15;
            listBoxEmpfehlungHinzufügenAuswahl.Location = new Point(74, 62);
            listBoxEmpfehlungHinzufügenAuswahl.Name = "listBoxEmpfehlungHinzufügenAuswahl";
            listBoxEmpfehlungHinzufügenAuswahl.SelectionMode = SelectionMode.MultiSimple;
            listBoxEmpfehlungHinzufügenAuswahl.Size = new Size(152, 94);
            listBoxEmpfehlungHinzufügenAuswahl.TabIndex = 3;
            // 
            // buttonHinzufügen
            // 
            buttonHinzufügen.BackColor = Color.DarkOrange;
            buttonHinzufügen.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHinzufügen.ForeColor = SystemColors.Control;
            buttonHinzufügen.Location = new Point(238, 155);
            buttonHinzufügen.Name = "buttonHinzufügen";
            buttonHinzufügen.Size = new Size(117, 41);
            buttonHinzufügen.TabIndex = 4;
            buttonHinzufügen.Text = "Hinzufügen";
            buttonHinzufügen.UseVisualStyleBackColor = false;
            buttonHinzufügen.Click += ButtonHinzufügen_Click;
            // 
            // errorProviderEmpfehlungHinzufügen
            // 
            errorProviderEmpfehlungHinzufügen.ContainerControl = this;
            // 
            // EmpfehlungHinzufügen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 208);
            Controls.Add(buttonHinzufügen);
            Controls.Add(listBoxEmpfehlungHinzufügenAuswahl);
            Controls.Add(labelEmpfehlungHinzuügenFelder);
            Controls.Add(textBoxEmpfehlungHinzufügenBereich);
            Controls.Add(labelEmpfehlungHinzuügen);
            Name = "EmpfehlungHinzufügen";
            Text = "EmpfehlungHinzufügen";
            ((System.ComponentModel.ISupportInitialize)errorProviderEmpfehlungHinzufügen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmpfehlungHinzuügen;
        private TextBox textBoxEmpfehlungHinzufügenBereich;
        private Label labelEmpfehlungHinzuügenFelder;
        private ListBox listBoxEmpfehlungHinzufügenAuswahl;
        private Button buttonHinzufügen;
        private ErrorProvider errorProviderEmpfehlungHinzufügen;
    }
}