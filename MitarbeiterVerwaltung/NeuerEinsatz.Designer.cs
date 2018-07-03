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
            this.label6 = new System.Windows.Forms.Label();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.tbEinsatzDatum = new System.Windows.Forms.MaskedTextBox();
            this.tbEinsatzVonUhrzeit = new System.Windows.Forms.MaskedTextBox();
            this.tbEinsatzBisUhrzeit = new System.Windows.Forms.MaskedTextBox();
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
            // tbEinsatzDatum
            // 
            this.tbEinsatzDatum.Location = new System.Drawing.Point(12, 41);
            this.tbEinsatzDatum.Mask = "00/00/0000";
            this.tbEinsatzDatum.Name = "tbEinsatzDatum";
            this.tbEinsatzDatum.Size = new System.Drawing.Size(100, 20);
            this.tbEinsatzDatum.TabIndex = 8;
            this.tbEinsatzDatum.ValidatingType = typeof(System.DateTime);
            // 
            // tbEinsatzVonUhrzeit
            // 
            this.tbEinsatzVonUhrzeit.Location = new System.Drawing.Point(11, 106);
            this.tbEinsatzVonUhrzeit.Mask = "90:00";
            this.tbEinsatzVonUhrzeit.Name = "tbEinsatzVonUhrzeit";
            this.tbEinsatzVonUhrzeit.Size = new System.Drawing.Size(100, 20);
            this.tbEinsatzVonUhrzeit.TabIndex = 9;
            this.tbEinsatzVonUhrzeit.ValidatingType = typeof(System.DateTime);
            // 
            // tbEinsatzBisUhrzeit
            // 
            this.tbEinsatzBisUhrzeit.Location = new System.Drawing.Point(131, 106);
            this.tbEinsatzBisUhrzeit.Mask = "90:00";
            this.tbEinsatzBisUhrzeit.Name = "tbEinsatzBisUhrzeit";
            this.tbEinsatzBisUhrzeit.Size = new System.Drawing.Size(100, 20);
            this.tbEinsatzBisUhrzeit.TabIndex = 10;
            this.tbEinsatzBisUhrzeit.ValidatingType = typeof(System.DateTime);
            // 
            // NeuerEinsatz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 198);
            this.Controls.Add(this.tbEinsatzBisUhrzeit);
            this.Controls.Add(this.tbEinsatzVonUhrzeit);
            this.Controls.Add(this.tbEinsatzDatum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnNeuerEinsatz);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.MaskedTextBox tbEinsatzDatum;
        private System.Windows.Forms.MaskedTextBox tbEinsatzVonUhrzeit;
        private System.Windows.Forms.MaskedTextBox tbEinsatzBisUhrzeit;
    }
}