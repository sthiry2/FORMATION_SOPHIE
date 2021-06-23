using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExempleInterface
{
    public class Robot : IParlable, IParlerEnAnglais
    {
        void IParlable.Parler()
        {
            Console.WriteLine("Bip ! Bip!");
        }

        void IParlerEnAnglais.Parler()
        {
            Console.WriteLine("Beep ! Beep!");
        }

        public void Calculer()
        { 
        }
    }
}
