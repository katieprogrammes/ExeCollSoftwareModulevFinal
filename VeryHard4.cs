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
    public partial class VeryHard4 : Form
    {
        //Variable for users current score
        public static int scorevh4;
        public VeryHard4()
        {
            InitializeComponent();
            //Parses score to this level
            scorevh4 = VeryHard3.scorevh3;
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scorevh4);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scorevh4);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scorevh4 = scorevh4+1;
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorevh4);
            //Opens next level
            this.Hide();
            var VeryHard5 = new VeryHard5();
            VeryHard5.Closed += (s, args) => this.Close();
            VeryHard5.Show();
        }
    }
}
