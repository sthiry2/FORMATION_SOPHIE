using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPassageDuneFenetreALautre
{
    public class LeTexteARecupererEstValideEventArgs : EventArgs
    {
        private int lgTexte;

        public LeTexteARecupererEstValideEventArgs(int lgTexte):base()
        {
            this.lgTexte = lgTexte;
        }

        public int LgTexte { get => lgTexte; /*set => lgTexte = value;*/ }
    }
}
