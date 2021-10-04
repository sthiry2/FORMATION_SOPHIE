using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MettreAJourIHMPendantUnTraitement
{
    public partial class Form1 : Form
    {
        // Déclaration du délégué nécessaire à la mise à jour
        private delegate void DelegateUpdateProgressBar(int step);
        private DelegateUpdateProgressBar updateProgressBar;

        public Form1()
        {
            InitializeComponent(); 

            // Sur appel du délégué, la méthode UpdateProgressBar est donc appelé
            updateProgressBar = new DelegateUpdateProgressBar(UpdateProgressBar);
        }

       

        private void buttonAvanceAPartirDUnAutreThreadPArInvoke_Click(object sender, System.EventArgs e)
        {
            // Lancement du thread
            Thread t = new Thread(new ThreadStart(MethodeDeMiseAJourParInvoke));
            t.Start();
        }


        private void MethodeDeMiseAJourParInvoke()
        {
            for (int i = 0; i <= 10; i++)
            {
                //appel indirect à la methode qui met a jour la progresse bar par un invoke
                //this.Invoke(this.updateProgressBar, new object[] { i });
                this.Invoke(new DelegateUpdateProgressBar(UpdateProgressBar), new object[] { i });

                Thread.Sleep(1000);
            }
        }

        /*methode que l'on aimerait appeler*/
        private void UpdateProgressBar(int step)
        {
            // Mise à jour de la barre de progression
            progressBar1.Value = step;
        }

        private void buttonAvanceAPartirDUnAutreThreadSansInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                // Lancement du thread
                Thread t = new Thread(new ThreadStart(MethodeDeMiseAJourSansInvoke));
                t.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void MethodeDeMiseAJourSansInvoke()
        {
            for (int i = 0; i <= 10; i++)
            {
                //appel direct à la methode qui met a jour la progresse bar
                progressBar1.Value = i;

                Thread.Sleep(1000);
            }

        }

        private void buttonAvanceAPartirDuThreadPrincipale_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                //appel direct à la methode qui met a jour la progresse bar
                progressBar1.Value = i;

                Thread.Sleep(1000);
            }
        }
    }
}
