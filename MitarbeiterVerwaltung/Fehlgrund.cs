using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeiterVerwaltung
{
    class Fehlgrund
    {
        private int id;
        private string grund;

        public int Id { get { return id; } set { id = value; } }
        public string Grund { get { return grund; } set { grund = value; } }

        public Fehlgrund(int id, string grund)
        {
            Id = id;
            Grund = grund;
        }
    }
}
