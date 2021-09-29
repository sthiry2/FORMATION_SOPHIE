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
    public partial class Form2 : Form
    {
        public event EventHandler<LeTexteARecupererEstValideEventArgs> LeTexteARecupereEstValide;

        //private string leTexteARecuperer;

        public string LeTexteARecuperer { get => this.textBox1.Text; /*set => leTexteARecuperer = value;*/ }


        public Form2()
        {
            InitializeComponent();
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (LeTexteARecupereEstValide != null)
            {
                LeTexteARecupereEstValide(this, new LeTexteARecupererEstValideEventArgs(this.textBox1.Text.Length));
            }
            this.Close();
        }
    }
}
