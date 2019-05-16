using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTilesetZoo;

namespace TP2
{
    public partial class Map : UserControl
    {
        Bitmap[,] bmMap = new Bitmap[43, 25];
        Bitmap[,] bmFence = new Bitmap[14, 7];
        Bitmap[,] bmHouse = new Bitmap[4, 5];
        Bitmap[,] bmWell = new Bitmap[3, 3];
        Bitmap[,] bmAnimaux = new Bitmap[43, 25];
        Bitmap[,] bmVisiteurEtConcierge = new Bitmap[43, 25];
        Bitmap[] bmFenceVert = new Bitmap[25];
        Bitmap[] bmBenchH = new Bitmap[3];
        Bitmap[] bmBenchV = new Bitmap[2];
        Bitmap[] bmApple = new Bitmap[2];

        public static bool[,] bmInteraction = new bool[43, 25];

        bool[,] interieurEnclos = new bool[43, 25];

        int[,] numEnclos = new int[43, 25];
        bool[,] noMouvJanitor = new bool[43, 25];
        bool[,] noMouvAnimal = new bool[43, 25];
        bool[,] noMouvCoord = new bool[43, 25];
        bool[,] noMouvCoordAI = new bool[43, 25];
        bool[,] noMouvAi = new bool[43, 25];
        bool[,] noMouvTrash = new bool[43, 25];
        Animaux?[,] enclosAnimal = new Animaux?[43, 25];

        public int sizeListeAnimaux { get; set; }
        public int sizeListeVisiteur { get; set; }

        public List<Animal> listeAnimaux = new List<Animal>();
        public List<Concierge> listeConcierge = new List<Concierge>();
        public List<Visiteur> listeVisiteur = new List<Visiteur>();
        public List<Point> listeTrash = new List<Point>();

        int xSortie = 19;
        int ySortie = 0;

        Hero h = new Hero();

        int up = 0;
        int down = 0;
        int left = 0;
        int right = 0;

        public int placeListeAnimal { get; set; }

        public int placeListeVisiteur { get; set; }

        public bool enableBuyAnimals { get; set; }

        public string animalChoisi { get; set; }

        public bool conciergeChoisi { get; set; }

        public bool placedAnimal { get; set; }

        public int prixAnimal { get; set; }

        public bool heroOnlyArea { get; set; }

        public Map()
        {
            DoubleBuffered = true;
            InitializeComponent();
            creerInterface();

            heroOnlyArea = true;

            placeListeAnimal = 999;
            placeListeVisiteur = 999;
        }

        private void creerInterface()
        {
            peuplerBitmapMap();
            peuplerBitmapFence();
            peuplerBitmapHouse();
            peuplerBitmapWell();
            peuplerBitmapFenceUp();
            peuplerBitmapBenchUp();
            peuplerBitmapBenchSide();
            peuplerBitmapApple();

            setTables();
        }

        private void setTables()
        {
            for (int i = 0; i < noMouvCoord.GetLength(0); i++)
            {
                for (int j = 0; j < noMouvCoord.GetLength(1); j++)
                {
                    noMouvCoord[i, j] = true;
                    noMouvCoordAI[i, j] = true;
                    interieurEnclos[i, j] = false;
                    bmInteraction[i, j] = false;
                    noMouvAnimal[i, j] = true;
                    noMouvJanitor[i, j] = true;
                    enclosAnimal[i, j] = null;
                    noMouvAi[i, j] = true;
                    numEnclos[i, j] = 0;
                    noMouvTrash[i, j] = true;
                }
            }
        }

        private void peuplerBitmapMap()
        {
            for (int i = 0; i < bmMap.GetLength(0); i++)
            {
                for (int j = 0; j < bmMap.GetLength(1); j++)
                {
                    if ((i == 2 && (j > 1 && j < 23)) || i == 19 || (i == 36 && (j > 1 && j < 23)) ||
                        (i == 40 && (j > 4 && j < 13)) || (j == 2 && (i > 1 && i < 37)) || (j == 12 && (i > 1 && i < 41))
                        || (j == 22 && (i > 1 && i < 37)) || (j == 23 && i == 18) || (j == 23 && i == 20) || (j == 24 && i == 18)
                        || (j == 24 && i == 20) || (j == 0 && i == 18) || (j == 0 && i == 20) || (j == 1 && i == 18) || (j == 1 && i == 20))
                    {
                        bmMap[i, j] = TilesetImageGenerator.GetTile(41);
                    }
                    else
                    {
                        bmMap[i, j] = TilesetImageGenerator.GetTile(0);
                    }
                }
            }
        }

