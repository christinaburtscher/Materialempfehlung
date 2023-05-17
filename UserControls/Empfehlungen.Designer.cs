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
            listBoxEmpfehlungen_Detail = new ListBox();
            listBoxMaterialEmpfehlung_Detail = new ListBox();
            contextMenuStripBereiche = new ContextMenuStrip(components);
            neuToolStripMenuItem = new ToolStripMenuItem();
            bearbeitenToolStripMenuItem = new ToolStripMenuItem();
            löschenToolStripMenuItem = new ToolStripMenuItem();
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
            splitContainer2.Panel1.Controls.Add(listBoxEmpfehlungen_Detail);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listBoxMaterialEmpfehlung_Detail);
            splitContainer2.Size = new Size(743, 533);
            splitContainer2.SplitterDistance = 247;
            splitContainer2.TabIndex = 2;
            // 
            // listBoxEmpfehlungen_Detail
            // 
            listBoxEmpfehlungen_Detail.Dock = DockStyle.Fill;
            listBoxEmpfehlungen_Detail.FormattingEnabled = true;
            listBoxEmpfehlungen_Detail.ItemHeight = 15;
            listBoxEmpfehlungen_Detail.Items.AddRange(new object[] { "ÄußererEinfluss", "Bedingung", "Besonderheit", "Druckverfahren", "Kategorie", "Klebstoff", "Material", "Oberfläche", "OberflächeBeschaffenheit", "OberflächeFarbe", "OberflächeForm", "OberflächeZustand", "Veredelung" });
            listBoxEmpfehlungen_Detail.Location = new Point(0, 0);
            listBoxEmpfehlungen_Detail.Name = "listBoxEmpfehlungen_Detail";
            listBoxEmpfehlungen_Detail.Size = new Size(247, 533);
            listBoxEmpfehlungen_Detail.TabIndex = 0;
            listBoxEmpfehlungen_Detail.SelectedIndexChanged += ListBoxEmpfehlungen_Detail_SelectedIndexChanged;
            // 
            // listBoxMaterialEmpfehlung_Detail
            // 
            listBoxMaterialEmpfehlung_Detail.Dock = DockStyle.Fill;
            listBoxMaterialEmpfehlung_Detail.FormattingEnabled = true;
            listBoxMaterialEmpfehlung_Detail.ItemHeight = 15;
            listBoxMaterialEmpfehlung_Detail.Location = new Point(0, 0);
            listBoxMaterialEmpfehlung_Detail.Name = "listBoxMaterialEmpfehlung_Detail";
            listBoxMaterialEmpfehlung_Detail.Size = new Size(492, 533);
            listBoxMaterialEmpfehlung_Detail.TabIndex = 0;
            // 
            // contextMenuStripBereiche
            // 
            contextMenuStripBereiche.Items.AddRange(new ToolStripItem[] { neuToolStripMenuItem, bearbeitenToolStripMenuItem, löschenToolStripMenuItem });
            contextMenuStripBereiche.Name = "contextMenuStripBereiche";
            contextMenuStripBereiche.Size = new Size(131, 70);
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            neuToolStripMenuItem.Size = new Size(130, 22);
            neuToolStripMenuItem.Text = "Neu";
            neuToolStripMenuItem.Click += NeuToolStripMenuItem_Click;
            // 
            // bearbeitenToolStripMenuItem
            // 
            bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            bearbeitenToolStripMenuItem.Size = new Size(130, 22);
            bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            bearbeitenToolStripMenuItem.Click += BearbeitenToolStripMenuItem_Click;
            // 
            // löschenToolStripMenuItem
            // 
            löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            löschenToolStripMenuItem.Size = new Size(130, 22);
            löschenToolStripMenuItem.Text = "Löschen";
            löschenToolStripMenuItem.Click += LöschenToolStripMenuItem_Click;
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
        private ListBox listBoxEmpfehlungen_Detail;
        private ListBox listBoxMaterialEmpfehlung_Detail;
        private ContextMenuStrip contextMenuStripBereiche;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem bearbeitenToolStripMenuItem;
        private ToolStripMenuItem löschenToolStripMenuItem;
        private ErrorProvider errorProviderEmpfehlungen;
    }
}
