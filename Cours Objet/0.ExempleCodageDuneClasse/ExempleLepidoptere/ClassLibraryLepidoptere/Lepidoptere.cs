using ClassLibraryLepidoptere.StadesDeEVolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        string nom;
        StadeDEvolution stadeCourant;

        public Lepidoptere(string _nom)
        {
            this.nom = _nom;
            stadeCourant = new Oeuf();
        }

        public void SeDeplacer()
        {
            stadeCourant.SeDeplacer();
        }

        //solution pas object car utilise pas le polymorphisme d'objet
        //public void SeTransformer()
        //{
        //    if (stadeCourant is Oeuf)
        //    {
        //        stadeCourant = new Chenille();
        //    }
        //    else if (stadeCourant is Chenille)
        //    {
        //        stadeCourant = new Chrysalide();
        //    }
        //    //...
        //    else if (stadeCourant is Papillon)
        //    {
        //        stadeCourant = new PapillonAvecUneAileEnMoins();
        //    }
        //}

        //solution object
        public void SeTransformer()
        {
            //...
                stadeCourant.DonneLeProchainStade();
            //..
        }
    }
}