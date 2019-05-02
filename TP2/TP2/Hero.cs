using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TP2
{
    class Hero
    {
        public Image bas1 = TP2.Properties.Resources.bas1;
        public Image bas2 = TP2.Properties.Resources.bas2;
        public Image bas3 = TP2.Properties.Resources.bas3;

        public Image droite1 = TP2.Properties.Resources.droite1;
        public Image droite2 = TP2.Properties.Resources.droite2;

        public Image gauche1 = TP2.Properties.Resources.gauche1;
        public Image gauche2 = TP2.Properties.Resources.gauche2;

        public Image haut1 = TP2.Properties.Resources.haut1;
        public Image haut2 = TP2.Properties.Resources.haut2;
        public Image haut3 = TP2.Properties.Resources.haut3;

        public Image currentDir { get; set; }
        
        public int x { get; set; }
        public int y { get; set; }

        public Hero()
        {
            this.x = 40;
            this.y = 5;
            currentDir = bas1;
        }

        public void paintDeplacement()
        {

        }

        public void faireDeplacement()
        {
            //zone autour de l'hero dans laquelle il peut se déplacer
        }

        public void faireInterraction()
        {
            //zone d'interaction
        }
        
    }
}
