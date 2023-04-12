using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametry_kvádru
{
    public class Kvádr
    {
        public double stranaA { get; set; }
        public double stranaB { get; set; }
        public double stranaC { get; set; }

        public Kvádr(double a, double b, double c)
        {
            stranaA = a;
            stranaB = b;
            stranaC = c;
        }

        public double objem()
        {
            double vysledekObjem = (stranaA * stranaB * stranaC);
            return vysledekObjem;
        }
        public double povrch()
        {
            double vysledekPovrch = (2 * (stranaA * stranaB + stranaA * stranaC + stranaB * stranaC));
            return vysledekPovrch;
        }
        public double telesovaUhlopricka()
        {
            double vysledekTelesovaUhlopricka = (Math.Sqrt(stranaA * stranaA + stranaB * stranaB + stranaC * stranaC));
            return vysledekTelesovaUhlopricka;
        }
        public double stenovaUhlopricka()
        {
            double vysledeStenovaUhlopricka = (Math.Sqrt(stranaA * stranaA + stranaB * stranaB));
            return vysledeStenovaUhlopricka;
        }
    }
  
}
