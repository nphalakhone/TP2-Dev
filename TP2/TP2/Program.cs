using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TP2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenetrePrincipale());

            //ThreadEx th = new ThreadEx();

            //Thread thr = new Thread(new ThreadStart(th.ThreadDate));
            //thr.Start();
        }
    }
}
