using NameSpaceTelevision.Aperos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceTelevision
{
    public class Television
    {
        Bretzel b;
        //attributs = champs/fields en C#
        private bool allume;
        private int diagonal;
        private int niveauDeSon;

        //constructeur(s)

        public Television() // par defaut
        {
            allume = false;
            diagonal = 17;
        }

        public Television(bool _allume,int _diagonal) // classique
        {
            this.allume = _allume;
            diagonal = _diagonal;
        }

        //operation = methode en C#

        public void Allumer()
        {
            this.allume = true;
        }

        public void Eteindre()
        {
            allume = false;
        }


        public override string ToString()
        {
            return base.ToString()+ " allume="+allume+" diagonal="+diagonal;
        }






    }
}
