namespace MitarbeiterVerwaltung
{
    partial class NeuerEinsatz
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
            this.btnNeuerEinsatz = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEinsatzBisUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.dtpEinsatzVonUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.dtpEinsatzDatum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNeuerEinsatz
            // 
            this.btnNeuerEinsatz.Location = new System.Drawing.Point(12, 153);
            this.btnNeuerEinsatz.Name = "btnNeuerEinsatz";
            this.btnNeuerEinsatz.Size = new System.Drawing.Size(99, 23);
            this.btnNeuerEinsatz.TabIndex = 6;
            this.btnNeuerEinsatz.Text = "Speichern";
            this.btnNeuerEinsatz.UseVisualStyleBackColor = true;
            this.btnNeuerEinsatz.Click += new System.EventHandler(this.btnNeuerEinsatz_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bis (Uhrzeit)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Von (Uhrzeit)";
            // 
            // dtpEinsatzBisUhrzeit
            // 
            this.dtpEinsatzBisUhrzeit.CustomFormat = "HH:mm";
            this.dtpEinsatzBisUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEinsatzBisUhrzeit.Location = new System.Drawing.Point(163, 106);
            this.dtpEinsatzBisUhrzeit.Name = "dtpEinsatzBisUhrzeit";
            this.dtpEinsatzBisUhrzeit.ShowUpDown = true;
            this.dtpEinsatzBisUhrzeit.Size = new System.Drawing.Size(69, 20);
            this.dtpEinsatzBisUhrzeit.TabIndex = 3;
            this.dtpEinsatzBisUhrzeit.Value = new System.DateTime(2018, 6, 28, 12, 0, 0, 0);
            // 
            // dtpEinsatzVonUhrzeit
            // 
            this.dtpEinsatzVonUhrzeit.CustomFormat = "HH:mm";
            this.dtpEinsatzVonUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEinsatzVonUhrzeit.Location = new System.Drawing.Point(12, 106);
            this.dtpEinsatzVonUhrzeit.Name = "dtpEinsatzVonUhrzeit";
            this.dtpEinsatzVonUhrzeit.ShowUpDown = true;
            this.dtpEinsatzVonUhrzeit.Size = new System.Drawing.Size(68, 20);
            this.dtpEinsatzVonUhrzeit.TabIndex = 2;
            this.dtpEinsatzVonUhrzeit.Value = new System.DateTime(2018, 6, 28, 12, 0, 0, 0);
            // 
            // dtpEinsatzDatum
            // 
            this.dtpEinsatzDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEinsatzDatum.Location = new System.Drawing.Point(12, 41);
            this.dtpEinsatzDatum.Name = "dtpEinsatzDatum";
            this.dtpEinsatzDatum.Size = new System.Drawing.Size(220, 20);
            this.dtpEinsatzDatum.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Datum";
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(131, 153);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(101, 23);
            this.btnAbbrechen.TabIndex = 7;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // NeuerEinsatz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 198);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpEinsatzVonUhrzeit);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.dtpEinsatzBisUhrzeit);
            this.Controls.Add(this.btnNeuerEinsatz);
            this.Controls.Add(this.dtpEinsatzDatum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeuerEinsatz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NeuerEinsatz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNeuerEinsatz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEinsatzBisUhrzeit;
        private System.Windows.Forms.DateTimePicker dtpEinsatzVonUhrzeit;
        private System.Windows.Forms.DateTimePicker dtpEinsatzDatum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}