using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP2
{
    class Concierge
    {
        public int x { get; set; }
        public int y { get; set; }
        public int prixConcierge { get; set; }
        public static int nbConcierge { get; set; }
        public int tempsPasserC;

        public Image imgConc;

        public Concierge(int x2, int y2)
        {
            x = x2;
            y = y2;

            prixConcierge = 2;

            imgConc = GeneratorPersonnage.GetTile(40);

            nbConcierge++;
        }
    }
}
