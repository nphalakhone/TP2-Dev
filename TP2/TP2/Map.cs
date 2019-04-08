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
        Bitmap[,] bm = new Bitmap[32, 16];
        public Map()
        {
            InitializeComponent();
            creerInterface();
        }

        private void creerInterface()
        {
            for (int i = 0; i < bm.GetLength(0); i++)
            {
                for (int j = 0; j < bm.GetLength(1); j++)
                {
                    bm[i, j] = TilesetImageGenerator.GetTile(0);
                }
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;

            for (int i = 0; i < bm.GetLength(0); i++)
            {
                for (int j = 0; j < bm.GetLength(1); j++)
                {
                    gr.DrawImage(bm[i, j], i * 32, j * 32, 32, 32);
                }
            }

        }
    }
}
