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
        Animaux?[,] enclosAnimal = new Animaux?[43, 25];

        public int sizeListeAnimaux { get; set; }
        public int sizeListeVisiteur { get; set; }

        List<Animal> listeAnimaux { get; set; }
        List<Concierge> listeConcierge { get; set; }
        public List<Visiteur> listeVisiteur { get; set; }

        int xSortie = 19;
        int ySortie = 0;

        Hero h = new Hero();

        Visiteur v = new Visiteur();

        int up = 0;
        int down = 0;
        int left = 0;
        int right = 0;

        public bool enableBuyAnimals { get; set; }

        public string animalChoisi { get; set; }

        public bool conciergeChoisi { get; set; }

        public bool placedAnimal { get; set; }

        public bool heroOnlyArea { get; set; }

        public Map()
        {
            InitializeComponent();
            creerInterface();

            listeAnimaux = new List<Animal>();
            listeConcierge = new List<Concierge>();
            listeVisiteur = new List<Visiteur>();
            
            heroOnlyArea = true;
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
                    numEnclos[i, j] = 0;
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
                        (i == 40 && (j > 4 && j < 13)) || (j == 2 && (i > 1 && i < 37)) || (j == 12 && (i > 1 && i < 41)) || (j == 22 && (i > 1 && i < 37)))
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

            if (sizeListeVisiteur > 0)
            {
                dessinerVisiteur(gr, v.x, v.y);
            }

            dessinerAnimaux(gr);

            remplirNoMouvAnimal();
            remplirNoMouvJanitor();

            dessinerConcierge(gr);
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
            gr.DrawImage(pillarTop, 18 * 32, 0 * 32, 32, 32);
            gr.DrawImage(pillarTop, 20 * 32, 0 * 32, 32, 32);
            gr.DrawImage(pillarTop, 18 * 32, 23 * 32, 32, 32);
            gr.DrawImage(pillarTop, 20 * 32, 23 * 32, 32, 32);

            gr.DrawImage(pillarBot, 18 * 32, 1 * 32, 32, 32);
            gr.DrawImage(pillarBot, 20 * 32, 1 * 32, 32, 32);
            gr.DrawImage(pillarBot, 18 * 32, 24 * 32, 32, 32);
            gr.DrawImage(pillarBot, 20 * 32, 24 * 32, 32, 32);

            noMouvCoord[18, 0] = false;
            noMouvCoord[18, 23] = false;
            noMouvCoord[18, 1] = false;
            noMouvCoord[18, 24] = false;
            noMouvCoord[20, 0] = false;
            noMouvCoord[20, 23] = false;
            noMouvCoord[20, 1] = false;
            noMouvCoord[20, 24] = false;

            noMouvCoordAI[18, 0] = false;
            noMouvCoordAI[18, 23] = false;
            noMouvCoordAI[18, 1] = false;
            noMouvCoordAI[18, 24] = false;
            noMouvCoordAI[20, 0] = false;
            noMouvCoordAI[20, 23] = false;
            noMouvCoordAI[20, 1] = false;
            noMouvCoordAI[20, 24] = false;
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

        private void dessinerVisiteur(Graphics gr, int x, int y)
        {
            if (v.type == 1)
            {
                gr.DrawImage(v.listHomme1.ElementAt(8), x * 32, y * 32, 32, 32);
            }
            else if (v.type == 2)
            {
                gr.DrawImage(v.listHomme2.ElementAt(18), x * 32, y * 32, 32, 32);
            }
            else if (v.type == 3)
            {
                gr.DrawImage(v.listFemme1.ElementAt(28), x * 32, y * 32, 32, 32);
            }
            else
            {
                gr.DrawImage(v.listFemme2.ElementAt(38), x * 32, y * 32, 32, 32);
            }
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

        private void dessinerConcierge(Graphics gr)
        {
            for (int i = 0; i < bmVisiteurEtConcierge.GetLength(0); i++)
            {
                for (int j = 0; j < bmVisiteurEtConcierge.GetLength(1); j++)
                {
                    if (bmVisiteurEtConcierge[i, j] != null)
                    {
                        gr.DrawImage(bmVisiteurEtConcierge[i, j], i * 32, j * 32, 32, 32);
                    }
                }
            }
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

        public void faireDeplacementHero(KeyEventArgs key)
        {
            int x2 = h.x;
            int y2 = h.y;

            if (key.KeyCode == Keys.W)
            {
                y2--;
                if (y2 >= 0)
                {
                    if (noMouvCoord[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2])
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
                    if (noMouvCoord[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2])
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
                    if (noMouvCoord[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2])
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
                    if (noMouvCoord[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2])
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
                    if (noMouvCoordAI[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2])
                    {
                        h.y--;
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
                    if (noMouvCoordAI[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2])
                    {
                        h.x--;
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
                            v.leftAI--;
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
                y2++;
                if (y2 <= 24)
                {
                    if (noMouvCoordAI[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2])
                    {
                        h.y++;
                        if (v.downAI == 0)
                        {
                            v.currentDir = l.ElementAt(1);
                            Refresh();
                            v.downAI++;
                        }
                        else if (v.downAI == 1)
                        {
                            v.currentDir = l.ElementAt(0);
                            Refresh();
                            v.downAI--;
                        }
                    }
                }
            }
            else if (deplacement == 4)
            {
                x2++;
                if (x2 <= 42)
                {
                    if (noMouvCoordAI[x2, y2] && noMouvAnimal[x2, y2] && noMouvJanitor[x2, y2])
                    {
                        h.x++;
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
                            v.rightAI--;
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

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32])
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
                            remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                        }
                        animalChoisi = "";
                        break;
                    case "Mouton":
                        if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                            && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Mouton))
                        {
                            listeAnimaux.Add(new Animal(Animaux.Lion, xAnimal, yAnimal));
                            bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(45);
                            placedAnimal = true;
                            remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                        }
                        animalChoisi = "";
                        break;
                    case "Grizzly":
                        if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                            && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Grizzly))
                        {
                            listeAnimaux.Add(new Animal(Animaux.Lion, xAnimal, yAnimal));
                            bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(46);
                            placedAnimal = true;
                            remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                        }
                        animalChoisi = "";
                        break;
                    case "Rhino":
                        if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                            && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Rhinoceros))
                        {
                            listeAnimaux.Add(new Animal(Animaux.Lion, xAnimal, yAnimal));
                            bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(47);
                            placedAnimal = true;
                            remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                        }
                        animalChoisi = "";
                        break;
                    case "Licorne":
                        if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                            && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Licorne))
                        {
                            listeAnimaux.Add(new Animal(Animaux.Lion, xAnimal, yAnimal));
                            bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(48);
                            placedAnimal = true;
                            remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                        }
                        animalChoisi = "";
                        break;
                    case "Buffle":
                        if (bmInteraction[e.X / 32, e.Y / 32] && interieurEnclos[e.X / 32, e.Y / 32]
                            && (enclosAnimal[e.X / 32, e.Y / 32] == null || enclosAnimal[e.X / 32, e.Y / 32] == Animaux.Buffle))
                        {
                            listeAnimaux.Add(new Animal(Animaux.Lion, xAnimal, yAnimal));
                            bmAnimaux[e.X / 32, e.Y / 32] = TilesetImageGenerator.GetTile(49);
                            placedAnimal = true;
                            remplirEnclosAnimal(e, listeAnimaux.Last().TypeAnimal);
                        }
                        animalChoisi = "";
                        break;
                }
                sizeListeAnimaux = listeAnimaux.Count();
            }
            else if (bmInteraction[e.X / 32, e.Y / 32] && conciergeChoisi && (e.X / 32) < 38 && noMouvCoordAI[e.X / 32, e.Y /32])
            {
                conciergeChoisi = false;
                listeConcierge.Add(new Concierge(e.X / 32, e.Y / 32));
                bmVisiteurEtConcierge[e.X / 32, e.Y / 32] = GeneratorPersonnage.GetTile(40);
                conciergeChoisi = false;
            }
            Refresh();
        }

        private void remplirEnclosAnimal(MouseEventArgs e, Animaux a)
        {
            for (int i = 0; i < numEnclos.GetLength(0); i++)
            {
                for (int j = 0; j < numEnclos.GetLength(1); j++)
                {
                    if(numEnclos[i, j] == numEnclos[e.X / 32, e.Y / 32])
                    {
                        enclosAnimal[i, j] = a;
                    }
                }
            }
        }
    }
}
