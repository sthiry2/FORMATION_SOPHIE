using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Roue
    {
        private string dimensionPneuReglementaire;
        bool tourne;

        public string DimensionPneu { get => dimensionPneuReglementaire; private set => dimensionPneuReglementaire = value; }
        public bool Tourne { get => tourne; private set => tourne = value; }

        public Roue()
            : this("205/55R16 91V")
        {
            
        }

        public Roue(string dimensionPneu, bool tourne)
        {
            this.dimensionPneuReglementaire = dimensionPneu;
            this.tourne = tourne;
        }

        public Roue(string dimensionPneu)
        {
            this.dimensionPneuReglementaire = dimensionPneu;
            this.tourne = false;
        }

        public Roue(Roue roueACloner)
            : this(roueACloner.dimensionPneuReglementaire,roueACloner.tourne)
        {
        }

        public bool Tourner()
        {
            if (!tourne)
            {
                tourne = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Stopper()
        {
            if (tourne)
            {
                tourne = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