        private void peuplerBitmapFence()
        {
            for (int i = 0; i < bmFence.GetLength(0); i++)
            {
                for (int j = 0; j < bmFence.GetLength(1); j++)
                {
                    if (j == 6 && i == 10)
                    {
                        bmFence[i, j] = TilesetImageGenerator.GetTile(43);
                    }
                    else if ((j == 0 && i != 13) || (j == 6 && i != 13))
                    {
                        bmFence[i, j] = TilesetImageGenerator.GetTile(1);
                    }
                    else if ((i == 0 || i == 13) && (j != 0 || j != 6))
                    {
                        bmFence[i, j] = TilesetImageGenerator.GetTile(2);
                    }
                    else
                    {
                        bmFence[i, j] = TilesetImageGenerator.GetTile(0);
                    }
                }
            }
        }

        private void peuplerBitmapHouse()
        {
            int countHouse = 5;

            for (int i = 0; i < bmHouse.GetLength(0); i++)
            {
                for (int j = 0; j < bmHouse.GetLength(1); j++)
                {
                    bmHouse[i, j] = TilesetImageGenerator.GetTile(countHouse);
                    countHouse++;
                }
            }
        }

        private void peuplerBitmapWell()
        {
            int countWell = 25;

            for (int i = 0; i < bmWell.GetLength(0); i++)
            {
                for (int j = 0; j < bmWell.GetLength(1); j++)
                {
                    bmWell[i, j] = TilesetImageGenerator.GetTile(countWell);
                    countWell++;
                }
            }
        }

        private void peuplerBitmapFenceUp()
        {
            for (int i = 0; i < bmFenceVert.GetLength(0); i++)
            {
                if (i == 19 || i == 20 || i == 21)
                {
                    bmFenceVert[i] = TilesetImageGenerator.GetTile(0);
                }
                else if (i == 12)
                {
                    bmFenceVert[i] = TilesetImageGenerator.GetTile(41);
                }
                else
                {
                    bmFenceVert[i] = TilesetImageGenerator.GetTile(2);
                }
            }
        }

        private void peuplerBitmapBenchUp()
        {
            int countBenchV = 37;

            for (int i = 0; i < bmBenchV.GetLength(0); i++)
            {
                bmBenchV[i] = TilesetImageGenerator.GetTile(countBenchV);
                countBenchV++;
            }
        }

        private void peuplerBitmapBenchSide()
        {
            int countBenchH = 34;

            for (int i = 0; i < bmBenchH.GetLength(0); i++)
            {
                bmBenchH[i] = TilesetImageGenerator.GetTile(countBenchH);
                countBenchH++;
            }
        }

