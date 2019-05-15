using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP2
{
    public class Concierge
    {
        public int x { get; set; }
        public int y { get; set; }
        public int tempsPasserC;

        public Image currentDir;

        public int upAI { get; set; }
        public int downAI { get; set; }
        public int leftAI { get; set; }
        public int rightAI { get; set; }

        public List<Image> listeC = new List<Image>();

        public Concierge(int x2, int y2)
        {
            x = x2;
            y = y2;

            currentDir = GeneratorPersonnage.GetTile(40);
        }

        public void peuplerListeImg()
        {
            listeC.Add(GeneratorPersonnage.GetTile(40));
            listeC.Add(GeneratorPersonnage.GetTile(43));
            listeC.Add(GeneratorPersonnage.GetTile(49));
            listeC.Add(GeneratorPersonnage.GetTile(47));
            listeC.Add(GeneratorPersonnage.GetTile(48));
            listeC.Add(GeneratorPersonnage.GetTile(42));
            listeC.Add(GeneratorPersonnage.GetTile(45));
            listeC.Add(GeneratorPersonnage.GetTile(46));
            listeC.Add(GeneratorPersonnage.GetTile(41));
            listeC.Add(GeneratorPersonnage.GetTile(44));
        }
    }
}
