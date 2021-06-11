using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.StadesDeEVolution
{
     class Chrysalide : StadeDEvolution
    {
        public override StadeDEvolution DonneLeProchainStade()
        {
            return new Papillon();
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je reste accroché");
        }
    }
}