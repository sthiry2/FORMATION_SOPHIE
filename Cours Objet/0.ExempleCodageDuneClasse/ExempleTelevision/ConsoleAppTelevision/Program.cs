using NameSpaceTelevision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
sing NameSpaceTelevision.Aperos;

namespace ConsoleAppTelevision
{
    class Program
    {
        static void Main(string[] args)
        {
            Bretzel b;

            Television laTeleDuSalon;//declaration
            laTeleDuSalon = new Television();// initialisation par instanciation

            Television laTeleDuSalon2;//declaration
            laTeleDuSalon2 = new Television(true,20);// initialisation par instanciation   


            Console.WriteLine(laTeleDuSalon.ToString());


            laTeleDuSalon.Allumer();


            Console.WriteLine(laTeleDuSalon.ToString());

        }
    }
}
