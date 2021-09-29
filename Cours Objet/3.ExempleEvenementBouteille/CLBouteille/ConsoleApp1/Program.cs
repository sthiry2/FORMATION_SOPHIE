using CLBouteille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CLBouteille.Bouteille;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouteille b = new Bouteille();
            //b.EstOuvertPourLaPremierFois += B_EstOuvertPourLaPremierFois;   
            //b.EstOuvertPourLaPremierFois += new DelegateEstOuvertPourLaPremierFois(b_EstOuvertPourLaPremierFois);
            b.Ouvrir();
        }

        private static void B_EstOuvertPourLaPremierFois(decimal _contenanceEnL)
        {
            Console.WriteLine("A-Tu peux boire " + _contenanceEnL + " litre.. A la tienne!");
        }

        private static void b_EstOuvertPourLaPremierFois(decimal _contenanceEnL)
        {
            Console.WriteLine("B- Tu peux boire " + _contenanceEnL + " litre.. A la tienne!");
        }
    }
}
