using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    enum Date
    {
        Janvier = 1,
        Fevrier,
        Mars,
        Avril,
        Mai,
        Juin,
        Juillet,
        Aout,
        Septembre,
        Octobre,
        Novembre,
        Decembre
    };

    public partial class FenetrePrincipale : Form
    {
        Map m;
        int argent;
        int tempsMax = 300000; // 5 minustes in milliseconds
        int comptDate;
        int moisDate;
        int anneeDate;
        string dates;
        int tempsPasser;
        int lion = 0;
        int mouton = 0;
        int grizzly = 0;
        int rhino = 0;
        int licorne = 0;
        int buffle = 0;
        Animal animal;
        Visiteur visiteur;

        public FenetrePrincipale()
        {
            InitializeComponent();
            InitializeBtnAchat();
            m = MappeMonde;
            dates = Enum.GetName(typeof(Date), 1);
            comptDate = 1;
            moisDate = 1;
            anneeDate = 2019;
            argent = 100000;/*ConvertLabelToInt(LblArgent);*/
            PicConcierge.Image = GeneratorPersonnage.GetTile(40);
            tempsPasser = 0;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void InitializeBtnAchat()
        {
            BtnAchatLion.Click += (sender, EventArgs) => { Acheter_Animal_Click(sender, EventArgs, LblPrixLion.Text, "Lion"); };
            BtnAchatMouton.Click += (sender, EventArgs) => { Acheter_Animal_Click(sender, EventArgs, LblPrixMouton.Text, "Mouton"); };
            BtnAchatGrizzly.Click += (sender, EventArgs) => { Acheter_Animal_Click(sender, EventArgs, LblPrixGrizzly.Text, "Grizzly"); };
            BtnAchatRhino.Click += (sender, EventArgs) => { Acheter_Animal_Click(sender, EventArgs, LblPrixRhino.Text, "Rhino"); };
            BtnAchatLicorne.Click += (sender, EventArgs) => { Acheter_Animal_Click(sender, EventArgs, LblPrixLicorne.Text, "Licorne"); };
            BtnAchatBuffle.Click += (sender, EventArgs) => { Acheter_Animal_Click(sender, EventArgs, LblPrixBuffle.Text, "Buffle"); };

            BtnAchatLion.Enabled = false;
            BtnAchatMouton.Enabled = false;
            BtnAchatGrizzly.Enabled = false;
            BtnAchatRhino.Enabled = false;
            BtnAchatLicorne.Enabled = false;
            BtnAchatBuffle.Enabled = false;

            BtnEngageConcierge.Enabled = false;
        }

        private void TimerPrincipal_Tick(object sender, EventArgs e)
        {
            if ((comptDate == 32 && dates.Equals(Date.Janvier.ToString()))
                || (comptDate == 32 && dates.Equals(Date.Mars.ToString()))
                || (comptDate == 32 && dates.Equals(Date.Mai.ToString()))
                || (comptDate == 32 && dates.Equals(Date.Juillet.ToString()))
                || (comptDate == 32 && dates.Equals(Date.Aout.ToString()))
                || (comptDate == 32 && dates.Equals(Date.Octobre.ToString()))
                || (comptDate == 31 && dates.Equals(Date.Avril.ToString()))
                || (comptDate == 31 && dates.Equals(Date.Juin.ToString()))
                || (comptDate == 31 && dates.Equals(Date.Septembre.ToString()))
                || (comptDate == 31 && dates.Equals(Date.Novembre.ToString()))
                || (comptDate == 29 && dates.Equals(Date.Fevrier.ToString())))
            {
                comptDate = 1;
                moisDate += 1;
                dates = Enum.GetName(typeof(Date), moisDate);
            }
            else if (comptDate == 32 && dates.Equals(Date.Decembre.ToString()))
            {
                comptDate = 1;
                moisDate = 1;
                anneeDate += 1;
                dates = Enum.GetName(typeof(Date), moisDate);
            }

            lion = 0;
            mouton = 0;
            grizzly = 0;
            rhino = 0;
            licorne = 0;
            buffle = 0;

            foreach (Animal a in m.listeAnimaux)
            {
                switch (a.TypeAnimal)
                {
                    case Animaux.Lion:
                        lion++;
                        LblQtLion.Text = lion.ToString();
                        break;
                    case Animaux.Mouton:
                        mouton++;
                        LblQtMouton.Text = mouton.ToString();
                        break;
                    case Animaux.Grizzly:
                        grizzly++;
                        LblQtGrizzly.Text = grizzly.ToString();
                        break;
                    case Animaux.Rhinoceros:
                        rhino++;
                        LblQtRhino.Text = rhino.ToString();
                        break;
                    case Animaux.Licorne:
                        licorne++;
                        LblQtLicorne.Text = licorne.ToString();
                        break;
                    case Animaux.Buffle:
                        buffle++;
                        LblQtBuffle.Text = buffle.ToString();
                        break;
                }
            }

            if (m.placeListeAnimal != 999)
            {
                animal = m.listeAnimaux.ElementAt(m.placeListeAnimal);
                LblInfoType.Text = "Type: " + animal.TypeAnimal.ToString();
                if (animal.Genre)
                {
                    LblInfoGenreA.Text = "Genre: Male";
                    LblInfoEnceinte.Text = "Enceinte : Null";
                }
                else
                {
                    LblInfoGenreA.Text = "Genre: Femelle";
                    if (animal.AttendBebe == true)
                    {
                        LblInfoEnceinte.Text = "Enceinte : Oui";
                    }
                    else
                    {
                        LblInfoEnceinte.Text = "Enceinte : Non";
                    }
                }
                if (animal.Adulte)
                {
                    LblInfoAgeA.Text = "Age: Adulte";
                }
                else
                {
                    LblInfoAgeA.Text = "Age: Bebe";
                }
                if (animal.Nourri)
                {
                    LblInfoFaim.Text = "Besoin d'être nourri : Non";
                }
                else
                {
                    LblInfoFaim.Text = "Besoin d'être nourri : Oui";
                }

                switch (animal.TypeAnimal)
                {
                    case Animaux.Lion:
                        PicInfoAnimal.Image = Properties.Resources.lion1;
                        break;
                    case Animaux.Mouton:
                        PicInfoAnimal.Image = Properties.Resources.sheep;
                        break;
                    case Animaux.Grizzly:
                        PicInfoAnimal.Image = Properties.Resources.grizzly;
                        break;
                    case Animaux.Rhinoceros:
                        PicInfoAnimal.Image = Properties.Resources.rhino;
                        break;
                    case Animaux.Licorne:
                        PicInfoAnimal.Image = Properties.Resources.licorne;
                        break;
                    case Animaux.Buffle:
                        PicInfoAnimal.Image = Properties.Resources.buffalo;
                        break;
                }
            }

            if (m.placeListeVisiteur != 999)
            {
                visiteur = m.listeVisiteur.ElementAt(m.placeListeVisiteur);
                LblInfoNomVis.Text = "Nom: " + visiteur.prenom + " " + visiteur.nom;
                if (visiteur.genre)
                {
                    LblInfoGenreVis.Text = "Sexe: Homme";
                }
                else
                {
                    LblInfoGenreVis.Text = "Sexe: Femme";
                }
                LblInfoTempsPasserVis.Text = "Temps passé depuis arrivé : " + (visiteur.tempsPasserV) + " jours";

                PicInfoVis.Image = visiteur.currentDir;
            }

            LblAnimal.Text = "Animaux : " + m.listeAnimaux.Count;
            LblDechets.Text = "Dechets : " + m.listeTrash.Count;

            LblDate.Text = comptDate + " " + dates + " " + anneeDate;
            comptDate++;
            tempsPasser++;
        }

        private void TimerAnimaux_Tick(object sender, EventArgs e)
        {

        }

        private void TimerVisiteurEtConcierge_Tick(object sender, EventArgs e)
        {
            int tempXV;
            int tempYV;
            int tempXC;
            int tempYC;
            foreach (Visiteur v in m.listeVisiteur)
            {
                tempXV = v.x;
                tempYV = v.y;
                                
                while (tempXV == v.x && tempYV == v.y)
                {
                    m.DeplacementAI(v);
                }                

                v.tempsPasserV++;

                Random r = new Random();
                int dropT = r.Next(1, 11);

                if (dropT == 1)
                {
                    v.dropDechet = true;
                }
                else
                {
                    v.dropDechet = false;
                }

                m.dropTrash(v);
            }

            foreach (Concierge c in m.listeConcierge)
            {
                tempXC = c.x;
                tempYC = c.y;

                while (tempXC == c.x && tempYC == c.y)
                {
                    m.deplacementConcierge(c); ;
                }
                
            }
        }

        private void Acheter_Animal_Click(object sender, EventArgs e, string prix, string nomAnimal)
        {
            string resultatString = new String(prix.Where(Char.IsDigit).ToArray());
            int price = Convert.ToInt32(resultatString);
            if ((argent - price) >= 0)
            {
                m.animalChoisi = nomAnimal;
                argent = argent - price;
                if (m.placedAnimal == true)
                {
                    LblArgent.Text = "" + argent;
                    m.placedAnimal = false;
                }
            }
        }

        private void Enable_Btn_Animal(bool b)
        {
            if (b)
            {
                BtnAchatLion.Enabled = true;
                BtnAchatMouton.Enabled = true;
                BtnAchatGrizzly.Enabled = true;
                BtnAchatRhino.Enabled = true;
                BtnAchatLicorne.Enabled = true;
                BtnAchatBuffle.Enabled = true;

                BtnEngageConcierge.Enabled = false;
            }
            else
            {
                BtnAchatLion.Enabled = false;
                BtnAchatMouton.Enabled = false;
                BtnAchatGrizzly.Enabled = false;
                BtnAchatRhino.Enabled = false;
                BtnAchatLicorne.Enabled = false;
                BtnAchatBuffle.Enabled = false;
            }
        }

        private void MappeMonde_KeyUp(object sender, KeyEventArgs e)
        {
            m.faireDeplacementHero(e);
            Enable_Btn_Janitor(m.heroOnlyArea);
            Enable_Btn_Animal(m.enableBuyAnimals);
        }

        private void Enable_Btn_Janitor(bool heroOnlyArea)
        {
            BtnEngageConcierge.Enabled = !heroOnlyArea;
        }

        private int ConvertLabelToInt(Label l)
        {
            string resultatString = new String(l.Text.Where(Char.IsDigit).ToArray());
            int i = Convert.ToInt32(resultatString);
            return i;
        }

        private void Acheter_Concierge_Click(object sender, EventArgs e)
        {
            m.conciergeChoisi = true;
        }
    }
}
