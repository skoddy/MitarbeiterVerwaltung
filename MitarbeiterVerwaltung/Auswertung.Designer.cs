namespace MitarbeiterVerwaltung
{
    partial class Auswertung
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
            this.dgvFehlzeiten = new System.Windows.Forms.DataGridView();
            this.cbJahr = new System.Windows.Forms.ComboBox();
            this.cbMonat = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chbInsgesamt = new System.Windows.Forms.CheckBox();
            this.btnSortByDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFehlzeiten)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFehlzeiten
            // 
            this.dgvFehlzeiten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFehlzeiten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFehlzeiten.Location = new System.Drawing.Point(3, 3);
            this.dgvFehlzeiten.Name = "dgvFehlzeiten";
            this.dgvFehlzeiten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvFehlzeiten.Size = new System.Drawing.Size(429, 543);
            this.dgvFehlzeiten.TabIndex = 5;
            // 
            // cbJahr
            // 
            this.cbJahr.FormattingEnabled = true;
            this.cbJahr.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016"});
            this.cbJahr.Location = new System.Drawing.Point(176, 13);
            this.cbJahr.Name = "cbJahr";
            this.cbJahr.Size = new System.Drawing.Size(121, 21);
            this.cbJahr.TabIndex = 6;
            this.cbJahr.Text = "Jahr";
            // 
            // cbMonat
            // 
            this.cbMonat.FormattingEnabled = true;
            this.cbMonat.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "März",
            "April",
            "Mai",
            "Juni",
            "Juli",
            "August",
            "September",
            "Oktober",
            "November",
            "Dezember"});
            this.cbMonat.Location = new System.Drawing.Point(49, 13);
            this.cbMonat.Name = "cbMonat";
            this.cbMonat.Size = new System.Drawing.Size(121, 21);
            this.cbMonat.TabIndex = 7;
            this.cbMonat.Text = "Monat";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 575);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFehlzeiten);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(435, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fehlzeiten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(435, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Einsätze";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 543);
            this.dataGridView1.TabIndex = 0;
            // 
            // chbInsgesamt
            // 
            this.chbInsgesamt.AutoSize = true;
            this.chbInsgesamt.Location = new System.Drawing.Point(49, 41);
            this.chbInsgesamt.Name = "chbInsgesamt";
            this.chbInsgesamt.Size = new System.Drawing.Size(73, 17);
            this.chbInsgesamt.TabIndex = 9;
            this.chbInsgesamt.Text = "insgesamt";
            this.chbInsgesamt.UseVisualStyleBackColor = true;
            this.chbInsgesamt.CheckedChanged += new System.EventHandler(this.chbInsgesamt_CheckedChanged);
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Location = new System.Drawing.Point(303, 13);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(75, 23);
            this.btnSortByDate.TabIndex = 10;
            this.btnSortByDate.Text = "Suchen";
            this.btnSortByDate.UseVisualStyleBackColor = true;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // Auswertung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 644);
            this.Controls.Add(this.btnSortByDate);
            this.Controls.Add(this.chbInsgesamt);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbMonat);
            this.Controls.Add(this.cbJahr);
            this.Name = "Auswertung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auswertung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFehlzeiten)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFehlzeiten;
        private System.Windows.Forms.ComboBox cbJahr;
        private System.Windows.Forms.ComboBox cbMonat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chbInsgesamt;
        private System.Windows.Forms.Button btnSortByDate;
    }
}