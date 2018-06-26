using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeiterVerwaltung
{
    class Mitarbeiter
    {
        private int id;
        private string vorname;
        private string nachname;
        private string gebdat;
        private int arbeitszeit_tag;
        private int urlaubszeit;

        // private Einsatz[] einsatz;

        public int Id { get { return id; } set { id = value; } }
        public string Vorname { get { return vorname; } set { vorname = value; } }
        public string Nachname { get { return nachname; } set { nachname = value; } }
        public string Gebdat { get { return gebdat; } set { gebdat = value; } }
        public int Arbeitszeit_tag { get { return arbeitszeit_tag; } set { arbeitszeit_tag = value; } }
        public int Urlaubszeit { get { return urlaubszeit; } set { urlaubszeit = value; } }

        public Mitarbeiter (int id, string vorname, string nachname, string gebdat, int arbeitszeit_tag, int urlaubszeit)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Gebdat = gebdat;
            Arbeitszeit_tag = arbeitszeit_tag;
            Urlaubszeit = urlaubszeit;
        }
    }
}
