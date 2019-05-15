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

        public bool[,] bmInteractionC = new bool[43, 25];

        public List<Image> listeC = new List<Image>();

        public Concierge(int x2, int y2)
        {
            x = x2;
            y = y2;

            currentDir = GeneratorPersonnage.GetTile(40);

            peuplerListeImg();
        }

        public void peuplerListeImg()
        {
            listeC.Add(GeneratorPersonnage.GetTile(40)); //0
            listeC.Add(GeneratorPersonnage.GetTile(43)); //1
            listeC.Add(GeneratorPersonnage.GetTile(49)); //2
            listeC.Add(GeneratorPersonnage.GetTile(47)); //3
            listeC.Add(GeneratorPersonnage.GetTile(48)); //4
            listeC.Add(GeneratorPersonnage.GetTile(42)); //5
            listeC.Add(GeneratorPersonnage.GetTile(45)); //6
            listeC.Add(GeneratorPersonnage.GetTile(46)); //7
            listeC.Add(GeneratorPersonnage.GetTile(41)); //8
            listeC.Add(GeneratorPersonnage.GetTile(44)); //9
        }
    }
}
