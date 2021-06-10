using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.StadesDeEVolution
{
    public abstract class StadeDEvolution
    {
        public abstract void SeDeplacer();
        public abstract StadeDEvolution DonneLeProchainStade();
    }
}