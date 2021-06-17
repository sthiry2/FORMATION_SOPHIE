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

        public bool EntrainerRoues(Roue _roueMotrice1, Roue _roueMotrice2)
        {
            bool ok=false;
            if (estDemarre)
            {
                bool okRoue1 = _roueMotrice1.Tourner();
                bool okRoue2 = _roueMotrice2.Tourner();
                ok = okRoue1 && okRoue2;
            }

            return ok;
        }

        public bool Demarrer()
        {
            bool ok=false;

            if (!estDemarre)
            {
                ok = true;
                estDemarre = true;
            }

           return ok;
        }
    }
}
