using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeiterVerwaltung
{
    class Einsatz
    {
        private int id;
        private int ma_id;
        private string datum;
        private string von;
        private string bis;

        public int Id { get { return id; } set { id = value; } }
        public int Ma_id { get { return ma_id; } set { ma_id = value; } }
        public string Datum { get { return datum; } set { datum = value; } }
        public string Von { get { return von; } set { von = value; } }
        public string Bis { get { return bis; } set { bis = value; } }

        public Einsatz(int id, int ma_id, string datum, string von, string bis)
        {
            Id = id;
            Ma_id = ma_id;
            Datum = datum;
            Von = von;
            Bis = bis;
        }
    }
}
