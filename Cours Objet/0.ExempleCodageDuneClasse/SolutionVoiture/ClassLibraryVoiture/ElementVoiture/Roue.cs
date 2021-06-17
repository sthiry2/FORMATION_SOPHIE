using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture.ElementVoiture
{
    class Roue: ICloneable
    {
        private bool tourne;
        private int diametre;

        public Roue()//default
        {
            tourne = false;
            diametre = 17;
        }

        public Roue(bool tourne, int diametre)//classique
        {
            this.tourne = tourne;
            this.diametre = diametre;
        }

        public Roue(int diametre) //melange classique et default
        {
            this.tourne = false;
            this.diametre = diametre;
        }

        public Roue(Roue _roueARecopier)//recopie
        {
            this.tourne = _roueARecopier.tourne;
            this.diametre = _roueARecopier.diametre;
        }

        public object Clone()
        {
            return new Roue(this);
        }

        public bool Tourner()
        {
            bool ok = false;
            if (!tourne)
            {
                tourne = true;
                ok = true;
            }
            return ok;
        }
    }
}
