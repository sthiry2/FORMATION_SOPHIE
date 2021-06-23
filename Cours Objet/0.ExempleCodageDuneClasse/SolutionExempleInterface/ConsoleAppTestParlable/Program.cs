using ClassLibraryExempleInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestParlable
{
    class Program
    {
        static void Main(string[] args)
        {
            Perroquet p = new Perroquet();
            p.Parler();


            Robot r = new Robot();
            ((IParlerEnAnglais)r).Parler();
            r.Calculer();

            IParlerEnAnglais r2 = new Robot();
            r2.Parler();
            ///r2.Calculer(); n'est pas vu car uniquement vu comme IParlerEnAnglais
            ///

            object o = new Robot();
            //o.Calculer();
        }
    }
}
