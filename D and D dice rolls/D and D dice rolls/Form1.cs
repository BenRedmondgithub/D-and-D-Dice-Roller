using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_and_D_dice_rolls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void d6button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1,7);
            Outputlabel.Text = "you got: " + randomnumber.ToString();
        }

        private void d10button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 11);
            Outputlabel.Text = "you got: " + randomnumber.ToString();
        }

        private void d20button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 21);
            Outputlabel.Text = "you got: " + randomnumber.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Outputlabel.Text = (" ");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
