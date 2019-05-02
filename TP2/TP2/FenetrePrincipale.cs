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

        public FenetrePrincipale()
        {
            InitializeComponent();
            m = MappeMonde;
            dates = Enum.GetName(typeof(Date), 1);
            comptDate = 1;
            moisDate = 1;
            anneeDate = 2019;
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


        private void MappeMonde_KeyDown(object sender, KeyEventArgs e)
        {
            m.faireDeplacement(e);
        }

        private void TimerPrincipal_Tick(object sender, EventArgs e)
        {
            //argent = int.Parse(LblArgent.Text);
            //argent += 1;
            //LblArgent.Text = argent.ToString();
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
            }   else if (comptDate == 32 && dates.Equals(Date.Decembre.ToString()))
            {
                comptDate = 1;
                moisDate = 1;
                anneeDate += 1;
                dates = Enum.GetName(typeof(Date), moisDate);
            }
            LblDate.Text = comptDate + " " + dates + " " + anneeDate;
            comptDate++;
        }

        private void Mouse_Click_Animal(object sender, EventArgs e)
        {

        }
    }
}
