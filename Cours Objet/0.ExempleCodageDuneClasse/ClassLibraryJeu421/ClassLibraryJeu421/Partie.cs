using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryJeu421
{
    public class Partie
    {
        private Manche maMancheCourante;
        private int scoreCourant;
        private int nombreDaMancheJoue;
        private int nbMancheAJouer;

        public void LancerLes3Des()
        {
            this.maMancheCourante.LancerLes3Des();
        }

        public void EstGagne()
        {
            throw new System.NotImplementedException();
        }

        public void AEncoreUneMancheAJouer()
        {
            throw new System.NotImplementedException();
        }
    }
}