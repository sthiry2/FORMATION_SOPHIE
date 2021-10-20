using CoucheDomaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Production maProd = new Production("A", 100, 10);
            maProd.FinProduction += MaProd_FinProduction;
            maProd.NewBoxCreated += MaProd_NewBoxCreated;
            maProd.StateChanged += MaProd_StateChanged;

            maProd.Demarrer();

            Console.ReadKey();
        }
        

        private static void MaProd_StateChanged(Production sender, Production.EtatsProduction newState)
        {
            Console.WriteLine("L'état de la production a changé à: " + newState.ToString());
        }

        private static void MaProd_NewBoxCreated(Production sender)
        {
            Console.WriteLine("Le nombre de caisse est : " + sender.NbCaissesProduites);
        }

        private static void MaProd_FinProduction(Production sender)
        {
            Console.WriteLine("Production terminée !");
        }

    }
}
