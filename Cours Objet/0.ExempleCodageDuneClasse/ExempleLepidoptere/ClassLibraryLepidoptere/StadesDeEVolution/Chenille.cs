using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.StadesDeEVolution
{
    public class Chenille : StadeDEvolution
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Je rampe");
        }
    }
}