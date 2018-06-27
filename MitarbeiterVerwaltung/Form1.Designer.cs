namespace MitarbeiterVerwaltung
{
    partial class MitarbeiterVerwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMitarbeiter = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbEinsatz = new System.Windows.Forms.ListBox();
            this.lbFehlzeit = new System.Windows.Forms.ListBox();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.tbArbeitszeit = new System.Windows.Forms.TextBox();
            this.tbAnspruchUrlaub = new System.Windows.Forms.TextBox();
            this.dtpGebDat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMitarbeiterUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStammdaten = new System.Windows.Forms.TabPage();
            this.tabEinsatz = new System.Windows.Forms.TabPage();
            this.tabFehlzeiten = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerMitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einsatzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fehlzeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fehlzeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabStammdaten.SuspendLayout();
            this.tabEinsatz.SuspendLayout();
            this.tabFehlzeiten.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMitarbeiter
            // 
            this.lbMitarbeiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMitarbeiter.FormattingEnabled = true;
            this.lbMitarbeiter.Location = new System.Drawing.Point(3, 16);
            this.lbMitarbeiter.Name = "lbMitarbeiter";
            this.lbMitarbeiter.Size = new System.Drawing.Size(206, 362);
            this.lbMitarbeiter.TabIndex = 1;
            this.lbMitarbeiter.SelectedIndexChanged += new System.EventHandler(this.lbMitarbeiter_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbMitarbeiter);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 381);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mitarbeiter";
            // 
            // lbEinsatz
            // 
            this.lbEinsatz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEinsatz.FormattingEnabled = true;
            this.lbEinsatz.Location = new System.Drawing.Point(3, 3);
            this.lbEinsatz.Name = "lbEinsatz";
            this.lbEinsatz.Size = new System.Drawing.Size(250, 349);
            this.lbEinsatz.TabIndex = 0;
            // 
            // lbFehlzeit
            // 
            this.lbFehlzeit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFehlzeit.FormattingEnabled = true;
            this.lbFehlzeit.Location = new System.Drawing.Point(3, 3);
            this.lbFehlzeit.Name = "lbFehlzeit";
            this.lbFehlzeit.Size = new System.Drawing.Size(250, 349);
            this.lbFehlzeit.TabIndex = 0;
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(6, 36);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(238, 20);
            this.tbVorname.TabIndex = 1;
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(6, 79);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(238, 20);
            this.tbNachname.TabIndex = 2;
            // 
            // tbArbeitszeit
            // 
            this.tbArbeitszeit.Location = new System.Drawing.Point(6, 165);
            this.tbArbeitszeit.Name = "tbArbeitszeit";
            this.tbArbeitszeit.Size = new System.Drawing.Size(238, 20);
            this.tbArbeitszeit.TabIndex = 4;
            // 
            // tbAnspruchUrlaub
            // 
            this.tbAnspruchUrlaub.Location = new System.Drawing.Point(6, 204);
            this.tbAnspruchUrlaub.Name = "tbAnspruchUrlaub";
            this.tbAnspruchUrlaub.Size = new System.Drawing.Size(238, 20);
            this.tbAnspruchUrlaub.TabIndex = 5;
            // 
            // dtpGebDat
            // 
            this.dtpGebDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGebDat.Location = new System.Drawing.Point(6, 122);
            this.dtpGebDat.Name = "dtpGebDat";
            this.dtpGebDat.Size = new System.Drawing.Size(238, 20);
            this.dtpGebDat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geburtsdatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tagesarbeitszeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Urlaubsanspruch / Jahr";
            // 
            // btnMitarbeiterUpdate
            // 
            this.btnMitarbeiterUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMitarbeiterUpdate.Location = new System.Drawing.Point(3, 323);
            this.btnMitarbeiterUpdate.Name = "btnMitarbeiterUpdate";
            this.btnMitarbeiterUpdate.Size = new System.Drawing.Size(244, 23);
            this.btnMitarbeiterUpdate.TabIndex = 12;
            this.btnMitarbeiterUpdate.Text = "Änderungen speichern";
            this.btnMitarbeiterUpdate.UseVisualStyleBackColor = true;
            this.btnMitarbeiterUpdate.Click += new System.EventHandler(this.btnMitarbeiterUpdate_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMitarbeiterUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpGebDat);
            this.groupBox1.Controls.Add(this.tbAnspruchUrlaub);
            this.groupBox1.Controls.Add(this.tbArbeitszeit);
            this.groupBox1.Controls.Add(this.tbNachname);
            this.groupBox1.Controls.Add(this.tbVorname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mitarbeiter";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStammdaten);
            this.tabControl1.Controls.Add(this.tabEinsatz);
            this.tabControl1.Controls.Add(this.tabFehlzeiten);
            this.tabControl1.Location = new System.Drawing.Point(230, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 381);
            this.tabControl1.TabIndex = 6;
            // 
            // tabStammdaten
            // 
            this.tabStammdaten.Controls.Add(this.groupBox1);
            this.tabStammdaten.Location = new System.Drawing.Point(4, 22);
            this.tabStammdaten.Name = "tabStammdaten";
            this.tabStammdaten.Padding = new System.Windows.Forms.Padding(3);
            this.tabStammdaten.Size = new System.Drawing.Size(256, 355);
            this.tabStammdaten.TabIndex = 0;
            this.tabStammdaten.Text = "Stammdaten";
            this.tabStammdaten.UseVisualStyleBackColor = true;
            // 
            // tabEinsatz
            // 
            this.tabEinsatz.Controls.Add(this.lbEinsatz);
            this.tabEinsatz.Location = new System.Drawing.Point(4, 22);
            this.tabEinsatz.Name = "tabEinsatz";
            this.tabEinsatz.Padding = new System.Windows.Forms.Padding(3);
            this.tabEinsatz.Size = new System.Drawing.Size(256, 355);
            this.tabEinsatz.TabIndex = 1;
            this.tabEinsatz.Text = "Einsatz";
            this.tabEinsatz.UseVisualStyleBackColor = true;
            // 
            // tabFehlzeiten
            // 
            this.tabFehlzeiten.Controls.Add(this.lbFehlzeit);
            this.tabFehlzeiten.Location = new System.Drawing.Point(4, 22);
            this.tabFehlzeiten.Name = "tabFehlzeiten";
            this.tabFehlzeiten.Padding = new System.Windows.Forms.Padding(3);
            this.tabFehlzeiten.Size = new System.Drawing.Size(256, 355);
            this.tabFehlzeiten.TabIndex = 2;
            this.tabFehlzeiten.Text = "Fehlzeiten";
            this.tabFehlzeiten.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.auswertungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerMitarbeiterToolStripMenuItem,
            this.einsatzToolStripMenuItem,
            this.fehlzeitToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.neuToolStripMenuItem.Text = "Neu...";
            // 
            // neuerMitarbeiterToolStripMenuItem
            // 
            this.neuerMitarbeiterToolStripMenuItem.Name = "neuerMitarbeiterToolStripMenuItem";
            this.neuerMitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neuerMitarbeiterToolStripMenuItem.Text = "Mitarbeiter";
            this.neuerMitarbeiterToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // einsatzToolStripMenuItem
            // 
            this.einsatzToolStripMenuItem.Name = "einsatzToolStripMenuItem";
            this.einsatzToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.einsatzToolStripMenuItem.Text = "Einsatz";
            this.einsatzToolStripMenuItem.Click += new System.EventHandler(this.einsatzToolStripMenuItem_Click);
            // 
            // fehlzeitToolStripMenuItem
            // 
            this.fehlzeitToolStripMenuItem.Name = "fehlzeitToolStripMenuItem";
            this.fehlzeitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fehlzeitToolStripMenuItem.Text = "Fehlzeit";
            this.fehlzeitToolStripMenuItem.Click += new System.EventHandler(this.fehlzeitToolStripMenuItem_Click);
            // 
            // auswertungToolStripMenuItem
            // 
            this.auswertungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fehlzeitenToolStripMenuItem});
            this.auswertungToolStripMenuItem.Name = "auswertungToolStripMenuItem";
            this.auswertungToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.auswertungToolStripMenuItem.Text = "Auswertung";
            // 
            // fehlzeitenToolStripMenuItem
            // 
            this.fehlzeitenToolStripMenuItem.Name = "fehlzeitenToolStripMenuItem";
            this.fehlzeitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fehlzeitenToolStripMenuItem.Text = "Fehlzeiten";
            this.fehlzeitenToolStripMenuItem.Click += new System.EventHandler(this.fehlzeitenToolStripMenuItem_Click);
            // 
            // MitarbeiterVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 414);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MitarbeiterVerwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitarbeiter Verwaltung 9000";
            this.Load += new System.EventHandler(this.MitarbeiterVerwaltung_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabStammdaten.ResumeLayout(false);
            this.tabEinsatz.ResumeLayout(false);
            this.tabFehlzeiten.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbMitarbeiter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbEinsatz;
        private System.Windows.Forms.ListBox lbFehlzeit;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.TextBox tbArbeitszeit;
        private System.Windows.Forms.TextBox tbAnspruchUrlaub;
        private System.Windows.Forms.DateTimePicker dtpGebDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMitarbeiterUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStammdaten;
        private System.Windows.Forms.TabPage tabEinsatz;
        private System.Windows.Forms.TabPage tabFehlzeiten;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuerMitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einsatzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fehlzeitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswertungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fehlzeitenToolStripMenuItem;
    }
}

