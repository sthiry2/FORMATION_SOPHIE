using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Moteur
    {
        private bool enMarche;

        public bool EnMarche { get => enMarche; private set => enMarche = value; }

        public Moteur():this(false)
        {
        }

        public Moteur(bool enMarche)
        {
            this.enMarche = enMarche;
        }

        public Moteur(Moteur moteurACloner)
            : this(moteurACloner.enMarche)
        {
        }

        public bool Demarrer()
        {
            if (!enMarche)
            {
                enMarche = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EntrainerRoues(Roue roue1,Roue roue2)
        {
            if (enMarche)
            {
                return roue1.Tourner() && roue2.Tourner();
            }
            return false;
        }

    }
}
