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


    public class Visiteur
    {
        public int nbVisiteur { get; set; }
        public int dechets { get; set; }
        public int tempsPasserV { get; set; }
        public string nom;
        public string prenom;
        public bool genre;
        public int type;
        bool dropDechet; // if drop dechets is true, get visiteur current position, drop dechet and make the visiteur move 1 bloc up, down, left or right.

        public int x { get; set; }
        public int y { get; set; }

        public int upAI { get; set; }
        public int downAI { get; set; }
        public int leftAI { get; set; }
        public int rightAI { get; set; }

        public Image directionDepart;

        public Image currentDir;

        public List<Image> listHomme1 = new List<Image>();
        public List<Image> listHomme2 = new List<Image>();
        public List<Image> listFemme1 = new List<Image>();
        public List<Image> listFemme2 = new List<Image>();

        //0 = Bas1
        //1 = Bas2
        //2 = Droite1
        //3 = Droite2
        //4 = Droite3
        //5 = Gauche1
        //6 = Gauche2
        //7 = Gauche3
        //8 = Haut1
        //9 = Haut2

        //public Image currentDirHomme1 = GeneratorPersonnage.GetTile(1);
        //public Image currentDirHomme2 = GeneratorPersonnage.GetTile(11);
        //public Image currentDirFemme1 = GeneratorPersonnage.GetTile(21);
        //public Image currentDirFemme2 = GeneratorPersonnage.GetTile(31);

        
        //// Images homme 1
        
        //public Image premHommeBas1 = GeneratorPersonnage.GetTile(0);
        //public Image premHommeBas2 = GeneratorPersonnage.GetTile(3);

        //public Image premHommeDroite1 = GeneratorPersonnage.GetTile(9);
        //public Image premHommeDroite2 = GeneratorPersonnage.GetTile(7);
        //public Image premHommeDroite3 = GeneratorPersonnage.GetTile(8);

        //public Image premHommeGauche1 = GeneratorPersonnage.GetTile(2);
        //public Image premHommeGauche2 = GeneratorPersonnage.GetTile(5);
        //public Image premHommeGauche3 = GeneratorPersonnage.GetTile(6);

        //public Image premHommeHaut1 = GeneratorPersonnage.GetTile(1);
        //public Image premHommeHaut2 = GeneratorPersonnage.GetTile(4);

        //// Images homme 2
        //public Image deuxHommeBas1 = GeneratorPersonnage.GetTile(10);
        //public Image deuxHommeBas2 = GeneratorPersonnage.GetTile(13);

        //public Image deuxHommeDroite1 = GeneratorPersonnage.GetTile(19);
        //public Image deuxHommeDroite2 = GeneratorPersonnage.GetTile(17);
        //public Image deuxHommeDroite3 = GeneratorPersonnage.GetTile(18);

        //public Image deuxHommeGauche1 = GeneratorPersonnage.GetTile(12);
        //public Image deuxHommeGauche2 = GeneratorPersonnage.GetTile(15);
        //public Image deuxHommeGauche3 = GeneratorPersonnage.GetTile(16);

        //public Image deuxHommeHaut1 = GeneratorPersonnage.GetTile(11);
        //public Image deuxHommeHaut2 = GeneratorPersonnage.GetTile(14);

        //// Images femme 1 
        //public Image premFemmeBas1 = GeneratorPersonnage.GetTile(20);
        //public Image premFemmeBas2 = GeneratorPersonnage.GetTile(23);

        //public Image premFemmeDroite1 = GeneratorPersonnage.GetTile(29);
        //public Image premFemmeDroite2 = GeneratorPersonnage.GetTile(27);
        //public Image premFemmeDroite3 = GeneratorPersonnage.GetTile(28);

        //public Image premFemmeGauche1 = GeneratorPersonnage.GetTile(22);
        //public Image premFemmeGauche2 = GeneratorPersonnage.GetTile(25);
        //public Image premFemmeGauche3 = GeneratorPersonnage.GetTile(26);

        //public Image premFemmeHaut1 = GeneratorPersonnage.GetTile(21);
        //public Image premFemmeHaut2 = GeneratorPersonnage.GetTile(24);

        //// Images femme 2
        //public Image deuxFemmeBas1 = GeneratorPersonnage.GetTile(30);
        //public Image deuxFemmeBas2 = GeneratorPersonnage.GetTile(33);

        //public Image deuxFemmeDroite1 = GeneratorPersonnage.GetTile(39);
        //public Image deuxFemmeDroite2 = GeneratorPersonnage.GetTile(37);
        //public Image deuxFemmeDroite3 = GeneratorPersonnage.GetTile(38);

        //public Image deuxFemmeGauche1 = GeneratorPersonnage.GetTile(32);
        //public Image deuxFemmeGauche2 = GeneratorPersonnage.GetTile(35);
        //public Image deuxFemmeGauche3 = GeneratorPersonnage.GetTile(36);

        //public Image deuxFemmeHaut1 = GeneratorPersonnage.GetTile(31);
        //public Image deuxFemmeHaut2 = GeneratorPersonnage.GetTile(34);

        public Visiteur(/*int x2, int y2*/)
        {
            peuplerListPersonnages();
            upAI = 0;
            downAI = 0;
            leftAI = 0;
            rightAI = 0;

            this.x = 19;
            this.y = 24;

            nbVisiteur = 0;
            dechets = 0;

            tempsPasserV = 0;

            Random r = new Random();
            int randNom = r.Next(0, 10);
            int randPerso = r.Next(1, 2);
            int randomGenre = r.Next(0, 1);

            genre = randomGenre == 0;

            int randPrenom;

            if (genre)
            {
                randPrenom = r.Next(0, 5);
                if (randPerso == 1)
                {
                    type = 1;
                    directionDepart = listHomme1.ElementAt(0);
                }
                else
                {
                    type = 2;
                    directionDepart = listHomme2.ElementAt(0);
                }
            }
            else
            {
                randPrenom = r.Next(6, 10);
                if (randPerso == 1)
                {
                    type = 3;
                    directionDepart = listFemme1.ElementAt(0);
                }
                else
                {
                    type = 4;
                    directionDepart = listFemme2.ElementAt(0);
                }
            }

            prenom = Enum.GetName(typeof(Prenom), randPrenom);
            nom = Enum.GetName(typeof(Nom), randNom);                                  
        }

        private void peuplerListPersonnages()
        {
            listHomme1.Add(GeneratorPersonnage.GetTile(0));
            listHomme1.Add(GeneratorPersonnage.GetTile(3));
            listHomme1.Add(GeneratorPersonnage.GetTile(9));
            listHomme1.Add(GeneratorPersonnage.GetTile(7));
            listHomme1.Add(GeneratorPersonnage.GetTile(8));
            listHomme1.Add(GeneratorPersonnage.GetTile(2));
            listHomme1.Add(GeneratorPersonnage.GetTile(5));
            listHomme1.Add(GeneratorPersonnage.GetTile(6));
            listHomme1.Add(GeneratorPersonnage.GetTile(1));
            listHomme1.Add(GeneratorPersonnage.GetTile(4));

            listHomme2.Add(GeneratorPersonnage.GetTile(10));
            listHomme2.Add(GeneratorPersonnage.GetTile(13));
            listHomme2.Add(GeneratorPersonnage.GetTile(19));
            listHomme2.Add(GeneratorPersonnage.GetTile(17));
            listHomme2.Add(GeneratorPersonnage.GetTile(18));
            listHomme2.Add(GeneratorPersonnage.GetTile(12));
            listHomme2.Add(GeneratorPersonnage.GetTile(15));
            listHomme2.Add(GeneratorPersonnage.GetTile(16));
            listHomme2.Add(GeneratorPersonnage.GetTile(11));
            listHomme2.Add(GeneratorPersonnage.GetTile(14));

            listFemme1.Add(GeneratorPersonnage.GetTile(20));
            listFemme1.Add(GeneratorPersonnage.GetTile(23));
            listFemme1.Add(GeneratorPersonnage.GetTile(29));
            listFemme1.Add(GeneratorPersonnage.GetTile(27));
            listFemme1.Add(GeneratorPersonnage.GetTile(28));
            listFemme1.Add(GeneratorPersonnage.GetTile(22));
            listFemme1.Add(GeneratorPersonnage.GetTile(25));
            listFemme1.Add(GeneratorPersonnage.GetTile(26));
            listFemme1.Add(GeneratorPersonnage.GetTile(21));
            listFemme1.Add(GeneratorPersonnage.GetTile(24));

            listFemme2.Add(GeneratorPersonnage.GetTile(30));
            listFemme2.Add(GeneratorPersonnage.GetTile(33));
            listFemme2.Add(GeneratorPersonnage.GetTile(39));
            listFemme2.Add(GeneratorPersonnage.GetTile(37));
            listFemme2.Add(GeneratorPersonnage.GetTile(38));
            listFemme2.Add(GeneratorPersonnage.GetTile(32));
            listFemme2.Add(GeneratorPersonnage.GetTile(35));
            listFemme2.Add(GeneratorPersonnage.GetTile(36));
            listFemme2.Add(GeneratorPersonnage.GetTile(31));
            listFemme2.Add(GeneratorPersonnage.GetTile(34));
        }
    }
}
