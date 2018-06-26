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
    public partial class NeuerMitarbeiter : Form
    {
        Database db = new Database();
        MitarbeiterVerwaltung MV;
        public NeuerMitarbeiter(MitarbeiterVerwaltung mv)
        {
            InitializeComponent();
            MV = mv;
        }

        private void btnNeuerMitarbeiter_Click(object sender, EventArgs e)
        {
            string vorname = tbVorname.Text;
            string nachname = tbNachname.Text;
            string gebdat = dtpGebDat.Value.Date.ToString("yyyy-MM-dd");
            int arbeitszeit = Convert.ToInt32(tbArbeitszeit.Text);
            int urlaub = Convert.ToInt32(tbAnspruchUrlaub.Text);
            db.Insert("mitarbeiter", new Mitarbeiter(0, vorname, nachname, gebdat, arbeitszeit, urlaub));
            MV.fillMitarbeiterBox();
            this.Close();
        }
    }
}
