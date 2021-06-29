using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    class De: IComparable<De>,IComparable
    {
        private const int NB_FACE = 6;
        private int valeur;

        public De()
        {
            //valeur = new Random().Next(1, NB_FACE + 1);
            //valeur = new Alea();//pas possible
            valeur = Alea.Instance().Nouveau(1, NB_FACE + 1);
        }

        public int Valeur
        {
            get => valeur;
     
        }

        public int CompareTo(De other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void SeJeter()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
