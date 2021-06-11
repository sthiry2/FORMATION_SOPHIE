using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.StadesDeEVolution
{
     class Chenille : StadeDEvolution
    {
        public override StadeDEvolution DonneLeProchainStade()
        {
            return new Chrysalide();
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je rampe");
        }
    }
}