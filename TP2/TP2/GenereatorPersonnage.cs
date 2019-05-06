using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace TP2
{
    class GenereatorPersonnage
    {
        public const int IMAGE_WIDTH = 32, IMAGE_HEIGHT = 32;
        private const int TILE_LEFT = 0, TILE_TOP = 0;
        private const int SEPARATEUR_TILE = 0;

        public static int homme1f = 0;
        public static int homme1b = 1;
        public static int homme1l = 2;
        public static int homme1dr = 3;
        public static int homme1ur = 4;
        public static int homme1lr1 = 5;
        public static int homme1lr2 = 6;
        public static int homme1rr1 = 7;
        public static int homme1rr2 = 8;
        public static int homme1r = 9;

        public static int homme21f = 10;
        public static int homme21b = 11;
        public static int homme21l = 12;
        public static int homme21dr = 13;
        public static int homme21ur = 14;
        public static int homme21lr1 = 15;
        public static int homme21lr2 = 16;
        public static int homme21rr1 = 17;
        public static int homme21rr2 = 18;
        public static int homme21r = 19;

        public static int femme1f = 20;
        public static int femme1b = 21;
        public static int femme1l = 22;
        public static int femme1dr = 23;
        public static int femme1ur = 24;
        public static int femme1lr1 = 25;
        public static int femme1lr2 = 26;
        public static int femme1rr1 = 27;
        public static int femme1rr2 = 28;
        public static int femme1r = 29;

        public static int femme21f = 30;
        public static int femme21b = 31;
        public static int femme21l = 32;
        public static int femme21dr = 33;
        public static int femme21ur = 34;
        public static int femme21lr1 = 35;
        public static int femme21lr2 = 36;
        public static int femme21rr1 = 37;
        public static int femme21rr2 = 38;
        public static int femme21r = 39;

        private static List<TileCoord> listeCoord = new List<TileCoord>();
        private static List<Bitmap> listeBitmap = new List<Bitmap>();

        private static Bitmap LoadTile(int posListe)
        {
            Image source = TP2.Properties.Resources.personnages;
            TileCoord coord = listeCoord[posListe];
            Rectangle crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_HEIGHT + SEPARATEUR_TILE), IMAGE_WIDTH, IMAGE_HEIGHT);

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }
        static GenereatorPersonnage()
        {
            // Homme 1 
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 0 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 1 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 2 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 3 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 4 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 5 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 6 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 7 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 8 });
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 9 });

            // Homme 2
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 0 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 1 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 2 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 3 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 4 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 5 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 6 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 7 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 8 });
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 9 });

            // Femme 1
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 0 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 1 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 2 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 3 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 4 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 5 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 6 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 7 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 8 });
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 9 });

            // Femme 2
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 0 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 1 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 2 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 3 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 4 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 5 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 6 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 7 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 8 });
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 9 });

            // Homme 1
            listeBitmap.Add(LoadTile(homme1f));
            listeBitmap.Add(LoadTile(homme1b));
            listeBitmap.Add(LoadTile(homme1l));
            listeBitmap.Add(LoadTile(homme1dr));
            listeBitmap.Add(LoadTile(homme1ur));
            listeBitmap.Add(LoadTile(homme1lr1));
            listeBitmap.Add(LoadTile(homme1lr2));
            listeBitmap.Add(LoadTile(homme1rr1));
            listeBitmap.Add(LoadTile(homme1rr2));
            listeBitmap.Add(LoadTile(homme1r));

            // Homme 2
            listeBitmap.Add(LoadTile(homme21f));
            listeBitmap.Add(LoadTile(homme21b));
            listeBitmap.Add(LoadTile(homme21l));
            listeBitmap.Add(LoadTile(homme21dr));
            listeBitmap.Add(LoadTile(homme21ur));
            listeBitmap.Add(LoadTile(homme21lr1));
            listeBitmap.Add(LoadTile(homme21lr2));
            listeBitmap.Add(LoadTile(homme21rr1));
            listeBitmap.Add(LoadTile(homme21rr2));
            listeBitmap.Add(LoadTile(homme21r));

            //Femme 1
            listeBitmap.Add(LoadTile(femme1f));
            listeBitmap.Add(LoadTile(femme1b));
            listeBitmap.Add(LoadTile(femme1l));
            listeBitmap.Add(LoadTile(femme1dr));
            listeBitmap.Add(LoadTile(femme1ur));
            listeBitmap.Add(LoadTile(femme1lr1));
            listeBitmap.Add(LoadTile(femme1lr2));
            listeBitmap.Add(LoadTile(femme1rr1));
            listeBitmap.Add(LoadTile(femme1rr2));
            listeBitmap.Add(LoadTile(femme1r));

            //Femme 2
            listeBitmap.Add(LoadTile(femme21f));
            listeBitmap.Add(LoadTile(femme21b));
            listeBitmap.Add(LoadTile(femme21l));
            listeBitmap.Add(LoadTile(femme21dr));
            listeBitmap.Add(LoadTile(femme21ur));
            listeBitmap.Add(LoadTile(femme21lr1));
            listeBitmap.Add(LoadTile(femme21lr2));
            listeBitmap.Add(LoadTile(femme21rr1));
            listeBitmap.Add(LoadTile(femme21rr2));
            listeBitmap.Add(LoadTile(femme21r));
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
