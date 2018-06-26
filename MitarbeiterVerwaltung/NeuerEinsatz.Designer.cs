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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNeuerEinsatz = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEinsatzBisUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.dtpEinsatzVonUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.dtpEinsatzDatum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNeuerEinsatz);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.dtpEinsatzBisUhrzeit);
            this.groupBox4.Controls.Add(this.dtpEinsatzVonUhrzeit);
            this.groupBox4.Controls.Add(this.dtpEinsatzDatum);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 199);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Neuer Einsatz";
            // 
            // btnNeuerEinsatz
            // 
            this.btnNeuerEinsatz.Location = new System.Drawing.Point(6, 170);
            this.btnNeuerEinsatz.Name = "btnNeuerEinsatz";
            this.btnNeuerEinsatz.Size = new System.Drawing.Size(205, 23);
            this.btnNeuerEinsatz.TabIndex = 6;
            this.btnNeuerEinsatz.Text = "Einsatz hinzufügen";
            this.btnNeuerEinsatz.UseVisualStyleBackColor = true;
            this.btnNeuerEinsatz.Click += new System.EventHandler(this.btnNeuerEinsatz_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bis (Uhrzeit)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Von (Uhrzeit)";
            // 
            // dtpEinsatzBisUhrzeit
            // 
            this.dtpEinsatzBisUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEinsatzBisUhrzeit.Location = new System.Drawing.Point(6, 123);
            this.dtpEinsatzBisUhrzeit.Name = "dtpEinsatzBisUhrzeit";
            this.dtpEinsatzBisUhrzeit.ShowUpDown = true;
            this.dtpEinsatzBisUhrzeit.Size = new System.Drawing.Size(200, 20);
            this.dtpEinsatzBisUhrzeit.TabIndex = 3;
            // 
            // dtpEinsatzVonUhrzeit
            // 
            this.dtpEinsatzVonUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEinsatzVonUhrzeit.Location = new System.Drawing.Point(7, 79);
            this.dtpEinsatzVonUhrzeit.Name = "dtpEinsatzVonUhrzeit";
            this.dtpEinsatzVonUhrzeit.ShowUpDown = true;
            this.dtpEinsatzVonUhrzeit.Size = new System.Drawing.Size(200, 20);
            this.dtpEinsatzVonUhrzeit.TabIndex = 2;
            this.dtpEinsatzVonUhrzeit.Value = new System.DateTime(2018, 6, 26, 11, 47, 0, 0);
            // 
            // dtpEinsatzDatum
            // 
            this.dtpEinsatzDatum.Location = new System.Drawing.Point(7, 37);
            this.dtpEinsatzDatum.Name = "dtpEinsatzDatum";
            this.dtpEinsatzDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpEinsatzDatum.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Datum";
            // 
            // NeuerEinsatz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 223);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeuerEinsatz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NeuerEinsatz";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNeuerEinsatz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEinsatzBisUhrzeit;
        private System.Windows.Forms.DateTimePicker dtpEinsatzVonUhrzeit;
        private System.Windows.Forms.DateTimePicker dtpEinsatzDatum;
        private System.Windows.Forms.Label label6;
    }
}