using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPassageDuneFenetreALautre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            DialogResult d= f2.ShowDialog();// ShowDialog est bloquant
            if (d == DialogResult.OK)
            {
                string texteRecupere = f2.LeTexteARecuperer;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            // ne pas faire f2.buttonValider.Click += ButtonValider_Click;
            f2.LeTexteARecupereEstValide += F2_LeTexteARecupereEstValide;
            f2.Show();// Show n'est pas bloquant
            
            string texteRecupere = f2.LeTexteARecuperer;
            
        }

        private void F2_LeTexteARecupereEstValide(object sender, LeTexteARecupererEstValideEventArgs e)
        {
            Form2 f2 = (Form2)sender;
            string texteRecupere = f2.LeTexteARecuperer;
            int lg = e.LgTexte;
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            // necessite de tout ouvrir
            //MessageBox.Show("On a clique sur Valider et le texte saisie a ce moment est " + f2. );
        }
    }
}
