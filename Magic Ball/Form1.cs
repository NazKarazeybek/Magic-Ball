using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Ball
{
    public partial class Form1 : Form
    {
        Random randomGen = new Random();
        int ballSwitch = 6;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            ballSwitch = randomGen.Next(0, 7);

            switch (ballSwitch)
            {
                case 0:
                    outputLabel.Text = "Most likely";
                    break;
                case 1:
                    outputLabel.Text = "Very doubtful";
                    break;
                case 2:
                    outputLabel.Text = "Outlook not so good";
                    break;
                case 3:
                    outputLabel.Text = "Don't count on it";
                    break;
                case 4:
                    outputLabel.Text = "It is certain";
                    break;
                case 5:
                    outputLabel.Text = "Yes";
                    break;
                case 6:
                    outputLabel.Text = "No";
                    break;

            }



        }
    }
}
