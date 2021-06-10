using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class PapillonAvecUneAileEnMoins : StadesDeEVolution.StadeDEvolution
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Je vole de travers");
        }
    }
}