        private void peuplerBitmapApple()
        {
            int countApple = 39;

            for (int i = 0; i < bmApple.GetLength(0); i++)
            {
                bmApple[i] = TilesetImageGenerator.GetTile(countApple);
                countApple++;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;

            dessinerMap(gr);

            dessinerEnclos(gr, 4, 4, 1);
            dessinerEnclos(gr, 21, 4, 2);
            dessinerEnclos(gr, 4, 14, 3);
            dessinerEnclos(gr, 21, 14, 4);

            dessinerEnclosVertical(gr);

            dessinerHouse(gr, 39, 0);

            dessinerWell(gr, 38, 19);

            dessinerPillar(gr);

            dessinerBenchH(gr, 23, 13);
            dessinerBenchH(gr, 30, 13);

            dessinerBenchV(gr, 3, 15);
            dessinerBenchV(gr, 18, 18);

            dessinerApple(gr, 10, 11);
            dessinerApple(gr, 28, 3);

            dessinerHero(gr, h.x, h.y);

            if (listeVisiteur.Count() > 0)
            {
                foreach (Visiteur v in listeVisiteur)
                {
                    dessinerVisiteur(gr, v);
                }
            }

            if (listeTrash.Count() > 0)
            {
                foreach (Point p in listeTrash)
                {
                    dessinerTrash(gr, p);
                }
            }

            dessinerAnimaux(gr);

            remplirNoMouvAnimal();
            remplirNoMouvJanitor();
            remplirNoMouvAI();
            remplirNoMouvTrash();

            if (listeConcierge.Count() > 0)
            {
                foreach (Concierge c in listeConcierge)
                {
                    dessinerConcierge(gr, c);
                }
            }
        }

        private void dessinerMap(Graphics gr)
        {
            for (int i = 0; i < bmMap.GetLength(0); i++)
            {
                for (int j = 0; j < bmMap.GetLength(1); j++)
                {
                    gr.DrawImage(bmMap[i, j], i * 32, j * 32, 32, 32);
                }
            }
        }

        private void dessinerEnclos(Graphics gr, int x, int y, int numeroEnclos)
        {
            int y2 = y;
            int x2 = x;
            for (int i2 = 0; i2 < bmFence.GetLength(0); i2++)
            {
                for (int j2 = 0; j2 < bmFence.GetLength(1); j2++)
                {
                    gr.DrawImage(bmFence[i2, j2], x2 * 32, y2 * 32, 32, 32);
                    if (j2 == 6 && i2 == 10)
                    {
                        noMouvCoord[x2, y2] = true;
                        noMouvCoordAI[x2, y2] = false;
                    }
                    else if ((j2 == 0 && i2 != 13) || (j2 == 6 && i2 != 13))
                    {
                        noMouvCoord[x2, y2] = false;
                        noMouvCoordAI[x2, y2] = false;
                    }
                    else if ((i2 == 0 || i2 == 13) && (j2 != 0 || j2 != 6))
                    {
                        noMouvCoord[x2, y2] = false;
                        noMouvCoordAI[x2, y2] = false;
                    }
                    else
                    {
                        interieurEnclos[x2, y2] = true;
                        numEnclos[x2, y2] = numeroEnclos;
                    }
                    y2++;
                }
                x2++;
                y2 = y;
            }
        }

        private void dessinerEnclosVertical(Graphics gr)
        {
            for (int i2 = 0; i2 < bmFenceVert.GetLength(0); i2++)
            {
                gr.DrawImage(bmFenceVert[i2], 38 * 32, i2 * 32, 32, 32);
                noMouvCoord[38, i2] = false;
                noMouvCoordAI[38, i2] = false;
            }
            noMouvCoord[38, 12] = true;
        }

        private void dessinerHouse(Graphics gr, int x, int y)
        {
            int y2 = y;
            int x2 = x;
            for (int i2 = 0; i2 < bmHouse.GetLength(0); i2++)
            {
                for (int j2 = 0; j2 < bmHouse.GetLength(1); j2++)
                {
                    gr.DrawImage(bmHouse[i2, j2], x2 * 32, y2 * 32, 32, 32);
                    noMouvCoord[x2, y2] = false;
                    noMouvCoordAI[x2, y2] = false;
                    y2++;
                }
                x2++;
                y2 = y;
            }

        }

        private void dessinerWell(Graphics gr, int x, int y)
        {
            int y2 = y;
            int x2 = x;
            for (int i2 = 0; i2 < bmWell.GetLength(0); i2++)
            {
                for (int j2 = 0; j2 < bmWell.GetLength(1); j2++)
                {
                    gr.DrawImage(bmWell[i2, j2], x2 * 32, y2 * 32, 32, 32);
                    noMouvCoord[x2, y2] = false;
                    noMouvCoordAI[x2, y2] = false;
                    y2++;
                }
                x2++;
                y2 = y;
            }
        }

        private void dessinerPillar(Graphics gr)
        {
            Image pillarTop = TilesetImageGenerator.GetTile(3);
            Image pillarBot = TilesetImageGenerator.GetTile(4);
            gr.DrawImage(pillarTop, 17 * 32, 0 * 32, 32, 32);
            gr.DrawImage(pillarTop, 21 * 32, 0 * 32, 32, 32);
            gr.DrawImage(pillarTop, 17 * 32, 23 * 32, 32, 32);
            gr.DrawImage(pillarTop, 21 * 32, 23 * 32, 32, 32);

            gr.DrawImage(pillarBot, 17 * 32, 1 * 32, 32, 32);
            gr.DrawImage(pillarBot, 21 * 32, 1 * 32, 32, 32);
            gr.DrawImage(pillarBot, 17 * 32, 24 * 32, 32, 32);
            gr.DrawImage(pillarBot, 21 * 32, 24 * 32, 32, 32);

            noMouvCoord[17, 0] = false;
            noMouvCoord[17, 23] = false;
            noMouvCoord[17, 1] = false;
            noMouvCoord[17, 24] = false;
            noMouvCoord[21, 0] = false;
            noMouvCoord[21, 23] = false;
            noMouvCoord[21, 1] = false;
            noMouvCoord[21, 24] = false;

            noMouvCoordAI[17, 0] = false;
            noMouvCoordAI[17, 23] = false;
            noMouvCoordAI[17, 1] = false;
            noMouvCoordAI[17, 24] = false;
            noMouvCoordAI[21, 0] = false;
            noMouvCoordAI[21, 23] = false;
            noMouvCoordAI[21, 1] = false;
            noMouvCoordAI[21, 24] = false;
        }

        private void dessinerBenchH(Graphics gr, int x, int y)
        {
            int y2 = y;
            int x2 = x;
            for (int i2 = 0; i2 < bmBenchH.GetLength(0); i2++)
            {
                gr.DrawImage(bmBenchH[i2], x2 * 32, y2 * 32, 32, 32);
                y2++;

                x2++;
                y2 = y;
            }
        }

        private void dessinerBenchV(Graphics gr, int x, int y)
        {
            int y2 = y;
            int x2 = x;
            for (int i2 = 0; i2 < bmBenchV.GetLength(0); i2++)
            {
                gr.DrawImage(bmBenchV[i2], x2 * 32, y2 * 32, 32, 32);
                y2++;
            }
        }

        private void dessinerApple(Graphics gr, int x, int y)
        {
            int y2 = y;
            int x2 = x;
            for (int i2 = 0; i2 < bmApple.GetLength(0); i2++)
            {
                gr.DrawImage(bmApple[i2], x2 * 32, y2 * 32, 32, 32);
                noMouvCoord[x2, y2] = false;
                noMouvCoordAI[x2, y2] = false;
                y2++;

                x2++;
                y2 = y;
            }
        }

        private void dessinerHero(Graphics gr, int x, int y)
        {
            gr.DrawImage(h.currentDir, x * 32, y * 32, 32, 32);
        }

        private void dessinerVisiteur(Graphics gr, Visiteur v)
        {
            if (v.type == 1)
            {
                gr.DrawImage(v.currentDir, v.x * 32, v.y * 32, 32, 32);
            }
            else if (v.type == 2)
            {
                gr.DrawImage(v.currentDir, v.x * 32, v.y * 32, 32, 32);
            }
            else if (v.type == 3)
            {
                gr.DrawImage(v.currentDir, v.x * 32, v.y * 32, 32, 32);
            }
            else
            {
                gr.DrawImage(v.currentDir, v.x * 32, v.y * 32, 32, 32);
            }
        }

        private void dessinerTrash(Graphics gr, Point p)
        {
            gr.DrawImage(TilesetImageGenerator.GetTile(42), p.X * 32, p.Y * 32, 32, 32);
        }

        private void dessinerAnimaux(Graphics gr)
        {
            for (int i = 0; i < bmAnimaux.GetLength(0); i++)
            {
                for (int j = 0; j < bmAnimaux.GetLength(1); j++)
                {
                    if (bmAnimaux[i, j] != null)
                    {
                        gr.DrawImage(bmAnimaux[i, j], i * 32, j * 32, 32, 32);
                    }
                }
            }
        }

        private void dessinerConcierge(Graphics gr, Concierge c)
        {
            gr.DrawImage(c.currentDir, c.x * 32, c.y * 32, 32, 32);
        }

        private void remplirNoMouvAnimal()
        {
            for (int i = 0; i < noMouvCoord.GetLength(0); i++)
            {
                for (int j = 0; j < noMouvCoord.GetLength(1); j++)
                {
                    noMouvAnimal[i, j] = true;
                }
            }

            foreach (Animal a in listeAnimaux)
            {
                noMouvAnimal[a.x, a.y] = false;
            }
        }

        private void remplirNoMouvJanitor()
        {
            for (int i = 0; i < noMouvJanitor.GetLength(0); i++)
            {
                for (int j = 0; j < noMouvJanitor.GetLength(1); j++)
                {
                    noMouvJanitor[i, j] = true;
                }
            }

            foreach (Concierge c in listeConcierge)
            {
                noMouvJanitor[c.x, c.y] = false;
            }
        }

        private void remplirNoMouvAI()
        {
            for (int i = 0; i < noMouvCoord.GetLength(0); i++)
            {
                for (int j = 0; j < noMouvCoord.GetLength(1); j++)
                {
                    noMouvAi[i, j] = true;
                }
            }

            foreach (Visiteur vis in listeVisiteur)
            {
                noMouvAi[vis.x, vis.y] = false;
            }
        }

        private void remplirNoMouvTrash()
        {
            for (int i = 0; i < noMouvCoord.GetLength(0); i++)
            {
                for (int j = 0; j < noMouvCoord.GetLength(1); j++)
                {
                    noMouvTrash[i, j] = true;
                }
            }

            foreach (Point p in listeTrash)
            {
                noMouvTrash[p.X, p.Y] = false;
            }
        }

        public void faireDeplacementHero(KeyEventArgs key)
        {
            int x2 = h.x;
            int y2 = h.y;

            if (key.KeyCode == Keys.W)
            {
                y2--;
                if (y2 >= 0)
                {
                    if (noMouvCoord[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2])
                    {
                        h.y--;
                        if (up == 0)
                        {
                            h.currentDir = h.haut2;
                            Refresh();
                            up++;
                        }
                        else if (up == 1)
                        {
                            h.currentDir = h.haut3;
                            Refresh();
                            up--;
                        }
                    }
                }
            }
            else if (key.KeyCode == Keys.A)
            {
                x2--;
                if (x2 >= 0)
                {
                    if (noMouvCoord[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2])
                    {
                        h.x--;
                        if (left == 0)
                        {
                            h.currentDir = h.gauche2;
                            Refresh();
                            left++;
                        }
                        else if (left == 1)
                        {
                            h.currentDir = h.gauche1;
                            Refresh();
                            left--;
                        }
                    }
                }
            }
            else if (key.KeyCode == Keys.S)
            {
                y2++;
                if (y2 <= 24)
                {
                    if (noMouvCoord[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2])
                    {
                        h.y++;
                        if (down == 0)
                        {
                            h.currentDir = h.bas2;
                            Refresh();
                            down++;
                        }
                        else if (down == 1)
                        {
                            h.currentDir = h.bas3;
                            Refresh();
                            down--;
                        }
                    }
                }
            }
            else if (key.KeyCode == Keys.D)
            {
                x2++;
                if (x2 <= 42)
                {
                    if (noMouvCoord[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2])
                    {
                        h.x++;
                        if (right == 0)
                        {
                            h.currentDir = h.droite2;
                            Refresh();
                            right++;
                        }
                        else if (right == 1)
                        {
                            h.currentDir = h.droite1;
                            Refresh();
                            right--;
                        }
                    }
                }
            }
            x2 = h.x;
            y2 = h.y;

            heroOnlyArea = h.x > 37;

            enableBuyAnimals = interieurEnclos[x2, y2];

            peuplerBitmapInteraction(x2, y2);
        }

        public void DeplacementAI(Visiteur v)
        {
            Random r = new Random();
            int deplacement = r.Next(1, 4);

            int x2 = v.x;
            int y2 = v.y;
            Point pHero = new Point();
            Point pVisiteur = new Point();
            pHero.X = h.x;
            pHero.Y = h.y;
            pVisiteur.X = v.x;
            pVisiteur.Y = v.y;

            List<Image> l = new List<Image>();
            switch (v.type)
            {
                case 1:
                    l = v.listHomme1;
                    break;
                case 2:
                    l = v.listHomme2;
                    break;
                case 3:
                    l = v.listFemme1;
                    break;
                case 4:
                    l = v.listFemme2;
                    break;
            }

            if (deplacement == 1)
            {
                y2--;
                if (y2 >= 0)
                {
                    pVisiteur.Y = y2;
                    if (noMouvCoordAI[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2] && pHero != pVisiteur)
                    {
                        v.y--;
                        if (v.upAI == 0)
                        {
                            v.currentDir = l.ElementAt(9);
                            Refresh();
                            v.upAI++;
                        }
                        else if (v.upAI == 1)
                        {
                            v.currentDir = l.ElementAt(8);
                            Refresh();
                            v.upAI--;
                        }
                    }
                }
            }
            else if (deplacement == 2)
            {
                x2--;
                if (x2 >= 0)
                {
                    pVisiteur.X = x2;
                    if (noMouvCoordAI[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2] && pHero != pVisiteur)
                    {
                        v.x--;
                        if (v.leftAI == 0)
                        {
                            v.currentDir = l.ElementAt(7);
                            Refresh();
                            v.leftAI++;
                        }
                        else if (v.leftAI == 1)
                        {
                            v.currentDir = l.ElementAt(6);
                            Refresh();
                            v.leftAI++;
                        }
                        else if (v.leftAI == 2)
                        {
                            v.currentDir = l.ElementAt(5);
                            Refresh();
                            v.leftAI = 0;
                        }
                    }
                }
            }
            else if (deplacement == 3)
            {
                x2++;
                if (x2 <= 42)
                {
                    pVisiteur.X = x2;
                    if (noMouvCoordAI[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2] && pHero != pVisiteur)
                    {
                        v.x++;
                        if (v.rightAI == 0)
                        {
                            v.currentDir = l.ElementAt(4);
                            Refresh();
                            v.rightAI++;
                        }
                        else if (v.rightAI == 1)
                        {
                            v.currentDir = l.ElementAt(3);
                            Refresh();
                            v.rightAI++;
                        }
                        else if (v.rightAI == 2)
                        {
                            v.currentDir = l.ElementAt(2);
                            Refresh();
                            v.rightAI = 0;
                        }
                    }
                }
            }
        }

        public void deplacementAnimal(Animal a)
        {
            Random r = new Random();
            int deplacement = r.Next(1, 5);

            int x2 = a.x;
            int y2 = a.y;

            Bitmap[] l = new Bitmap[1];
            switch (a.TypeAnimal)
            {
                case Animaux.Lion:
                    l[0] = TilesetImageGenerator.GetTile(44);
                    break;
                case Animaux.Mouton:
                    l[0] = TilesetImageGenerator.GetTile(45);
                    break;
                case Animaux.Grizzly:
                    l[0] = TilesetImageGenerator.GetTile(46);
                    break;
                case Animaux.Rhinoceros:
                    l[0] = TilesetImageGenerator.GetTile(47);
                    break;
                case Animaux.Licorne:
                    l[0] = TilesetImageGenerator.GetTile(48);
                    break;
                case Animaux.Buffle:
                    l[0] = TilesetImageGenerator.GetTile(49);
                    break;
            }

            if (deplacement == 1)
            {
                y2--;
                if (y2 >= 0)
                {
                    if (noMouvCoordAI[x2, y2] && (h.x != x2 && h.y != y2) && noMouvAnimal[x2, y2])
                    {
                        bmAnimaux[a.x, a.y] = null;
                        a.y--;
                        bmAnimaux[a.x, a.y] = l[0];
                        Refresh();
                    }
                }
            }
            else if (deplacement == 2)
            {
                x2--;
                if (x2 >= 0)
                {
                    if (noMouvCoordAI[x2, y2] && (h.x != x2 && h.y != y2) && noMouvAnimal[x2, y2])
                    {
                        bmAnimaux[a.x, a.y] = null;
                        a.x--;
                        bmAnimaux[a.x, a.y] = l[0];
                        Refresh();
                    }
                }
            }
            else if (deplacement == 3)
            {
                y2++;
                if (y2 <= 24)
                {
                    if (noMouvCoordAI[x2, y2] && (h.x != x2 && h.y != y2) && noMouvAnimal[x2, y2])
                    {
                        bmAnimaux[a.x, a.y] = null;
                        a.y++;
                        bmAnimaux[a.x, a.y] = l[0];
                        Refresh();
                    }
                }
            }
            else if (deplacement == 4)
            {
                x2++;
                if (x2 <= 42)
                {
                    if (noMouvCoordAI[x2, y2] && (h.x != x2 && h.y != y2) && noMouvAnimal[x2, y2])
                    {
                        bmAnimaux[a.x, a.y] = null;
                        a.x++;
                        bmAnimaux[a.x, a.y] = l[0];
                        Refresh();
                    }
                }
            }
        }

        public void dropTrash(Visiteur v)
        {
            if (v.dropDechet)
            {
                Point p = new Point();
                p.X = v.x;
                p.Y = v.y;
                listeTrash.Add(p);
                Refresh();
                DeplacementAI(v);
            }
        }

        public void deplacementConcierge(Concierge c)
        {
            Random r = new Random();
            int deplacement = r.Next(1, 5);
            int x2 = c.x;
            int y2 = c.y;

            Point pHero = new Point();
            Point pConcierge = new Point();
            pHero.X = h.x;
            pHero.Y = h.y;
            pConcierge.X = c.x;
            pConcierge.Y = c.y;

            List<Image> l = new List<Image>();
            l = c.listeC;

            if (deplacement == 1)
            {
                y2--;
                pConcierge.Y = y2;
                if (y2 >= 0)
                {
                    if (noMouvCoordAI[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2] && pConcierge != pHero)
                    {
                        c.y--;
                        if (c.upAI == 0)
                        {
                            c.currentDir = l.ElementAt(9);
                            Refresh();
                            c.upAI++;
                        }
                        else if (c.upAI == 1)
                        {
                            c.currentDir = l.ElementAt(8);
                            Refresh();
                            c.upAI--;
                        }
                    }
                }
            }
            else if (deplacement == 2)
            {
                x2--;
                pConcierge.X = x2;
                if (x2 >= 0)
                {
                    if (noMouvCoordAI[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2] && pConcierge != pHero)
                    {
                        c.x--;
                        if (c.leftAI == 0)
                        {
                            c.currentDir = l.ElementAt(7);
                            Refresh();
                            c.leftAI++;
                        }
                        else if (c.leftAI == 1)
                        {
                            c.currentDir = l.ElementAt(6);
                            Refresh();
                            c.leftAI++;
                        }
                        else if (c.leftAI == 2)
                        {
                            c.currentDir = l.ElementAt(5);
                            Refresh();
                            c.leftAI = 0;
                        }
                    }
                }
            }
            else if (deplacement == 3)
            {
                y2++;
                pConcierge.Y = y2;
                if (y2 <= 24)
                {
                    if (noMouvCoordAI[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2] && pConcierge != pHero)
                    {
                        c.y++;
                        if (c.downAI == 0)
                        {
                            c.currentDir = l.ElementAt(1);
                            Refresh();
                            c.downAI++;
                        }
                        else if (c.downAI == 1)
                        {
                            c.currentDir = l.ElementAt(0);
                            Refresh();
                            c.downAI--;
                        }
                    }
                }
            }
            else if (deplacement == 4)
            {
                x2++;
                pConcierge.X = x2;
                if (x2 <= 42)
                {
                    if (noMouvCoordAI[x2, y2] && noMouvJanitor[x2, y2] && noMouvAi[x2, y2] && noMouvTrash[x2, y2] && pConcierge != pHero)
                    {
                        c.x++;
                        if (c.rightAI == 0)
                        {
                            c.currentDir = l.ElementAt(4);
                            Refresh();
                            c.rightAI++;
                        }
                        else if (c.rightAI == 1)
                        {
                            c.currentDir = l.ElementAt(3);
                            Refresh();
                            c.rightAI++;
                        }
                        else if (c.rightAI == 2)
                        {
                            c.currentDir = l.ElementAt(2);
                            Refresh();
                            c.rightAI = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < c.bmInteractionC.GetLength(0); i++)
            {
                for (int j = 0; j < c.bmInteractionC.GetLength(1); j++)
                {
                    c.bmInteractionC[i, j] = false;
                }
            }

            c.bmInteractionC = peuplerBitmapInteractionConcierge(c.x, c.y, c);

            for (int i = 0; i < c.bmInteractionC.GetLength(0); i++)
            {
                for (int j = 0; j < c.bmInteractionC.GetLength(1); j++)
                {
                    if (c.bmInteractionC[i, j])
                    {
                        foreach (Point p in listeTrash)
                        {
                            if (p.X == i && p.Y == j)
                            {
                                listeTrash.Remove(p);
                                break;
                            }
                        }
                    }
                }
            }

        }


        public void ajouterVisiteur()
        {
            Visiteur v = new Visiteur();
            listeVisiteur.Add(v);
        }

        public void ajouterConcierge(int x, int y)
        {
            Concierge c = new Concierge(x, y);
            listeConcierge.Add(c);
        }

        private void peuplerBitmapInteraction(int x2, int y2)
        {
            for (int i = 0; i < bmInteraction.GetLength(0); i++)
            {
                for (int j = 0; j < bmInteraction.GetLength(1); j++)
                {
                    bmInteraction[i, j] = false;
                }
            }

            if (h.x != 0 && h.y != 0)
            {
                bmInteraction[x2 - 1, y2 - 1] = true;
            }

            if (h.x != 0)
            {
                bmInteraction[x2 - 1, y2] = true;
            }

            if (h.y != 0)
            {
                bmInteraction[x2, y2 - 1] = true;
            }

            if (h.x != 0 && h.y != 24)
            {
                bmInteraction[x2 - 1, y2 + 1] = true;
            }

            if (h.x != 42 && h.y != 24)
            {
                bmInteraction[x2 + 1, y2 + 1] = true;
            }

            if (h.x != 42)
            {
                bmInteraction[x2 + 1, y2] = true;
            }

            if (h.y != 24)
            {
                bmInteraction[x2, y2 + 1] = true;
            }

            if (h.x != 42 && h.y != 0)
            {
                bmInteraction[x2 + 1, y2 - 1] = true;
            }
        }

        private bool[,] peuplerBitmapInteractionConcierge(int x2, int y2, Concierge c)
        {
            bool[,] bmInteractionC = new bool[43, 25];

            for (int i = 0; i < bmInteractionC.GetLength(0); i++)
            {
                for (int j = 0; j < bmInteractionC.GetLength(1); j++)
                {
                    bmInteractionC[i, j] = false;
                }
            }

            if (c.x != 0 && c.y != 0)
            {
                bmInteractionC[x2 - 1, y2 - 1] = true;
            }

            if (c.x != 0)
            {
                bmInteractionC[x2 - 1, y2] = true;
            }

            if (c.y != 0)
            {
                bmInteractionC[x2, y2 - 1] = true;
            }

            if (c.x != 0 && c.y != 24)
            {
                bmInteractionC[x2 - 1, y2 + 1] = true;
            }

            if (c.x != 42 && c.y != 24)
            {
                bmInteractionC[x2 + 1, y2 + 1] = true;
            }

            if (c.x != 42)
            {
                bmInteractionC[x2 + 1, y2] = true;
            }

            if (c.y != 24)
            {
                bmInteractionC[x2, y2 + 1] = true;
            }

            if (c.x != 42 && c.y != 0)
            {
                bmInteractionC[x2 + 1, y2 - 1] = true;
            }

            return bmInteractionC;
        }


        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:

                    if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32] && noMouvAnimal[e.X / 32, e.Y / 32])
                    {
                        int xAnimal = e.X / 32;
                        int yAnimal = e.Y / 32;
                        switch (animalChoisi)
                        {
                            case "Lion":
                                if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                                    && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Lion))
                                {
                                    listeAnimaux.Add(new Animal(Animaux.Lion, xAnimal, yAnimal));
                                    bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(44);
                                    placedAnimal = true;
                                    prixAnimal = 35;
                                    remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                                    ajouterVisiteur();
                                }
                                animalChoisi = "";
                                break;
                            case "Mouton":
                                if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                                    && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Mouton))
                                {
                                    listeAnimaux.Add(new Animal(Animaux.Mouton, xAnimal, yAnimal));
                                    bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(45);
                                    placedAnimal = true;
                                    prixAnimal = 20;
                                    remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                                    ajouterVisiteur();
                                }
                                animalChoisi = "";
                                break;
                            case "Grizzly":
                                if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                                    && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Grizzly))
                                {
                                    listeAnimaux.Add(new Animal(Animaux.Grizzly, xAnimal, yAnimal));
                                    bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(46);
                                    placedAnimal = true;
                                    prixAnimal = 30;
                                    remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                                    ajouterVisiteur();
                                }
                                animalChoisi = "";
                                break;
                            case "Rhino":
                                if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                                    && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Rhinoceros))
                                {
                                    listeAnimaux.Add(new Animal(Animaux.Rhinoceros, xAnimal, yAnimal));
                                    bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(47);
                                    placedAnimal = true;
                                    prixAnimal = 40;
                                    remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                                    ajouterVisiteur();
                                }
                                animalChoisi = "";
                                break;
                            case "Licorne":
                                if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                                    && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Licorne))
                                {
                                    listeAnimaux.Add(new Animal(Animaux.Licorne, xAnimal, yAnimal));
                                    bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(48);
                                    placedAnimal = true;
                                    prixAnimal = 50;
                                    remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                                    ajouterVisiteur();
                                }
                                animalChoisi = "";
                                break;
                            case "Buffle":
                                if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                                    && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Buffle))
                                {
                                    listeAnimaux.Add(new Animal(Animaux.Buffle, xAnimal, yAnimal));
                                    bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(49);
                                    placedAnimal = true;
                                    prixAnimal = 40;
                                    remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                                    ajouterVisiteur();
                                }
                                animalChoisi = "";
                                break;
                        }
                    }
                    else if (bmInteraction[e.X / 32, e.Y / 32] && conciergeChoisi && (e.X / 32) < 38 && noMouvCoordAI[e.X / 32, e.Y / 32]/** && noMouvTrash[e.X / 32, e.X / 32]**/)
                    {
                        conciergeChoisi = false;
                        bmVisiteurEtConcierge[e.X / 32, e.Y / 32] = GeneratorPersonnage.GetTile(40);
                        ajouterConcierge(e.X / 32, e.Y / 32);
                        conciergeChoisi = false;
                    }
                    else if (bmInteraction[e.X / 32, e.Y / 32] && !noMouvTrash[e.X / 32, e.Y / 32])
                    {
                        foreach (Point p in listeTrash)
                        {
                            if (p.X == e.X / 32 && p.Y == e.Y / 32)
                            {
                                listeTrash.Remove(p);
                                break;
                            }
                        }
                    }
                    else if (bmInteraction[e.X / 32, e.Y / 32] && !noMouvAnimal[e.X / 32, e.Y / 32])
                    {
                        foreach (Animal a in listeAnimaux)
                        {
                            if(a.x == e.X / 32 && a.y == e.Y / 32){
                                a.Nourri = true;
                                a.TimePassedLastFed = 0;
                            }
                        }
                    }
                    Refresh();
                    break;
                case MouseButtons.Right:

                    int comptA = 0;
                    int comptV = 0;

                    foreach (Animal a in listeAnimaux)
                    {
                        if (a.x == e.X / 32 && a.y == e.Y / 32)
                        {
                            placeListeAnimal = comptA;
                            break;
                        }
                        comptA++;
                    }

                    foreach (Visiteur v in listeVisiteur)
                    {
                        if (v.x == e.X / 32 && v.y == e.Y / 32)
                        {
                            placeListeVisiteur = comptV;
                            break;
                        }
                        comptV++;
                    }

                    break;
            }
        }

        private void remplirEnclosAnimal(MouseEventArgs e, Animaux a)
        {
            for (int i = 0; i < numEnclos.GetLength(0); i++)
            {
                for (int j = 0; j < numEnclos.GetLength(1); j++)
                {
                    if (numEnclos[i, j] == numEnclos[e.X / 32, e.Y / 32])
                    {
                        enclosAnimal[i, j] = a;
                    }
                }
            }
        }
    }
}
