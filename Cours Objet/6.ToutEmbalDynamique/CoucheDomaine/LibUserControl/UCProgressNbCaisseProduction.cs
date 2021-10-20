using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibUserControl
{
    public partial class UCProgressNbCaisseProduction : UserControl
    {


        public string NomDeLaProduction { 
          get => labelNomProduction.Text; 
          set => labelNomProduction.Text = value; 
        }
        public int NbDeCaisseAProduire { 
            get => progressBarNbCaisseProduite.Maximum; 
            set => progressBarNbCaisseProduite.Maximum = value; }
        public int NbDeCaisseProduite { 
            get => progressBarNbCaisseProduite.Value; 
            set => progressBarNbCaisseProduite.Value = value; }


        public UCProgressNbCaisseProduction()
        {
            InitializeComponent();
        }


    }
}
