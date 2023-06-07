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
            components = new System.ComponentModel.Container();
            errorProviderVorauswahl = new ErrorProvider(components);
            tabControlMonitor = new TabControl();
            tabPageMaterial = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBoxVorauswahl = new GroupBox();
            buttonLogin = new Button();
            textBoxPasswort = new TextBox();
            textBoxUser = new TextBox();
            labelPasswort = new Label();
            labelUser = new Label();
            buttonVorauswahl = new Button();
            textBoxVorauswahl = new TextBox();
            tabPageEmpfehlungen_Admin = new TabPage();
            tabPageÜbersicht = new TabPage();
            ((System.ComponentModel.ISupportInitialize)errorProviderVorauswahl).BeginInit();
            tabControlMonitor.SuspendLayout();
            tabPageMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxVorauswahl.SuspendLayout();
            SuspendLayout();
            // 
            // errorProviderVorauswahl
            // 
            errorProviderVorauswahl.ContainerControl = this;
            // 
            // tabControlMonitor
            // 
            tabControlMonitor.Controls.Add(tabPageMaterial);
            tabControlMonitor.Controls.Add(tabPageÜbersicht);
            tabControlMonitor.Controls.Add(tabPageEmpfehlungen_Admin);
            tabControlMonitor.Dock = DockStyle.Fill;
            tabControlMonitor.Location = new Point(0, 0);
            tabControlMonitor.Name = "tabControlMonitor";
            tabControlMonitor.SelectedIndex = 0;
            tabControlMonitor.Size = new Size(1156, 1056);
            tabControlMonitor.TabIndex = 0;
            // 
            // tabPageMaterial
            // 
            tabPageMaterial.Controls.Add(splitContainer1);
            tabPageMaterial.Location = new Point(4, 24);
            tabPageMaterial.Name = "tabPageMaterial";
            tabPageMaterial.Padding = new Padding(3);
            tabPageMaterial.Size = new Size(1148, 1028);
            tabPageMaterial.TabIndex = 0;
            tabPageMaterial.Text = "Material";
            tabPageMaterial.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxVorauswahl);
            splitContainer1.Size = new Size(1142, 1022);
            splitContainer1.SplitterDistance = 88;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxVorauswahl
            // 
            groupBoxVorauswahl.Controls.Add(buttonLogin);
            groupBoxVorauswahl.Controls.Add(textBoxPasswort);
            groupBoxVorauswahl.Controls.Add(textBoxUser);
            groupBoxVorauswahl.Controls.Add(labelPasswort);
            groupBoxVorauswahl.Controls.Add(labelUser);
            groupBoxVorauswahl.Controls.Add(buttonVorauswahl);
            groupBoxVorauswahl.Controls.Add(textBoxVorauswahl);
            groupBoxVorauswahl.Dock = DockStyle.Fill;
            groupBoxVorauswahl.Location = new Point(0, 0);
            groupBoxVorauswahl.Name = "groupBoxVorauswahl";
            groupBoxVorauswahl.Size = new Size(1142, 88);
            groupBoxVorauswahl.TabIndex = 0;
            groupBoxVorauswahl.TabStop = false;
            groupBoxVorauswahl.Text = "Vorauswahl";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkOrange;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(950, 10);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(119, 51);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseMnemonic = false;
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(876, 39);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.PasswordChar = '*';
            textBoxPasswort.Size = new Size(68, 23);
            textBoxPasswort.TabIndex = 6;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(876, 11);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(68, 23);
            textBoxUser.TabIndex = 5;
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPasswort.Location = new Point(800, 46);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(70, 16);
            labelPasswort.TabIndex = 4;
            labelPasswort.Text = "Passwort";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.Location = new Point(800, 18);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(40, 16);
            labelUser.TabIndex = 3;
            labelUser.Text = "User";
            // 
            // buttonVorauswahl
            // 
            buttonVorauswahl.BackColor = Color.DarkOrange;
            buttonVorauswahl.FlatStyle = FlatStyle.Flat;
            buttonVorauswahl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVorauswahl.ForeColor = SystemColors.Control;
            buttonVorauswahl.Location = new Point(172, 22);
            buttonVorauswahl.Name = "buttonVorauswahl";
            buttonVorauswahl.Size = new Size(93, 27);
            buttonVorauswahl.TabIndex = 2;
            buttonVorauswahl.Text = "Suche";
            buttonVorauswahl.UseVisualStyleBackColor = false;
            buttonVorauswahl.Click += ButtonVorauswahl_Click;
            // 
            // textBoxVorauswahl
            // 
            textBoxVorauswahl.Location = new Point(6, 23);
            textBoxVorauswahl.Name = "textBoxVorauswahl";
            textBoxVorauswahl.Size = new Size(149, 23);
            textBoxVorauswahl.TabIndex = 1;
            // 
            // tabPageEmpfehlungen_Admin
            // 
            tabPageEmpfehlungen_Admin.Location = new Point(4, 24);
            tabPageEmpfehlungen_Admin.Name = "tabPageEmpfehlungen_Admin";
            tabPageEmpfehlungen_Admin.Padding = new Padding(3);
            tabPageEmpfehlungen_Admin.Size = new Size(1148, 1028);
            tabPageEmpfehlungen_Admin.TabIndex = 1;
            tabPageEmpfehlungen_Admin.Text = "Empfehlungen_Admin";
            tabPageEmpfehlungen_Admin.UseVisualStyleBackColor = true;
            // 
            // tabPageÜbersicht
            // 
            tabPageÜbersicht.Location = new Point(4, 24);
            tabPageÜbersicht.Name = "tabPageÜbersicht";
            tabPageÜbersicht.Size = new Size(1148, 1028);
            tabPageÜbersicht.TabIndex = 2;
            tabPageÜbersicht.Text = "Übersicht";
            tabPageÜbersicht.UseVisualStyleBackColor = true;
            // 
            // Monitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 1056);
            Controls.Add(tabControlMonitor);
            Name = "Monitor";
            Text = "Materialempfehlung";
            ((System.ComponentModel.ISupportInitialize)errorProviderVorauswahl).EndInit();
            tabControlMonitor.ResumeLayout(false);
            tabPageMaterial.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxVorauswahl.ResumeLayout(false);
            groupBoxVorauswahl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProviderVorauswahl;
        private TabControl tabControlMonitor;
        private TabPage tabPageMaterial;
        private TabPage tabPageEmpfehlungen_Admin;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxVorauswahl;
        private Button buttonVorauswahl;
        private TextBox textBoxVorauswahl;
        private Button buttonLogin;
        private TextBox textBoxPasswort;
        private TextBox textBoxUser;
        private Label labelPasswort;
        private Label labelUser;
        private TabPage tabPageÜbersicht;
    }
}