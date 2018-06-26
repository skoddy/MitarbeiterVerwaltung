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
    public partial class MitarbeiterVerwaltung : Form
    {
        List<Mitarbeiter> mitarbeiter = new List<Mitarbeiter>();
        List<Einsatz> einsatz = new List<Einsatz>();
        List<Fehlzeit> fehlzeit = new List<Fehlzeit>();
        Database db = new Database();

        public MitarbeiterVerwaltung()
        {
            InitializeComponent();
        }

        public void fillMitarbeiterBox()
        {
            lbMitarbeiter.Items.Clear();
            mitarbeiter = db.getPersonalList();

            foreach (Mitarbeiter m in mitarbeiter)
            {
                lbMitarbeiter.Items.Add(m.Vorname + ", " + m.Nachname);
            }
        }

        public void fillEinsatzBox(int id)
        {
            lbEinsatz.Items.Clear();
            einsatz = db.getEinsatzList(id);
            foreach (Einsatz e in einsatz)
            {
                string datum = Convert.ToDateTime(e.Datum).ToString("dd.MM");
                string von = Convert.ToDateTime(e.Von).ToString("hh:mm");
                string bis = Convert.ToDateTime(e.Bis).ToString("hh:mm");
                lbEinsatz.Items.Add($"{datum} {von} - {bis}");
            }
        }
        private List<DateTime> getDates(string s, string e)
        {
            List<DateTime> dates = new List<DateTime>();
            DateTime start = Convert.ToDateTime(s);
            DateTime end = Convert.ToDateTime(e);
            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {
                dates.Add(dt);
            }
            return dates;
        }
        public void fillFehlzeitBox(int id)
        {
            lbFehlzeit.Items.Clear();
            fehlzeit = db.getFehlzeitList(id);
            var dates = new List<DateTime>();

            foreach (Fehlzeit f in fehlzeit)
            {
                string von = Convert.ToDateTime(f.Von).ToString("dd.MM");
                string bis = Convert.ToDateTime(f.Bis).ToString("dd.MM");
                List<DateTime> allDates = getDates(von, bis);
                var countOfWorkDays = allDates.Count(day => day.IsWorkingDay());
                lbFehlzeit.Items.Add($"{von} - {bis} Fehltage: {countOfWorkDays}");
            }
        }
        private void MitarbeiterVerwaltung_Load(object sender, EventArgs e)
        {
            fillMitarbeiterBox();
        }

        private void btnNeuerMitarbeiter_Click(object sender, EventArgs e)
        {
            string vorname = tbVorname.Text;
            string nachname = tbNachname.Text;
            string gebdat = dtpGebDat.Value.Date.ToString("yyyy-MM-dd");
            int arbeitszeit = Convert.ToInt32(tbArbeitszeit.Text);
            int urlaub = Convert.ToInt32(tbAnspruchUrlaub.Text);
            MessageBox.Show(dtpGebDat.Value.Date.ToString("yyyy-MM-dd"));
            db.Insert("mitarbeiter", new Mitarbeiter(0, vorname, nachname, gebdat, arbeitszeit, urlaub));
            fillMitarbeiterBox();
        }
        private void clearForm ()
        {
            tbAnspruchUrlaub.Clear();
            tbArbeitszeit.Clear();
            tbNachname.Clear();
            tbVorname.Clear();
            dtpGebDat.Value = DateTimePicker.MinimumDateTime;
        }

        private void lbMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbMitarbeiter.SelectedIndex != -1)
            {
                int index = lbMitarbeiter.SelectedIndex;
                tbVorname.Text = mitarbeiter[index].Vorname;
                tbNachname.Text = mitarbeiter[index].Nachname;
                dtpGebDat.Value = Convert.ToDateTime(mitarbeiter[index].Gebdat);
                tbArbeitszeit.Text = mitarbeiter[index].Arbeitszeit_tag.ToString();
                tbAnspruchUrlaub.Text = mitarbeiter[index].Urlaubszeit.ToString();

                fillEinsatzBox(mitarbeiter[index].Id);
                fillFehlzeitBox(mitarbeiter[index].Id);
            }
        }

        private void btnMitarbeiterUpdate_Click(object sender, EventArgs e)
        {
            int id = lbMitarbeiter.SelectedIndex;
            string vorname = tbVorname.Text;
            string nachname = tbNachname.Text;
            string gebdat = dtpGebDat.Value.Date.ToString("yyyy-MM-dd");
            int arbeitszeit = Convert.ToInt32(tbArbeitszeit.Text);
            int urlaub = Convert.ToInt32(tbAnspruchUrlaub);
            db.Update("mitarbeiter", id, new Mitarbeiter(id, vorname, nachname, gebdat, arbeitszeit, urlaub));
            
        }

        private void btnNeuerMitarbeiterForm_Click(object sender, EventArgs e)
        {
            NeuerMitarbeiter nm = new NeuerMitarbeiter(this);
            nm.Show();
        }

        private void btnNeuerEinsatzForm_Click(object sender, EventArgs e)
        {
            int index = lbMitarbeiter.SelectedIndex;
            if (index != -1)
            {
                NeuerEinsatz ne = new NeuerEinsatz(this, mitarbeiter[index].Id, mitarbeiter[index].Nachname, mitarbeiter[index].Vorname);
                ne.ShowDialog();
            }
        }

        private void btnNeueFehlzeitForm_Click(object sender, EventArgs e)
        {
            int index = lbMitarbeiter.SelectedIndex;
            if(index != -1)
            {
                NeueFehlzeit nf = new NeueFehlzeit(this, mitarbeiter[index].Id, mitarbeiter[index].Nachname, mitarbeiter[index].Vorname);
                nf.ShowDialog();
            }
        }

        private void btnMitarbeiterUpdate_Click_1(object sender, EventArgs e)
        {
            int index = lbMitarbeiter.SelectedIndex;
            if (index != -1)
            {
                int id = mitarbeiter[index].Id;
                string vorname = tbVorname.Text;
                string nachname = tbNachname.Text;
                string gebdat = dtpGebDat.Value.Date.ToString("yyyy-MM-dd");
                int arbeitszeit = Convert.ToInt32(tbArbeitszeit.Text);
                int urlaub = Convert.ToInt32(tbAnspruchUrlaub.Text);
                db.Update("mitarbeiter", id, new Mitarbeiter(id, vorname, nachname, gebdat, arbeitszeit, urlaub));
                fillMitarbeiterBox();
                clearForm();
            }
        }

        private void refreshMitarbeiter()
        {

        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeuerMitarbeiter nm = new NeuerMitarbeiter(this);
            nm.ShowDialog();
        }
    }
}
