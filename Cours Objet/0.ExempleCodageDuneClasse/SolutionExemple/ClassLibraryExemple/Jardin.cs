using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryExemple
{
    public class Jardin
    {
        private List<Plante> mesPlantesDuJardin;
    

        public void AddPlante(Plante plante)
        {
            mesPlantesDuJardin.Add(plante);
        }
    }
}