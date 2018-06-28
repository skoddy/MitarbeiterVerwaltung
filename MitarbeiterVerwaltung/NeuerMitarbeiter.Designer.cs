namespace MitarbeiterVerwaltung
{
    partial class NeuerMitarbeiter
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpGebDat = new System.Windows.Forms.DateTimePicker();
            this.tbAnspruchUrlaub = new System.Windows.Forms.TextBox();
            this.tbArbeitszeit = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.btnNeuerMitarbeiter = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Urlaubsanspruch / Jahr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tagesarbeitszeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geburtsdatum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nachname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vorname";
            // 
            // dtpGebDat
            // 
            this.dtpGebDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGebDat.Location = new System.Drawing.Point(12, 115);
            this.dtpGebDat.Name = "dtpGebDat";
            this.dtpGebDat.Size = new System.Drawing.Size(200, 20);
            this.dtpGebDat.TabIndex = 6;
            // 
            // tbAnspruchUrlaub
            // 
            this.tbAnspruchUrlaub.Location = new System.Drawing.Point(12, 197);
            this.tbAnspruchUrlaub.Name = "tbAnspruchUrlaub";
            this.tbAnspruchUrlaub.Size = new System.Drawing.Size(200, 20);
            this.tbAnspruchUrlaub.TabIndex = 5;
            // 
            // tbArbeitszeit
            // 
            this.tbArbeitszeit.Location = new System.Drawing.Point(12, 158);
            this.tbArbeitszeit.Name = "tbArbeitszeit";
            this.tbArbeitszeit.Size = new System.Drawing.Size(200, 20);
            this.tbArbeitszeit.TabIndex = 4;
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(12, 72);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(200, 20);
            this.tbNachname.TabIndex = 2;
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(12, 29);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(200, 20);
            this.tbVorname.TabIndex = 1;
            // 
            // btnNeuerMitarbeiter
            // 
            this.btnNeuerMitarbeiter.Location = new System.Drawing.Point(12, 223);
            this.btnNeuerMitarbeiter.Name = "btnNeuerMitarbeiter";
            this.btnNeuerMitarbeiter.Size = new System.Drawing.Size(81, 23);
            this.btnNeuerMitarbeiter.TabIndex = 0;
            this.btnNeuerMitarbeiter.Text = "Speichern";
            this.btnNeuerMitarbeiter.UseVisualStyleBackColor = true;
            this.btnNeuerMitarbeiter.Click += new System.EventHandler(this.btnNeuerMitarbeiter_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(125, 224);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(87, 23);
            this.btnAbbrechen.TabIndex = 12;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // NeuerMitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 268);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNeuerMitarbeiter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbArbeitszeit);
            this.Controls.Add(this.dtpGebDat);
            this.Controls.Add(this.tbAnspruchUrlaub);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeuerMitarbeiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NeuerMitarbeiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpGebDat;
        private System.Windows.Forms.TextBox tbAnspruchUrlaub;
        private System.Windows.Forms.TextBox tbArbeitszeit;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.Button btnNeuerMitarbeiter;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}