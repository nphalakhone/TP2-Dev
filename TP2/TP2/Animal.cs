using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    abstract class Animal
    {
        private int Prix;
        private int TempsGestation;
        private int TempsAvantAdulte;
        private int TempsAvantNourrir;
        private bool? Genre; //true = M | false = F
        private bool? Adulte; //true = adulte | false = bebe
        private bool? Nourri; //true = nourri | false = faim
        private bool? AttendBebe; //doit être une femelle adulte, en présence d’un mâle adulte dans le même enclos

        public Animal(int prix, int gestation, int avAdulte, int avNourrir, bool? genre, bool? adulte, bool? nourri, bool? attendBebe)
        {
            Prix = prix;
            TempsGestation = gestation;
            TempsAvantAdulte = avAdulte;
            TempsAvantNourrir = avNourrir;
            Genre = genre;
            Adulte = adulte;
            Nourri = nourri;
            AttendBebe = attendBebe;
        }
    }
}
