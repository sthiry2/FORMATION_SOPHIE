using CoucheDomaine;
using LibUserControl;
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
    public partial class FormToutEmbal : Form
    {
        Dictionary<string, Production> productions;

        public FormToutEmbal()
        {
            InitializeComponent();
            productions = new Dictionary<string, Production>();

            /*Production p1 = new Production("ABC", 100, 10);
            AjouterUneProduction(p1);
            Production p2 = new Production("ABC2", 100, 10);
            AjouterUneProduction(p2);*/

        }

        private void AjouterUneProduction(Production production)
        {
            production.NewBoxCreated += Production_NewBoxCreated;
            productions.Add(production.IdentifiantDeLaProduction, production);

            //ajouter le UCProgressNbCaisseProduction au panel
            UCProgressNbCaisseProduction newUcProgressNbCaisseProduction = new UCProgressNbCaisseProduction();

            //this.ucProgressNbCaisseProduction1.Location = new System.Drawing.Point(3, 3);
            newUcProgressNbCaisseProduction.Name = production.IdentifiantDeLaProduction;
            newUcProgressNbCaisseProduction.Dock = DockStyle.Top;
            newUcProgressNbCaisseProduction.NbDeCaisseAProduire = production.NbDeCaissesAProduire;
            newUcProgressNbCaisseProduction.NbDeCaisseProduite = 0;
            newUcProgressNbCaisseProduction.NomDeLaProduction = "Production " + production.IdentifiantDeLaProduction;
            newUcProgressNbCaisseProduction.Size = new System.Drawing.Size(938, 99);
            //newUcProgressNbCaisseProduction.TabIndex = 0;

            //on peut associer un objet a un control par le Tag
            newUcProgressNbCaisseProduction.Tag = production;

            this.panelUCProgress.Controls.Add(newUcProgressNbCaisseProduction);




        }

        private void Production_NewBoxCreated(Production sender)
        {
            this.Invoke(new DelegateMisAJourNbCaisse(MisAJourNbCaisse), new object[] { sender });
        }

        private delegate void DelegateMisAJourNbCaisse(Production sender);
        private void MisAJourNbCaisse(Production sender)
        {
            UCProgressNbCaisseProduction monUc = (UCProgressNbCaisseProduction)this.panelUCProgress.Controls[sender.IdentifiantDeLaProduction];
            monUc.NbDeCaisseProduite = sender.NbCaissesProduites;
        }

        private void ajouterUneProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Créer une production en dur 
            //Production p1 = new Production("ABC", 100, 10);

            //Créer une production via un nouveau formulaire 
            //Si on était en mode édition, on passerai la production en paramètre dans le constructeur ci-dessous
            FormProduction formProduction = new FormProduction();
            DialogResult d = formProduction.ShowDialog();
            if (d == DialogResult.Yes)
            {
                AjouterUneProduction(formProduction.MaProduction);

            }
        }



        private void demarrerLaPremiereProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Production p in productions.Values)
            {
                p.Demarrer();
            }
        }
        
    }
}
