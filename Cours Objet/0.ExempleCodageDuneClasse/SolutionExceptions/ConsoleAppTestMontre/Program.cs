using ClassLibraryExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestMontre
{
    class Program
    {
        static void Main(string[] args)
        {
            Montre maMontre = new Montre();
            Console.WriteLine(maMontre);

            /*for (int i = 0; i < 12 * 60; i++)
            {
                maMontre.Tic();
                Console.WriteLine(maMontre);
            }*/
            maMontre.Minutes = 100;
        }
    }
}
