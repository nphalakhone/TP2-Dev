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


        public Map()
        {
            InitializeComponent();
            creerInterface();
        }

        private void creerInterface()
        {
            //Creation interface gazon.
            for (int i = 0; i < bmMap.GetLength(0); i++)
            {
                for (int j = 0; j < bmMap.GetLength(1); j++)
                {
                    bmMap[i, j] = TilesetImageGenerator.GetTile(0);
                }
            }

            //Creation des enclos.
            for (int i = 0; i < bmFence.GetLength(0); i++)
            {
                for (int j = 0; j < bmFence.GetLength(1); j++)
                {
                    if ((j == 0 && i != 13) || (j == 6 && i != 13))
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

            int countHouse = 5;

            for (int i = 0; i < bmHouse.GetLength(0); i++)
            {
                for (int j = 0; j < bmHouse.GetLength(1); j++)
                {
                    bmHouse[i, j] = TilesetImageGenerator.GetTile(countHouse);
                    countHouse++;
                }
            }

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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;

            for (int i = 0; i < bmMap.GetLength(0); i++)
            {
                for (int j = 0; j < bmMap.GetLength(1); j++)
                {
                    gr.DrawImage(bmMap[i, j], i * 32, j * 32, 32, 32);
                }
            }

            dessinerEnclos(gr, 4, 4);
            dessinerEnclos(gr, 21, 4);
            dessinerEnclos(gr, 4, 14);
            dessinerEnclos(gr, 21, 14);

            dessinerHouse(gr, 39, 0);

            dessinerWell(gr, 37, 16);

            dessinerPillar(gr);
        }

        private void dessinerEnclos(Graphics gr, int x, int y)
        {
            int y2 = y;
            int x2 = x;
            for (int i2 = 0; i2 < bmFence.GetLength(0); i2++)
            {
                for (int j2 = 0; j2 < bmFence.GetLength(1); j2++)
                {
                    gr.DrawImage(bmFence[i2, j2], x2 * 32, y2 * 32, 32, 32);
                    y2++;
                }
                x2++;
                y2 = y;
            }
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
                    y2++;
                }
                x2++;
                y2 = y;
            }

        }private void dessinerWell(Graphics gr, int x, int y)
        {
            int y2 = y;
            int x2 = x;
            for (int i2 = 0; i2 < bmWell.GetLength(0); i2++)
            {
                for (int j2 = 0; j2 < bmWell.GetLength(1); j2++)
                {
                    gr.DrawImage(bmWell[i2, j2], x2 * 32, y2 * 32, 32, 32);
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
        }

    }
}
