using ClassLibraryVoiture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture maTitine;
            maTitine = new Voiture();
            //maTitine.Demarrer();

            Voiture deuxiemeTitine = new Voiture(maTitine);

        }
    }
}
