using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExempleInterface
{
    public class Perroquet : IParlable,IParlerEnAnglais
    {
        public void Parler()
        {
            Console.WriteLine("Coco!");
        }
    }
}
