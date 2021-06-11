using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.StadesDeEVolution
{
     class Papillon : StadeDEvolution
    {

        const int nbAiles = 2;

        public override StadeDEvolution DonneLeProchainStade()
        {
            return this;
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je vole");
        }

        public override string ToString()
        {
            return base.ToString() + " nbAiles="+ nbAiles;
        }
    }
}