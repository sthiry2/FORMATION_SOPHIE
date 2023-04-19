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
    public partial class FormRobot : Form
    {
        Robot robot;
        public Robot Robot { get => robot; private set => robot = value; }

        public FormRobot()
        {
            InitializeComponent();
            this.buttonValiderOuModifier.Text = "Valider";
        }

        public FormRobot(Robot robotAModifier)
        {
            InitializeComponent();
            this.robot = robotAModifier;
            this.textBoxX.Text = robot.X.ToString();
            this.textBoxY.Text = robot.Y.ToString();
            this.buttonValiderOuModifier.Text = "Modifier";
        }

        private void buttonValiderOuModifier_Click(object sender, EventArgs e)
        {
            if (robot == null)
            {
                robot = new Robot(int.Parse(this.textBoxX.Text), int.Parse(this.textBoxY.Text));
                //sauvegarde en BD:insert (ADD)
            }
            else
            {
                robot.X = int.Parse(this.textBoxX.Text);
                robot.Y = int.Parse(this.textBoxY.Text);
                //sauvegarde en BD:update (UPDATE)
            }
            this.Close();
        }
    }
}
