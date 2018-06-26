using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeiterVerwaltung
{
    class Fehlzeit
    {
        private int id;
        private int ma_id;
        private string von;
        private string bis;
        private int grund_id;
        private int fehltage;

        public int Id { get { return id; } set { id = value; } }
        public int Ma_id { get { return ma_id; } set { ma_id = value; } }
        public string Von { get { return von; } set { von = value; } }
        public string Bis { get { return bis; } set { bis = value; } }
        public int Grund_id { get { return grund_id; } set { grund_id = value; } }
        public int Fehltage { get { return fehltage; } set { fehltage = value; } }

        public Fehlzeit (int id, int ma_id, string von, string bis, int grund_id, int fehltage)
        {
            Id = id;
            Ma_id = ma_id;
            Von = von;
            Bis = bis;
            Grund_id = grund_id;
            Fehltage = fehltage;
        }
    }
}
