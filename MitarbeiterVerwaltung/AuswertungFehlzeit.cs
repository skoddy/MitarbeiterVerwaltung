using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeiterVerwaltung
{
    class AuswertungFehlzeit
    {
        private string vorname;
        private string nachname;
        private string fehlgrund;
        private int fehltage;

        public string Vorname { get { return vorname; } set { vorname = value; } }
        public string Nachname { get { return nachname; } set { nachname = value; } }
        public string Fehlgrund { get { return fehlgrund; } set { fehlgrund = value; } }
        public int Fehltage { get { return fehltage; } set { fehltage = value; } }

        public AuswertungFehlzeit (string vorname, string nachname, string fehlgrund, int fehltage)
        {
            Vorname = vorname;
            Nachname = nachname;
            Fehlgrund = fehlgrund;
            Fehltage = fehltage;
        }
        public AuswertungFehlzeit(string vorname, string nachname, int fehltage)
        {
            Vorname = vorname;
            Nachname = nachname;
            Fehltage = fehltage;
        }

    }
}
