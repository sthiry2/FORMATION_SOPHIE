using NameSpaceTelevision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTelevision
{
    class Program
    {
        static void Main(string[] args)
        {
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
