using ClassLibraryExceptions.ExceptionsMontre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExceptions
{
    public class Montre
    {
        private int heures;

        private int minutes;

        public Montre()
        {
            heures = 0;
            minutes = 0;
        }

        public int Heures {
            get => heures;
            set
            {
                if (value <= 12 && value >= 0)
                {
                    heures = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("L'heure fournit est "+ value, "L'heure doit etre comprise entre 0 et 12!");
                }
            }
        }

        public int Minutes
        {
            get => minutes;
            set
            {
                if (value <= 59 && value >= 0)
                {
                    minutes = value;
                }
                else
                {
                    throw new MinutesOutORangeException( "Les minutes doivent etre comprise entre 0 et 59!");
                }
            }
        }

        public void Tic()
        {
            minutes++;
            if (minutes == 60)
            {
                minutes = 0;
                heures++;
            }
            if (heures == 12)
            {
                heures = 0;
            }
        }

        public override string ToString()
        {
            return "heure="+heures+" minute="+minutes;
        }
    }
}
