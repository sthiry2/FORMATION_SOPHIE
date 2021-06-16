using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture.ElementVoiture
{
    class Moteur
    {
        private bool estDemarre;
        private int nbCV;

        public Moteur()
        :this(false,4)
        {
        }

        public Moteur(bool estDemarre, int nbCV)
        {
            this.estDemarre = estDemarre;
            this.nbCV = nbCV;
        }

        public Moteur(int nbCV)
        :this(false,nbCV)
        {
        }

        public Moteur(Moteur _moteurARecopier)
            :this(_moteurARecopier.estDemarre,_moteurARecopier.nbCV)
        {
        }


    }
}
