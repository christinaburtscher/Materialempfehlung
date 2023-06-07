namespace Materialempfehlung
{
    partial class Empfehlungen
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
            splitContainer2 = new SplitContainer();
            listBoxEmpfehlungen_Bereiche = new ListBox();
            listBoxMaterialEmpfehlung_Inhalt = new ListBox();
            contextMenuStripBereiche = new ContextMenuStrip(components);
            neuerInhaltToolStripMenuItem = new ToolStripMenuItem();
            löschenToolStripMenuItem = new ToolStripMenuItem();
            neuerBereichToolStripMenuItem = new ToolStripMenuItem();
            errorProviderEmpfehlungen = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            contextMenuStripBereiche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmpfehlungen).BeginInit();
            SuspendLayout();
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listBoxEmpfehlungen_Bereiche);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listBoxMaterialEmpfehlung_Inhalt);
            splitContainer2.Size = new Size(743, 533);
            splitContainer2.SplitterDistance = 247;
            splitContainer2.TabIndex = 2;
            // 
            // listBoxEmpfehlungen_Bereiche
            // 
            listBoxEmpfehlungen_Bereiche.Dock = DockStyle.Fill;
            listBoxEmpfehlungen_Bereiche.FormattingEnabled = true;
            listBoxEmpfehlungen_Bereiche.ItemHeight = 15;
            listBoxEmpfehlungen_Bereiche.Items.AddRange(new object[] { "Äußerer_Einfluss", "Bedingung", "Besonderheit", "Druckverfahren", "Kategorie", "Klebstoff", "Oberfläche", "Oberfläche_Beschaffenheit", "Oberfläche_Farbe", "Oberfläche_Form", "Oberfläche_Zustand", "Veredelung" });
            listBoxEmpfehlungen_Bereiche.Location = new Point(0, 0);
            listBoxEmpfehlungen_Bereiche.Name = "listBoxEmpfehlungen_Bereiche";
            listBoxEmpfehlungen_Bereiche.Size = new Size(247, 533);
            listBoxEmpfehlungen_Bereiche.TabIndex = 0;
            listBoxEmpfehlungen_Bereiche.SelectedIndexChanged += ListBoxEmpfehlungen_Detail_SelectedIndexChanged;
            listBoxEmpfehlungen_Bereiche.MouseDown += ListBoxEmpfehlungen_Bereiche_MouseDown;
            // 
            // listBoxMaterialEmpfehlung_Inhalt
            // 
            listBoxMaterialEmpfehlung_Inhalt.Dock = DockStyle.Fill;
            listBoxMaterialEmpfehlung_Inhalt.FormattingEnabled = true;
            listBoxMaterialEmpfehlung_Inhalt.ItemHeight = 15;
            listBoxMaterialEmpfehlung_Inhalt.Location = new Point(0, 0);
            listBoxMaterialEmpfehlung_Inhalt.Name = "listBoxMaterialEmpfehlung_Inhalt";
            listBoxMaterialEmpfehlung_Inhalt.Size = new Size(492, 533);
            listBoxMaterialEmpfehlung_Inhalt.TabIndex = 0;
            // 
            // contextMenuStripBereiche
            // 
            contextMenuStripBereiche.Items.AddRange(new ToolStripItem[] { neuerInhaltToolStripMenuItem, löschenToolStripMenuItem, neuerBereichToolStripMenuItem });
            contextMenuStripBereiche.Name = "contextMenuStripBereiche";
            contextMenuStripBereiche.Size = new Size(203, 70);
            // 
            // neuerInhaltToolStripMenuItem
            // 
            neuerInhaltToolStripMenuItem.Name = "neuerInhaltToolStripMenuItem";
            neuerInhaltToolStripMenuItem.Size = new Size(202, 22);
            neuerInhaltToolStripMenuItem.Text = "Neuer Inhalt";
            neuerInhaltToolStripMenuItem.Click += NeuerInhaltToolStripMenuItem_Click;
            // 
            // löschenToolStripMenuItem
            // 
            löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            löschenToolStripMenuItem.Size = new Size(202, 22);
            löschenToolStripMenuItem.Text = "Inhalt löschen / ersetzen";
            löschenToolStripMenuItem.Click += LöschenToolStripMenuItem_Click;
            // 
            // neuerBereichToolStripMenuItem
            // 
            neuerBereichToolStripMenuItem.Name = "neuerBereichToolStripMenuItem";
            neuerBereichToolStripMenuItem.Size = new Size(202, 22);
            neuerBereichToolStripMenuItem.Text = "Neuer Bereich";
            neuerBereichToolStripMenuItem.Click += NeuerBereichToolStripMenuItem_Click;
            // 
            // errorProviderEmpfehlungen
            // 
            errorProviderEmpfehlungen.ContainerControl = this;
            // 
            // Empfehlungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer2);
            Name = "Empfehlungen";
            Size = new Size(743, 533);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            contextMenuStripBereiche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProviderEmpfehlungen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer2;
        private ListBox listBoxEmpfehlungen_Bereiche;
        private ListBox listBoxMaterialEmpfehlung_Inhalt;
        private ContextMenuStrip contextMenuStripBereiche;
        private ToolStripMenuItem neuerBereichToolStripMenuItem;
        private ToolStripMenuItem neuerInhaltToolStripMenuItem;
        private ToolStripMenuItem löschenToolStripMenuItem;
        private ErrorProvider errorProviderEmpfehlungen;
    }
}
