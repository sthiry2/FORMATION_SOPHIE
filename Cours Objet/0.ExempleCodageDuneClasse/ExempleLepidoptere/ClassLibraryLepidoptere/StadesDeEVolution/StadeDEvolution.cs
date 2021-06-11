using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.StadesDeEVolution
{
     abstract class StadeDEvolution
    {
        public abstract void SeDeplacer();
        public abstract StadeDEvolution DonneLeProchainStade();

        public override string ToString()
        {
            return base.ToString() /*attributs*/;
        }
    }
}