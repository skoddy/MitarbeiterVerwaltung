namespace MitarbeiterVerwaltung
{
    partial class NeueFehlzeit
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNeueFehlzeit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFehlgrund = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFehlzeitDatumBis = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFehlzeitDatumVon = new System.Windows.Forms.DateTimePicker();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnNeueFehlzeit);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.cbFehlgrund);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.dtpFehlzeitDatumBis);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.dtpFehlzeitDatumVon);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 199);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Neue Fehlzeit";
            // 
            // btnNeueFehlzeit
            // 
            this.btnNeueFehlzeit.Location = new System.Drawing.Point(6, 170);
            this.btnNeueFehlzeit.Name = "btnNeueFehlzeit";
            this.btnNeueFehlzeit.Size = new System.Drawing.Size(200, 23);
            this.btnNeueFehlzeit.TabIndex = 6;
            this.btnNeueFehlzeit.Text = "Fehlzeit hinzufügen";
            this.btnNeueFehlzeit.UseVisualStyleBackColor = true;
            this.btnNeueFehlzeit.Click += new System.EventHandler(this.btnNeueFehlzeit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fehlgrund";
            // 
            // cbFehlgrund
            // 
            this.cbFehlgrund.FormattingEnabled = true;
            this.cbFehlgrund.Location = new System.Drawing.Point(6, 126);
            this.cbFehlgrund.Name = "cbFehlgrund";
            this.cbFehlgrund.Size = new System.Drawing.Size(121, 21);
            this.cbFehlgrund.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bis";
            // 
            // dtpFehlzeitDatumBis
            // 
            this.dtpFehlzeitDatumBis.Location = new System.Drawing.Point(6, 80);
            this.dtpFehlzeitDatumBis.Name = "dtpFehlzeitDatumBis";
            this.dtpFehlzeitDatumBis.Size = new System.Drawing.Size(200, 20);
            this.dtpFehlzeitDatumBis.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Von";
            // 
            // dtpFehlzeitDatumVon
            // 
            this.dtpFehlzeitDatumVon.Location = new System.Drawing.Point(6, 37);
            this.dtpFehlzeitDatumVon.Name = "dtpFehlzeitDatumVon";
            this.dtpFehlzeitDatumVon.Size = new System.Drawing.Size(200, 20);
            this.dtpFehlzeitDatumVon.TabIndex = 0;
            // 
            // NeueFehlzeit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 219);
            this.Controls.Add(this.groupBox6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeueFehlzeit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NeueFehlzeit";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnNeueFehlzeit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFehlgrund;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFehlzeitDatumBis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFehlzeitDatumVon;
    }
}