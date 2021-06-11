using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.StadesDeEVolution
{
     class Oeuf : StadeDEvolution
    {
        public override StadeDEvolution DonneLeProchainStade()
        {
            return new Chenille();
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne sais pas me deplacer");
        }

        //public override string SeDeplacer()
        //{
        //    return "Je ne sais pas me deplacer";
        //}

        public override string ToString()
        {
            return base.ToString();
        }
    }

   
}