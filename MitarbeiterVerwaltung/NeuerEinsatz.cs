using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitarbeiterVerwaltung
{
    public partial class NeuerEinsatz : Form
    {
        Database db = new Database();
        MitarbeiterVerwaltung MV;
        private int mitarbeiterId;
        private string mitarbeiterVorame;
        private string mitarbeiterNachname;
        public NeuerEinsatz(MitarbeiterVerwaltung mv, int mitarbeiterId, string mitarbeiterVorame, string mitarbeiterNachname)
        {
            MV = mv;
            this.mitarbeiterId = mitarbeiterId;
            this.mitarbeiterVorame = mitarbeiterVorame;
            this.mitarbeiterNachname = mitarbeiterNachname;
            InitializeComponent();
            this.Text = $"Neuer Einsatz {mitarbeiterNachname} {mitarbeiterVorame}";
        }

        private void btnNeuerEinsatz_Click(object sender, EventArgs e)
        {
            string datum = Convert.ToDateTime(tbEinsatzDatum.Text).ToString("yyyy-MM-dd");
            string von = Convert.ToDateTime(tbEinsatzVonUhrzeit.Text).ToString("HH:mm");
            string bis = Convert.ToDateTime(tbEinsatzBisUhrzeit.Text).ToString("HH:mm");
            db.Insert("einsatz", new Einsatz(0, mitarbeiterId, datum, von, bis));
            MV.fillEinsatzBox(mitarbeiterId);
            this.Close();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
