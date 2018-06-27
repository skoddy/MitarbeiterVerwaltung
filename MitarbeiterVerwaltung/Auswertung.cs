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
    public partial class Auswertung : Form
    {
        MitarbeiterVerwaltung MV;
        Database db = new Database();
        List<AuswertungFehlzeit> awFehlzeiten;
        bool insgesamt = false;
        public Auswertung(MitarbeiterVerwaltung mv)
        {
            MV = mv;
            InitializeComponent();
            fillGridFehlzeiten(insgesamt);
        }

        private void fillGridFehlzeiten(bool insgesamt)
        {
            awFehlzeiten = db.getAuswertungFehlzeiten(insgesamt);
            var bindingList = new BindingList<AuswertungFehlzeit>(awFehlzeiten);
            var source = new BindingSource(bindingList, null);
            dgvFehlzeiten.DataSource = source;
            dgvFehlzeiten.AutoResizeColumnHeadersHeight();
            dgvFehlzeiten.AutoResizeRows( DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void fillGridEinsatz()
        {

        }

        private void chbInsgesamt_CheckedChanged(object sender, EventArgs e)
        {
            insgesamt = !insgesamt;
            fillGridFehlzeiten(insgesamt);
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            if(cbJahr.SelectedIndex != -1)
            {
                fillGridFehlzeiten(insgesamt);
            }
        }
    }
}
