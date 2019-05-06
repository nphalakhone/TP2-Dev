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
        public static int HOUSE = 5; //Goes from 5 to 24
        public static int WELL = 25; //Goes from 25 to 33
        public static int BENCH1 = 34; 
        public static int BENCH2 = 37;
        public static int APPLE = 39;
        public static int ROAD1 = 41;
        public static int TRASH = 42;
        public static int GATE = 43;
        public static int LION = 44;
        public static int SHEEP = 45;
        public static int GRIZZLY = 46;
        public static int RHINO = 47;
        public static int UNICORN = 48;
        public static int BUFFALO = 49;



        private static List<TileCoord> listeCoord = new List<TileCoord>();
        private static List<Bitmap> listeBitmap = new List<Bitmap>();

        private static int[,] gridHouse = new int[4, 5];
        private static int[,] gridWell = new int[3, 3];
        private static int[] bench1 = new int[3];
        private static int[] bench2 = new int[2];
        private static int[] apple = new int[2];

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

            for (int i = 0; i < gridHouse.GetLength(0); i++)
            {
                for (int j = 0; j < gridHouse.GetLength(1); j++)
                {
                    listeCoord.Add(new TileCoord() { Ligne = j, Colonne = i + 18 });
                    listeBitmap.Add(LoadTile(HOUSE));
                    HOUSE++;
                }
            }

            for (int i = 0; i < gridWell.GetLength(0); i++)
            {
                for (int j = 0; j < gridWell.GetLength(1); j++)
                {
                    listeCoord.Add(new TileCoord() { Ligne = j + 13, Colonne = i + 24 });
                    listeBitmap.Add(LoadTile(WELL));
                    WELL++;
                }
            }

            for (int i = 0; i < bench1.GetLength(0); i++)
            {
                listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = i + 24 });
                listeBitmap.Add(LoadTile(BENCH1));
                BENCH1++;
            }

            for (int i = 0; i < bench2.GetLength(0); i++)
            {
                listeCoord.Add(new TileCoord() { Ligne = i + 5, Colonne = 24 });
                listeBitmap.Add(LoadTile(BENCH2));
                BENCH2++;
            }

            for (int i = 0; i < apple.GetLength(0); i++)
            {
                listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = i + 22 });
                listeBitmap.Add(LoadTile(APPLE));
                APPLE++;
            }

            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 22 });
            

            listeBitmap.Add(LoadTile(ROAD1));

            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 28 });

            listeBitmap.Add(LoadTile(TRASH));

            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 24 });

            listeBitmap.Add(LoadTile(GATE));

            listeCoord.Add(new TileCoord() { Ligne = 16, Colonne = 24 });

            listeBitmap.Add(LoadTile(LION));

            listeCoord.Add(new TileCoord() { Ligne = 19, Colonne = 8 });

            listeBitmap.Add(LoadTile(SHEEP));

            listeCoord.Add(new TileCoord() { Ligne = 16, Colonne = 0 });

            listeBitmap.Add(LoadTile(GRIZZLY));

            listeCoord.Add(new TileCoord() { Ligne = 20, Colonne = 16 });

            listeBitmap.Add(LoadTile(RHINO));

            listeCoord.Add(new TileCoord() { Ligne = 16, Colonne = 16 });

            listeBitmap.Add(LoadTile(UNICORN));

            listeCoord.Add(new TileCoord() { Ligne = 19, Colonne = 0 });

            listeBitmap.Add(LoadTile(BUFFALO));
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

