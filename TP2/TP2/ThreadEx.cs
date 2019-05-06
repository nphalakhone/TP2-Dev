using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace TP2
{
    public class ThreadEx
    {
        int comptDate;
        int moisDate;
        int anneeDate;
        string dates;
        FenetrePrincipale fp = new FenetrePrincipale();

        public ThreadEx()
        {
            dates = Enum.GetName(typeof(Date), 1);
            comptDate = 1;
            moisDate = 1;
            anneeDate = 2019;
        }

        public void ThreadDate()
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
            fp.LblDate.Text = comptDate + " " + dates + " " + anneeDate;
            comptDate++;
            Console.WriteLine("First Thread");
        }
    }
}