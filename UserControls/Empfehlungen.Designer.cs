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
            splitContainer1 = new SplitContainer();
            listBoxEmpfehlungen_Detail = new ListBox();
            listBoxMaterialEmpfehlung_Detail = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBoxEmpfehlungen_Detail);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listBoxMaterialEmpfehlung_Detail);
            splitContainer1.Size = new Size(743, 533);
            splitContainer1.SplitterDistance = 247;
            splitContainer1.TabIndex = 0;
            // 
            // listBoxEmpfehlungen_Detail
            // 
            listBoxEmpfehlungen_Detail.Dock = DockStyle.Fill;
            listBoxEmpfehlungen_Detail.FormattingEnabled = true;
            listBoxEmpfehlungen_Detail.ItemHeight = 15;
            listBoxEmpfehlungen_Detail.Location = new Point(0, 0);
            listBoxEmpfehlungen_Detail.Name = "listBoxEmpfehlungen_Detail";
            listBoxEmpfehlungen_Detail.Size = new Size(247, 533);
            listBoxEmpfehlungen_Detail.TabIndex = 0;
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
            // Empfehlungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "Empfehlungen";
            Size = new Size(743, 533);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox listBoxEmpfehlungen_Detail;
        private ListBox listBoxMaterialEmpfehlung_Detail;
    }
}
