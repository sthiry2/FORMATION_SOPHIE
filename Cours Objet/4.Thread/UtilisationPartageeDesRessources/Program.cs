using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UtilisationPartageeDesRessources
{
    class Program
    {
        public static MaRessource res;

        static void Main(string[] args)
        {
            res = new MaRessource();

            Thread t1 = new Thread(new ThreadStart(Program.Th1));
            t1.Start();

            lock (res)
            {
                res.MaVar = 10;
                Console.Out.WriteLine(DateTime.Now.ToString("[1] hh:mm:ss Var=") + res.MaVar);
                Thread.Sleep(2000);
            }

            lock (res)
            {
                res.MaVar = 20;
                Console.Out.WriteLine(DateTime.Now.ToString("[3] hh:mm:ss Var=") + res.MaVar);
            }

            Console.In.ReadLine();
        }

        public static void Th1()
        {
            Thread.Sleep(10);
            lock (res)
            {
                res.MaVar = 50;
                Console.Out.WriteLine(DateTime.Now.ToString("[2] hh:mm:ss Var=") + res.MaVar);
            }
        }
    }
}
