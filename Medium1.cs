using ExeCollSoftwareModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotTheDifference
{
    public partial class Medium1 : Form
    {
        //Creates variable to monitor the users score
        public static int scorem = 0;
        public Medium1()
        {
            InitializeComponent();
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scorem);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scorem);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem);
            //Opens next level
            this.Hide();
            var Medium2 = new Medium2();
            Medium2.Closed += (s, args) => this.Close();
            Medium2.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem);
            //Opens next level
            this.Hide();
            var Medium2 = new Medium2();
            Medium2.Closed += (s, args) => this.Close();
            Medium2.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem);
            //Opens next level
            this.Hide();
            var Medium2 = new Medium2();
            Medium2.Closed += (s, args) => this.Close();
            Medium2.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem);
            //Opens next level
            this.Hide();
            var Medium2 = new Medium2();
            Medium2.Closed += (s, args) => this.Close();
            Medium2.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scorem = +1;
            labelScore.Text = Convert.ToString(scorem);
            //Opens next level
            this.Hide();
            var Medium2 = new Medium2();
            Medium2.Closed += (s, args) => this.Close();
            Medium2.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem);
            //Opens next level
            this.Hide();
            var Medium2 = new Medium2();
            Medium2.Closed += (s, args) => this.Close();
            Medium2.Show();
        }
    }
}
