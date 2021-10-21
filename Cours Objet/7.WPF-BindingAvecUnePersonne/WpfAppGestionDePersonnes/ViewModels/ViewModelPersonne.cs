using CLPersonne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppGestionDePersonnes.ViewModels
{
    public class ViewModelPersonne : ViewModel
    {
        private Personne p;

        public ViewModelPersonne(Personne _p)
        {
            p = _p;
        }

        public ViewModelPersonne()
        {
            p = new Personne();
        }

        public string Nom
        {
            get
            {
                return p.Nom;
            }
            set
            {
                p.Nom = value;
                ValidateNom(p.Nom);
 
                this.RaiseOnPropertyChanged(nameof(Nom));
            }
        }

        private void ValidateNom(string nom)
        {
            if (nom.Length == 0)
            {
                AddError(nameof(Nom), "Le texte ne peut pas être vide");
            }
            else
            {
                this.ClearError(nameof(Nom));
            }
        }

        public string Prenom
        {
            get
            {
                return p.Prenom;
            }
            set
            {
                p.Prenom = value;
                ValidatePrenom(p.Prenom);
                this.RaiseOnPropertyChanged(nameof(Prenom));
            }
        }

        private void ValidatePrenom(string prenom)
        {
            if (prenom.Length == 0)
            {
                AddError(nameof(Prenom), "Le texte ne peut pas être vide");
            }
            else
            {
                this.ClearError(nameof(Nom));
            }
        }

        public int Age { get => p.Age; set => p.Age = value; }

        private void ValidateAge()
        {
        }
    }
}
