using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    abstract class Animal
    {
        public int nbAnimaux { get; set; }
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

        public Animal(string type, int gestation, int avAdulte, int avNourrir, bool? genre, bool? adulte, bool? nourri, bool? attendBebe)
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
