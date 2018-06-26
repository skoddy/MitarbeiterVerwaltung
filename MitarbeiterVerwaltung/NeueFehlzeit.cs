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
    public partial class NeueFehlzeit : Form
    {
        Database db = new Database();
        List<Fehlgrund> fehlgrund = new List<Fehlgrund>();
        MitarbeiterVerwaltung MV;
        private int mitarbeiterId;
        private string mitarbeiterVorame;
        private string mitarbeiterNachname;
        public NeueFehlzeit(MitarbeiterVerwaltung mv, int mitarbeiterId, string mitarbeiterVorame, string mitarbeiterNachname)
        {
            MV = mv;
            this.mitarbeiterId = mitarbeiterId;
            this.mitarbeiterVorame = mitarbeiterVorame;
            this.mitarbeiterNachname = mitarbeiterNachname;
            InitializeComponent();
            this.Text = $"Neue Fehlzeit {mitarbeiterNachname} {mitarbeiterVorame}";
            fillFehlgrund();
        }

        private void btnNeueFehlzeit_Click(object sender, EventArgs e)
        {

            string von = dtpFehlzeitDatumVon.Value.ToString("yyyy-MM-dd");
            string bis = dtpFehlzeitDatumBis.Value.ToString("yyyy-MM-dd");
            int index = cbFehlgrund.SelectedIndex;
            int grund_id = fehlgrund.Find(grund => grund.Id == fehlgrund[index].Id).Id;
            DateTime d1 = dtpFehlzeitDatumVon.Value.Date;
            DateTime d2 = dtpFehlzeitDatumBis.Value.Date;
            int fehltage = Convert.ToInt32((d1 - d2).TotalDays);
            fehltage = (fehltage * -1) + 1;
            db.Insert("fehlzeit", new Fehlzeit(0, mitarbeiterId, von, bis, grund_id, fehltage ));
            MV.fillFehlzeitBox(mitarbeiterId);
            this.Close();
        }

        private void fillFehlgrund()
        {
            fehlgrund = db.getFehlgrund();
            foreach (Fehlgrund grund in fehlgrund)
            {
                cbFehlgrund.Items.Add(grund.Grund);
            }
        }
    }
}
