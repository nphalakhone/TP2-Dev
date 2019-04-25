using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FenetrePrincipale : Form
    {
        Map m;
        public FenetrePrincipale()
        {
            InitializeComponent();
            int argent = 100;
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
    }
}
