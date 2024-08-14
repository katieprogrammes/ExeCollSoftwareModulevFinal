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
    public partial class VeryHard3 : Form
    {
        //Variable for users current score
        public static int scorevh3;
        public VeryHard3()
        {
            InitializeComponent();
            //Parses score to this level
            scorevh3 = VeryHard2.scorevh2;
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scorevh3);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scorevh3);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scorevh3 = scorevh3+1;
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh3);
            //Opens next level
            this.Hide();
            var VeryHard4 = new VeryHard4();
            VeryHard4.Closed += (s, args) => this.Close();
            VeryHard4.Show();
        }
    }
}
