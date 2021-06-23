using ClassLibraryCompteAvecInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestCompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "la vie";
            string string2 = "la mort";
            int resultat = string1.CompareTo(string2);

            CompteBancaire crobert = new CompteBancaire(1234, "robert", 10, 0);
            CompteBancaire cjulie = new CompteBancaire(1234, "julie", 1, 0);
            int retour = crobert.CompareTo(cjulie);

            List<CompteBancaire> mescomptes = new List<CompteBancaire>();
            mescomptes.Add(crobert);
            mescomptes.Add(cjulie);
            mescomptes.Sort();

        }
    }
}
