using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TP2
{
    class Visiteur
    {
        public int nbVisiteur { get; set; }
        public int dechets { get; set; }
        int tempsPasser;
        bool? genre;
        bool? dropDechet; // if drop dechets is true, get visiteur current position, drop dechet and make the visiteur move 1 bloc up, down, left or right.

        public int x { get; set; }
        public int y { get; set; }

        public Image currentDirHomme1 = GenereatorPersonnage.GetTile(1);
        public Image currentDirHomme2 = GenereatorPersonnage.GetTile(11);
        public Image currentDirFemme1 = GenereatorPersonnage.GetTile(21);
        public Image currentDirFemme2 = GenereatorPersonnage.GetTile(31);

        // Images homme 1
        public Image premHommeBas1 = GenereatorPersonnage.GetTile(0);
        public Image premHommeBas2 = GenereatorPersonnage.GetTile(3);
        
        public Image premHommeDroite1 = GenereatorPersonnage.GetTile(9);
        public Image premHommeDroite2 = GenereatorPersonnage.GetTile(7);
        public Image premHommeDroite3 = GenereatorPersonnage.GetTile(8);

        public Image premHommeGauche1 = GenereatorPersonnage.GetTile(2);
        public Image premHommeGauche2 = GenereatorPersonnage.GetTile(5);
        public Image premHommeGauche3 = GenereatorPersonnage.GetTile(6);

        public Image premHommeHaut1 = GenereatorPersonnage.GetTile(1);
        public Image premHommeHaut2 = GenereatorPersonnage.GetTile(4);

        // Images homme 2
        public Image deuxHommeBas1 = GenereatorPersonnage.GetTile(10);
        public Image deuxHommeBas2 = GenereatorPersonnage.GetTile(13);

        public Image deuxHommeDroite1 = GenereatorPersonnage.GetTile(19);
        public Image deuxHommeDroite2 = GenereatorPersonnage.GetTile(17);
        public Image deuxHommeDroite3 = GenereatorPersonnage.GetTile(18);

        public Image deuxHommeGauche1 = GenereatorPersonnage.GetTile(12);
        public Image deuxHommeGauche2 = GenereatorPersonnage.GetTile(15);
        public Image deuxHommeGauche3 = GenereatorPersonnage.GetTile(16);

        public Image deuxHommeHaut1 = GenereatorPersonnage.GetTile(11);
        public Image deuxHommeHaut2 = GenereatorPersonnage.GetTile(14);

        // Images femme 1 
        public Image premFemmeBas1 = GenereatorPersonnage.GetTile(20);
        public Image premFemmeBas2 = GenereatorPersonnage.GetTile(23);

        public Image premFemmeDroite1 = GenereatorPersonnage.GetTile(29);
        public Image premFemmeDroite2 = GenereatorPersonnage.GetTile(27);
        public Image premFemmeDroite3 = GenereatorPersonnage.GetTile(28);

        public Image premFemmeGauche1 = GenereatorPersonnage.GetTile(22);
        public Image premFemmeGauche2 = GenereatorPersonnage.GetTile(25);
        public Image premFemmeGauche3 = GenereatorPersonnage.GetTile(26);

        public Image premFemmeHaut1 = GenereatorPersonnage.GetTile(21);
        public Image premFemmeHaut2 = GenereatorPersonnage.GetTile(24);

        // Images femme 2
        public Image deuxFemmeBas1 = GenereatorPersonnage.GetTile(30);
        public Image deuxFemmeBas2 = GenereatorPersonnage.GetTile(33);

        public Image deuxFemmeDroite1 = GenereatorPersonnage.GetTile(39);
        public Image deuxFemmeDroite2 = GenereatorPersonnage.GetTile(37);
        public Image deuxFemmeDroite3 = GenereatorPersonnage.GetTile(38);

        public Image deuxFemmeGauche1 = GenereatorPersonnage.GetTile(32);
        public Image deuxFemmeGauche2 = GenereatorPersonnage.GetTile(35);
        public Image deuxFemmeGauche3 = GenereatorPersonnage.GetTile(36);

        public Image deuxFemmeHaut1 = GenereatorPersonnage.GetTile(31);
        public Image deuxFemmeHaut2 = GenereatorPersonnage.GetTile(34);

        public Visiteur()
        {
            this.x = 19;
            this.y = 24;

            nbVisiteur = 0;
            dechets = 0;
        }

        public Visiteur(bool genre, Image profil, string nom, string prenom, int nbJourPasser)
        {
            
        }
    }
}
