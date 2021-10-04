using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTraceSesErreurs
{

    // https://docs.microsoft.com/fr-fr/dotnet/api/system.diagnostics.trace?view=netcore-3.1

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Trace.WriteLine("Debut du code!");
                int a=5;
                int b=0;
                int c = a / b;
            }
            catch (Exception e)
            {
                Trace.TraceError(e.Message);
                
            }
        }
    }
}
