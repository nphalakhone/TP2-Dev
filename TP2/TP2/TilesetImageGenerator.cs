using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTilesetZoo
{
    class TilesetImageGenerator
    {
        // Différentes tailles concernant les images dans le fichier de tuiles de jeu
        public const int IMAGE_WIDTH = 32, IMAGE_HEIGHT = 32;
        private const int TILE_LEFT = 0, TILE_TOP = 0;
        private const int SEPARATEUR_TILE = 0;

        // La valeur entière correspond "par hasard" à la position de l'image dans la List<TileCoord>
        public static int GRASS = 0;
        public static int FENCE1 = 1;
        public static int FENCE2 = 2;
        public static int PILLAR1 = 3;
        public static int PILLAR2 = 4;

        private static List<TileCoord> listeCoord = new List<TileCoord>();
        private static List<Bitmap> listeBitmap = new List<Bitmap>();

        /// <summary>
        /// Constructeur statique
        /// </summary>
        static TilesetImageGenerator()
        {
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 0 });
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 22 });
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 23 });
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 27 });
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 27 });

            listeBitmap.Add(LoadTile(GRASS)); 
            listeBitmap.Add(LoadTile(FENCE1)); 
            listeBitmap.Add(LoadTile(FENCE2));
            listeBitmap.Add(LoadTile(PILLAR1));
            listeBitmap.Add(LoadTile(PILLAR2));
        }

        private static Bitmap LoadTile(int posListe)
        {
            Image source = TP2.Properties.Resources.zoo_tileset;
            TileCoord coord = listeCoord[posListe];
            Rectangle crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_HEIGHT + SEPARATEUR_TILE), IMAGE_WIDTH, IMAGE_HEIGHT);

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        public static Bitmap GetTile(int posListe)
        {
            return listeBitmap[posListe];
        }

    }

    public class TileCoord
    {
        public int Ligne { get; set; }
        public int Colonne { get; set; }
    };
}

