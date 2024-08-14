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
    public partial class Hard4 : Form
    {
        //Variable for users current score
        public static int scoreh4;
        public Hard4()
        {
            InitializeComponent();
            //Parses score to this level
            scoreh4 = Hard3.scoreh3;
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scoreh4);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scoreh4);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scoreh4 = scoreh4+1;
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh4);
            //Opens next level
            this.Hide();
            var Hard5 = new Hard5();
            Hard5.Closed += (s, args) => this.Close();
            Hard5.Show();
        }
    }
}
