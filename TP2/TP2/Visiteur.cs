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
        public bool dropDechet; // if drop dechets is true, get visiteur current position, drop dechet and make the visiteur move 1 bloc up, down, left or right.

        public int x { get; set; }
        public int y { get; set; }

        public int upAI { get; set; }
        public int downAI { get; set; }
        public int leftAI { get; set; }
        public int rightAI { get; set; }

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

        public Visiteur()
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
            int randPerso = r.Next(1, 3);
            int randomGenre = r.Next(0, 2);

            genre = randomGenre == 0;

            int randPrenom;

            if (genre)
            {
                randPrenom = r.Next(0, 5);
                if (randPerso == 1)
                {
                    type = 1;
                    currentDir = listHomme1.ElementAt(0);
                }
                else
                {
                    type = 2;
                    currentDir = listHomme2.ElementAt(0);
                }
            }
            else
            {
                randPrenom = r.Next(5, 10);
                if (randPerso == 1)
                {
                    type = 3;
                    currentDir = listFemme1.ElementAt(0);
                }
                else
                {
                    type = 4;
                    currentDir = listFemme2.ElementAt(0);
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
