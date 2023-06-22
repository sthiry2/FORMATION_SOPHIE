using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Voiture
    {
        private string marque;
        private List<Roue> ses4Roues;
        private Moteur sonMoteur;

        public Voiture()
        :this("Dacia", "205/55R16 91V",false,false)
        {
            
        }

        public Voiture(string marque, List<Roue> ses4Roues, Moteur sonMoteur)
        {
            if (ses4Roues != null && ses4Roues.Count == 4)
            {
                this.marque = marque;
                this.ses4Roues = ses4Roues;
                this.sonMoteur = sonMoteur;
            }
            else
            {
                throw new Exception("Une voiture idéale doit avoir 4 roues!");
            }
        }

        public Voiture(string marque, string dimensionPneu, bool tourne, bool enMarche)
        : this(marque,
              new List<Roue> {  new Roue(dimensionPneu,tourne),
                                new Roue(dimensionPneu,tourne),
                                new Roue(dimensionPneu,tourne),
                                new Roue(dimensionPneu,tourne)},
              new Moteur(enMarche))
        {
        }

        public Voiture(Voiture voitureACopier)
        {
        }

        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
        }

        public bool Avancer()
        {
            return sonMoteur.EntrainerRoues(ses4Roues[0], ses4Roues[1]);
        }
    }
}
