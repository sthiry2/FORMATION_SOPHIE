using CoucheDomaine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFToutEmbal
{
    public partial class FormProduction : Form
    {
        private Production maProduction;
        private Production cloneProduction; 

        public Production MaProduction
        {
            get => maProduction; 
        }
        public FormProduction()
        {
            InitializeComponent();
        }

        public FormProduction(Production _production)
        {
            InitializeComponent();
            maProduction = _production;
            cloneProduction = new Production(_production); 
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            //Normalement on devrait vérifier les données envoyées par l'utilisateur 
            int nombreDeCaisseAProduire = int.Parse(textBoxNombreDeCaisseAProduire.Text);
            //Normalement on devrait vérifier les données envoyées par l'utilisateur
            int nombreDeCaisseHeure = int.Parse(textBoxNombreDeCaisseHeure.Text);

            maProduction = new Production(textBoxNomDeProduction.Text, nombreDeCaisseAProduire, nombreDeCaisseHeure);
            DialogResult = DialogResult.Yes; 

        }

        private void textBoxNomDeProduction_TextChanged(object sender, EventArgs e)
        {
            //!Warning security issue! 
            if (cloneProduction != null)
            cloneProduction.IdentifiantDeLaProduction = textBoxNomDeProduction.Text; 
        }
    }
}
