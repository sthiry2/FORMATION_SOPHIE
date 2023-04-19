using ClassLibraryRobot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppModifier
{
    public partial class FormRobots : Form
    {
        Robot r;
        public FormRobots()
        {
            InitializeComponent();
            //SELECT EN BD
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            FormRobot formRobot = new FormRobot();
            DialogResult result = formRobot.ShowDialog();
            if (result == DialogResult.OK)
            {
                r = formRobot.Robot;
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            FormRobot fr = new FormRobot(r);
            DialogResult result = fr.ShowDialog();
            if (result == DialogResult.OK)
            {
                r = fr.Robot;

            }
        }
    }
}
