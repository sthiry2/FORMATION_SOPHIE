using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
  
    public partial class UCAuthentification : UserControl
    {
        //declare l'evenement
       // public event EventHandler AuthentificationReussi;
        public event EventHandler<AuthentificationReussiEventArgs> AuthentificationReussi;


        public UCAuthentification()
        {
            InitializeComponent();
        }

        public string Nom { get => this.textBoxNom.Text; set => this.textBoxNom.Text = value; }

        private void textBoxMdp_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxMdp.Text == this.textBoxNom.Text)
            {
                // envoie l'evenement
                AuthentificationReussi(this,new AuthentificationReussiEventArgs("C'est Sophie qui valide"));
            }
        }
    }
}
