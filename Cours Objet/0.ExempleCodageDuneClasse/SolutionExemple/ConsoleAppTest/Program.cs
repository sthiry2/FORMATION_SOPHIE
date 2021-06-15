using ClassLibraryExemple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Soleil s = new Soleil();

            // cas bidirectionnel!

            Jardin monJardinAMoi = new Jardin();

            Plante p = new Plante(10, new Soleil(), monJardinAMoi);

            monJardinAMoi.AddPlante(p);
        }
    }
}
