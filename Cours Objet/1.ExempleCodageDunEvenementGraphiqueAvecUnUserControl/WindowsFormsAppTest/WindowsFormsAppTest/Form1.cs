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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click2);
            this.button1.Click -= new System.EventHandler(this.button1_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click2(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void ucAuthentification1_AuthentificationReussi(object sender, AuthentificationReussiEventArgs e)
        {
            this.button1.BackColor = Color.Green;
            this.textBox1.Text = e.LeNom;
        }
    }
}
