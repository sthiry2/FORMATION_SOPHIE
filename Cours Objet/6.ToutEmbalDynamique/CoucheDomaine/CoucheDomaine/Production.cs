using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CoucheDomaine
{
    public class Production
    {
        private const int CoefficientAccelerateur = 1000; 
        public enum EtatsProduction
        {
            NonDemarre,
            Demarre,
            Suspendu,
            Termine
        }

        // attributs
        private EtatsProduction monEtatCourant;
        private string identifiantDeLaProduction;
        private int nbCaissesProduitesAvecDefaut;
        private int nbCaissesProduites;
        private int nbDeCaissesAProduire;
        private Thread myThread;
        private int nbCaissesParHeure;

        public int NbCaissesProduites { get => nbCaissesProduites; /*set => nbCaissesProduites = value;*/ }
        public int NbDeCaissesAProduire { get => nbDeCaissesAProduire; /*set => nbDeCaissesAProduire = value; */}
        public EtatsProduction MonEtatCourant { get => monEtatCourant; /*set => monEtatCourant = value;*/ }
        public int NbCaissesParHeure { get => nbCaissesParHeure; /*set => nbCaissesParHeure = value;*/ }
        public string IdentifiantDeLaProduction { get => identifiantDeLaProduction; set => identifiantDeLaProduction = value; }


        // evenements
        public delegate void DelegateProduction(Production sender);

        public event DelegateProduction NewBoxCreated;    
        public event DelegateProduction FinProduction;

        public delegate void DelegateStateChanged(Production sender, EtatsProduction newState);
        public event DelegateStateChanged StateChanged;


        /// <summary>
        /// Constructeur classique de la Production
        /// </summary>
        /// <param name="identifiantDeLaProduction">Un nom unique qui identifie la production</param>
        /// <param name="nbDeCaissesAProduire"></param>
        /// <param name="nbCaissesParHeure"></param>
        public Production(string identifiantDeLaProduction, int nbDeCaissesAProduire, int nbCaissesParHeure)
        {
            this.monEtatCourant = EtatsProduction.NonDemarre;
            this.identifiantDeLaProduction = identifiantDeLaProduction;
            this.nbCaissesProduitesAvecDefaut = 0;
            this.nbCaissesProduites = 0;
            this.nbDeCaissesAProduire = nbDeCaissesAProduire;
            this.myThread = new Thread(new ThreadStart(CreerDesCaisses));
            this.nbCaissesParHeure = nbCaissesParHeure;
        }

        //Clone partiel !Warning!
        public Production(Production productionAClone)
            :this(productionAClone.identifiantDeLaProduction, productionAClone.nbDeCaissesAProduire, productionAClone.nbCaissesParHeure)
        { }

        /// <summary>
        /// Elle permet de demarrer la production
        /// </summary>
        public void Demarrer()
        {
            if (monEtatCourant==EtatsProduction.NonDemarre
                ||monEtatCourant==EtatsProduction.Suspendu)
            {
                monEtatCourant = EtatsProduction.Demarre;
                if (StateChanged != null)
                {
                    StateChanged(this, this.monEtatCourant);
                }
                myThread.Start();
            }
        }

        public void MettreEnPause()
        {
            if (monEtatCourant == EtatsProduction.Demarre)
            {
                monEtatCourant = EtatsProduction.Suspendu;
                if (StateChanged != null)
                {
                    StateChanged(this, this.monEtatCourant);
                }
            }
        }

        public void Continuer()
        {
            if (monEtatCourant == EtatsProduction.Suspendu)
            {
                monEtatCourant = EtatsProduction.Demarre;
                if (StateChanged != null)
                {
                    StateChanged(this, this.monEtatCourant);
                }
            }
        }

        public decimal GetTauxProductionParDefaut()
        {
            throw new System.NotImplementedException();
        }

        private void CreerDesCaisses()
        {
            while(!AAtteintLObjectifDeProduction())
            {
                //Interval de pause.
                Thread.Sleep(CalculerIntervalDeLaProductionEnMs());

                if (monEtatCourant == EtatsProduction.Demarre)
                {
                    nbCaissesProduites++;

                    if (NewBoxCreated != null)
                    {
                        NewBoxCreated(this);
                    }
                }
                
            }

            monEtatCourant = EtatsProduction.Termine;
            if(FinProduction  != null)
            {
                FinProduction(this);
            }

            //façon simplifié équivaut à : if(StateChanged != null){StateChanged(this, this.monEtatCourant)}
            StateChanged?.Invoke(this, this.monEtatCourant);

        }

        public bool AAtteintLObjectifDeProduction()
        {
            return nbDeCaissesAProduire == nbCaissesProduites;
        }

        private int CalculerIntervalDeLaProductionEnMs()
        {
            return (int)Decimal.Round((3600000m / nbCaissesParHeure)/CoefficientAccelerateur); 
        }
    }
}