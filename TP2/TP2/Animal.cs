﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    enum Animaux
    {
        Lion,
        Mouton,
        Grizzly,
        Rhinoceros,
        Licorne,
        Buffle
    };
    class Animal
    {
        public static int nbAnimaux { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        private string TypeAnimal;
        private int TempsGestation;
        private int TempsAvantAdulte;
        private int TempsAvantNourrir;
        private bool? Genre; //true = M | false = F
        private bool? Adulte; //true = adulte | false = bebe
        private bool? Nourri; //true = nourri | false = faim
        private bool? AttendBebe; //doit être une femelle adulte, en présence d’un mâle adulte dans le même enclos

        public Animal()
        {
            nbAnimaux = 0;
        }

        public Animal(string type, int gestation, int avAdulte, int avNourrir, bool? genre, bool? adulte, bool? nourri, bool? attendBebe, int x, int y)
        {
            TypeAnimal = type;
            TempsGestation = gestation;
            TempsAvantAdulte = avAdulte;
            TempsAvantNourrir = avNourrir;
            Genre = genre;
            Adulte = adulte;
            Nourri = nourri;
            AttendBebe = attendBebe;
            nbAnimaux++;
        }
    }
}
