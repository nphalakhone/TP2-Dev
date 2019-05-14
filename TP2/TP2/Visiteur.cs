using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TP2
{
    enum Prenom
    {
        Motoki,
        Nick,
        Jean,
        Charlie,
        Nicolas,
        Jeanne,
        Lela,
        Christie,
        Elise,
        Charlotte
    };

    enum Nom
    {
        Smith,
        Tremblay,
        Jackson,
        Perreault,
        Rousseaux,
        Woodley,
        Shintani,
        Phalakhone,
        Jones,
        Williams
    };


    class Visiteur
    {
        public int nbVisiteur { get; set; }
        public int dechets { get; set; }
        public int tempsPasserV { get; set; }
        public string nom;
        public string prenom;
        public bool genre;
        bool dropDechet; // if drop dechets is true, get visiteur current position, drop dechet and make the visiteur move 1 bloc up, down, left or right.

        public int x { get; set; }
        public int y { get; set; }

        public Image directionDepart = null;

        public Image currentDirHomme1 = GeneratorPersonnage.GetTile(1);
        public Image currentDirHomme2 = GeneratorPersonnage.GetTile(11);
        public Image currentDirFemme1 = GeneratorPersonnage.GetTile(21);
        public Image currentDirFemme2 = GeneratorPersonnage.GetTile(31);

        // Images homme 1
        public Image premHommeBas1 = GeneratorPersonnage.GetTile(0);
        public Image premHommeBas2 = GeneratorPersonnage.GetTile(3);

        public Image premHommeDroite1 = GeneratorPersonnage.GetTile(9);
        public Image premHommeDroite2 = GeneratorPersonnage.GetTile(7);
        public Image premHommeDroite3 = GeneratorPersonnage.GetTile(8);

        public Image premHommeGauche1 = GeneratorPersonnage.GetTile(2);
        public Image premHommeGauche2 = GeneratorPersonnage.GetTile(5);
        public Image premHommeGauche3 = GeneratorPersonnage.GetTile(6);

        public Image premHommeHaut1 = GeneratorPersonnage.GetTile(1);
        public Image premHommeHaut2 = GeneratorPersonnage.GetTile(4);

        // Images homme 2
        public Image deuxHommeBas1 = GeneratorPersonnage.GetTile(10);
        public Image deuxHommeBas2 = GeneratorPersonnage.GetTile(13);

        public Image deuxHommeDroite1 = GeneratorPersonnage.GetTile(19);
        public Image deuxHommeDroite2 = GeneratorPersonnage.GetTile(17);
        public Image deuxHommeDroite3 = GeneratorPersonnage.GetTile(18);

        public Image deuxHommeGauche1 = GeneratorPersonnage.GetTile(12);
        public Image deuxHommeGauche2 = GeneratorPersonnage.GetTile(15);
        public Image deuxHommeGauche3 = GeneratorPersonnage.GetTile(16);

        public Image deuxHommeHaut1 = GeneratorPersonnage.GetTile(11);
        public Image deuxHommeHaut2 = GeneratorPersonnage.GetTile(14);

        // Images femme 1 
        public Image premFemmeBas1 = GeneratorPersonnage.GetTile(20);
        public Image premFemmeBas2 = GeneratorPersonnage.GetTile(23);

        public Image premFemmeDroite1 = GeneratorPersonnage.GetTile(29);
        public Image premFemmeDroite2 = GeneratorPersonnage.GetTile(27);
        public Image premFemmeDroite3 = GeneratorPersonnage.GetTile(28);

        public Image premFemmeGauche1 = GeneratorPersonnage.GetTile(22);
        public Image premFemmeGauche2 = GeneratorPersonnage.GetTile(25);
        public Image premFemmeGauche3 = GeneratorPersonnage.GetTile(26);

        public Image premFemmeHaut1 = GeneratorPersonnage.GetTile(21);
        public Image premFemmeHaut2 = GeneratorPersonnage.GetTile(24);

        // Images femme 2
        public Image deuxFemmeBas1 = GeneratorPersonnage.GetTile(30);
        public Image deuxFemmeBas2 = GeneratorPersonnage.GetTile(33);

        public Image deuxFemmeDroite1 = GeneratorPersonnage.GetTile(39);
        public Image deuxFemmeDroite2 = GeneratorPersonnage.GetTile(37);
        public Image deuxFemmeDroite3 = GeneratorPersonnage.GetTile(38);

        public Image deuxFemmeGauche1 = GeneratorPersonnage.GetTile(32);
        public Image deuxFemmeGauche2 = GeneratorPersonnage.GetTile(35);
        public Image deuxFemmeGauche3 = GeneratorPersonnage.GetTile(36);

        public Image deuxFemmeHaut1 = GeneratorPersonnage.GetTile(31);
        public Image deuxFemmeHaut2 = GeneratorPersonnage.GetTile(34);

        public Visiteur(/*int x2, int y2*/)
        {
            this.x = 19;
            this.y = 24;

            nbVisiteur = 0;
            dechets = 0;

            tempsPasserV = 0;

            Random r = new Random();
            int randNom = r.Next(0, 10);
            int randPerso = r.Next(1,2);
            int randomGenre = r.Next(0, 1);

            if (randomGenre == 0)
            {
                genre = true;
            }
            else
            {
                genre = false;
            }

            int randPrenom;

            if (genre)
            {
                randPrenom = r.Next(0, 5);
                if (randPerso == 1)
                {
                    directionDepart = currentDirHomme1;
                }
                else
                {
                    directionDepart = currentDirHomme2;
                }
            }
            else
            {
                randPrenom = r.Next(6, 10);
                if (randPerso == 1)
                {
                    directionDepart = currentDirFemme1;
                }
                else
                {
                    directionDepart = currentDirFemme2;
                }
            }

            prenom = Enum.GetName(typeof(Prenom), randPrenom);
            nom = Enum.GetName(typeof(Nom), randNom);
        }
    }
}
