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
    public partial class FenetrePrincipale : Form
    {
        Map m;
        int argent;
        int tempsMax = 300000; // 5 minustes in milliseconds

        public FenetrePrincipale()
        {
            InitializeComponent();
            m = MappeMonde;
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
            argent = int.Parse(LblArgent.Text);
            argent += 1;
            LblArgent.Text = argent.ToString();
        }

        private void TimerDate_Tick(object sender, EventArgs e)
        {

        }

        private void Mouse_Click_Animal(object sender, EventArgs e)
        {

        }
    }
}
