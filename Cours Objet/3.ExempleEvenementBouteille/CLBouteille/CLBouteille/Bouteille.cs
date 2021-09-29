using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBouteille
{
    
        public class Bouteille
        {
            //attributs...
            private decimal contenanceEnL;
            private decimal contenuEnPourcentage;
            private bool ouvert;
        private bool premiereOuverture;

            public delegate void DelegateEstOuvertPourLaPremierFois(decimal _contenanceEnL);
            public event DelegateEstOuvertPourLaPremierFois EstOuvertPourLaPremierFois;

            //propriétés....
            public decimal ContenanceEnL
            {
                get { return contenanceEnL; }

            }
            public decimal ContenuEnPourcentage
            {
                get { return contenuEnPourcentage; }

            }
            public bool Ouvert
            {
                get { return ouvert; }

            }


            //Constructeur par défaut
            public Bouteille()
            {
                this.contenanceEnL = 2;
                this.contenuEnPourcentage = 0;
                this.ouvert = false;
                premiereOuverture = false;
            }
            //constructeur classique
            public Bouteille(decimal _contenanceEnL, decimal _contenuEnPourcentage, bool _ouvert)
            {
                contenanceEnL = _contenanceEnL;
                contenuEnPourcentage = _contenuEnPourcentage;
                ouvert = _ouvert;
            }

            //Méthodes...
            public override string ToString()
            {
                return base.ToString() + " contenance en L = " + contenanceEnL + " contenu en %= " + contenuEnPourcentage + " état = " + ouvert;
            }


            public bool Fermer()
            {
                if (ouvert == true)
                {
                    ouvert = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Ouvrir()
            {
                if (ouvert == false)
                {
                    if (premiereOuverture == false)
                    {
                        premiereOuverture = true;
                        
                        if (EstOuvertPourLaPremierFois != null)// si qq'un c'est enregistre
                        {
                            //envoyer mon evenement
                            EstOuvertPourLaPremierFois(this.contenanceEnL);
                        }
                    }
                    ouvert = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Remplir(decimal aRajouterEnPourcentage)
            {
                if (ouvert == true && contenuEnPourcentage <= 100)
                {
                    if ((aRajouterEnPourcentage + contenuEnPourcentage) <= 100)
                    {
                        contenuEnPourcentage += aRajouterEnPourcentage;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public bool RemplirTout()
            {
                if (ouvert == true && contenuEnPourcentage < 100)
                {
                    contenuEnPourcentage = 100;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Vider(decimal aOterEnPourcentage)
            {
                if (ouvert == true && contenuEnPourcentage <= 100 && contenuEnPourcentage > 0)
                {
                    contenuEnPourcentage -= aOterEnPourcentage;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool ViderTout()
            {
                if (ouvert == true && contenuEnPourcentage <= 100)
                {
                    contenuEnPourcentage = 0;
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }//end Bouteille

    }//end

