using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompteAvecInterface
{
    public class CompteBancaire:IComparable,IComparable<CompteBancaire> //Realisation d'interface
    {

        private uint numeroCompte;
        private string nomProprietaire;
        private int soldeCompte;
        private int decouvertAutorise;


        /// 
        /// <param name="_numeroCompte"></param>
        /// <param name="_nomProprietaire"></param>
        /// <param name="_soldeCompte"></param>
        /// <param name="_decouvertAutorise"></param>
        public CompteBancaire(uint _numeroCompte, string _nomProprietaire, int _soldeCompte, int _decouvertAutorise)
        {
            this.numeroCompte = _numeroCompte;
            this.nomProprietaire = _nomProprietaire;
            this.soldeCompte = _soldeCompte;
            this.decouvertAutorise = _decouvertAutorise;

        }

        public override string ToString()
        {

            return "numéro : " + numeroCompte + " nom : " + nomProprietaire + " solde : " + soldeCompte + " découvert autorisé : " + decouvertAutorise;
        }

        /// 
        /// <param name="montant"></param>
        public void Crediter(int _montant)
        {
            soldeCompte += _montant;
        }

        /// 
        /// <param name="montant"></param>
        public bool Debiter(int _montant)
        {
            bool ok = false;
            if ((soldeCompte - _montant) > decouvertAutorise)
            {

                soldeCompte -= _montant;
                ok = true;

            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// 
        /// <param name="_montant"></param>
        /// <param name="_autreCompte"></param>
        public bool Transferer(int _montant, CompteBancaire _autreCompte)
        {
            bool ok = false;
            if ((soldeCompte - _montant) > decouvertAutorise)
            {
                Debiter(_montant);
                _autreCompte.Crediter(_montant);
                ok = true;
            }
            else
            {
                ok = false;
            }
            return ok;
        }




        /// 
        /// <param name="_autreCompte"></param>
        public bool SuperieurAutreCompte(CompteBancaire _autreCompte)
        {
            bool ok = false;
            if (this.CompareTo(_autreCompte)==1)
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        public int CompareTo(object obj)
        {
            //obj n'est typé
            //CompteBancaire autreCompte = (CompteBancaire)obj;
            CompteBancaire autreCompte = obj as CompteBancaire;

            if (autreCompte == null)
            {
                throw new ArgumentException("Obj n'est pas du type attendu CompteBancaire");
            }
  
            //if (this.soldeCompte < autreCompte.soldeCompte)
            //{
            //    return -1;
            //}
            //else if (this.soldeCompte > autreCompte.soldeCompte)
            //{
            //    return 1;
            //}
            //else
            //{ 
            //    return 0;
            //}


            return this.soldeCompte.CompareTo(autreCompte.soldeCompte);
        }


       /* public int CompareTo(object obj)
        {
            //obj n'est typé
            //CompteBancaire autreCompte = (CompteBancaire)obj;
            CompteBancaire autreCompte = obj as CompteBancaire;

            if (autreCompte == null)
            {
                throw new ArgumentException("Obj n'est pas du type attendu CompteBancaire");
            }
            return this.CompareTo(autreCompte);
        }*/

        public int CompareTo(CompteBancaire other)
        {
            return this.soldeCompte.CompareTo(other.soldeCompte);
        }
    }
}
