using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MettreAJourIHMPendantTraitementAvecBeginInvoke
{
    public partial class Form1 : Form
    {
        private delegate void InvokeMethod(int step);

        public Form1()
        {
            InitializeComponent();
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 10;
        }

        private void buttonAvance_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadProcess));
            t.Start();
        }


        private void ThreadProcess()
        {
            IAsyncResult res;
            for (int i = progressBar1.Minimum; i < (progressBar1.Maximum+1); i++)
            {
                //appel de la methode UpdateProgressBar
                res = progressBar1.BeginInvoke(new InvokeMethod(UpdateProgressBar), new object[] { i });
                //recuperation du résultat
                progressBar1.EndInvoke(res);
                Thread.Sleep(1000);
            }
        }

        private void UpdateProgressBar(int step)
        {
            this.progressBar1.Value = step;
        }
    }
}
