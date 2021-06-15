using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExemple
{
    public class Plante
    {
        private int taille;

        private Soleil sonSoleil;

        private Jardin leJardinDeLaPlante;

        public Plante(int taille, Soleil sonSoleil, Jardin leJardinDeLaPlante)
        {
            this.taille = taille;
            this.sonSoleil = sonSoleil;
            this.leJardinDeLaPlante = leJardinDeLaPlante;
        }
    }
}
