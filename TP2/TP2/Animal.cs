using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP2
{
    public enum Animaux
    {
        Lion,
        Mouton,
        Grizzly,
        Rhinoceros,
        Licorne,
        Buffle
    };
    public class Animal
    {
        public int x { get; set; }
        public int y { get; set; }
        public Animaux TypeAnimal { get; set; }
        private int TempsGestation;
        private int TempsAvantAdulte;
        public int TempsAvantNourrir;
        public int TimePassedLastFed;
        public bool Genre; //true = M | false = F
        public bool Adulte; //true = adulte | false = bebe
        public bool Nourri; //true = nourri | false = faim
        public bool? AttendBebe; //doit être une femelle adulte, en présence d’un mâle adulte dans le même enclos

        public Image currentDir;

        public Animal(Animaux type, int x2, int y2)
        {
            TypeAnimal = type;
            x = x2;
            y = y2;
            Adulte = true;
            Nourri = true;

            Random rng = new Random();
            int randomGenre = rng.Next(0, 2);

            Genre = randomGenre == 0;

            switch (TypeAnimal)
            {
                case Animaux.Lion:
                    TempsGestation = 110;
                    TempsAvantAdulte = 110;
                    TempsAvantNourrir = 60;
                    currentDir = TestTilesetZoo.TilesetImageGenerator.GetTile(44);
                    break;
                case Animaux.Mouton:
                    TempsGestation = 150;
                    TempsAvantAdulte = 150;
                    TempsAvantNourrir = 60;
                    currentDir = TestTilesetZoo.TilesetImageGenerator.GetTile(45);
                    break;
                case Animaux.Grizzly:
                    TempsGestation = 220;
                    TempsAvantAdulte = 220;
                    TempsAvantNourrir = 60;
                    currentDir = TestTilesetZoo.TilesetImageGenerator.GetTile(46);
                    break;
                case Animaux.Rhinoceros:
                    TempsGestation = 480;
                    TempsAvantAdulte = 480;
                    TempsAvantNourrir = 90;
                    currentDir = TestTilesetZoo.TilesetImageGenerator.GetTile(47);
                    break;
                case Animaux.Licorne:
                    TempsGestation = 360;
                    TempsAvantAdulte = 360;
                    TempsAvantNourrir = 90;
                    currentDir = TestTilesetZoo.TilesetImageGenerator.GetTile(48);
                    break;
                case Animaux.Buffle:
                    TempsGestation = 340;
                    TempsAvantAdulte = 340;
                    TempsAvantNourrir = 90;
                    currentDir = TestTilesetZoo.TilesetImageGenerator.GetTile(49);
                    break;
            }

            if (Genre)
            {
                AttendBebe = null;
            }
            else
            {
                AttendBebe = false;
            }

            TimePassedLastFed = 1;
        }
    }
}
