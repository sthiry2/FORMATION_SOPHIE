using ClassLibraryLepidoptere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLepidoptere
{
    class Program
    {
        static void Main(string[] args)
        {

            Lepidoptere beatrice;
            beatrice = new Lepidoptere("Bea");

            beatrice.SeDeplacer();
            //faire evoluer
            //puis
            beatrice.SeDeplacer();

            //faire evoluer
            beatrice.SeTransformer();
            //puis
            beatrice.SeDeplacer();

            //faire evoluer
            beatrice.SeTransformer();
            //puis
            beatrice.SeDeplacer();

            //faire evoluer
            beatrice.SeTransformer();
            //puis
            beatrice.SeDeplacer();


            Console.WriteLine(beatrice.ToString());



        }
    }
}
