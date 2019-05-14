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

        public Image imgConc;



        public Concierge()
        {
            x = 0;
            y = 0;

            prixConcierge = 2;

            imgConc = GenereatorPersonnage.GetTile(40);
        }
    }
}
