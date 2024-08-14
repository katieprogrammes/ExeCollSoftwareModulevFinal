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
    public partial class Hard5 : Form
    {
        //Variable for users current score
        public static int scoreh5;
        public Hard5()
        {
            InitializeComponent();
            //Parses score to this level
            scoreh5 = Hard4.scoreh4;
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scoreh5);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scoreh5);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scoreh5 = scoreh5+1;
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh5);
            //Opens next level
            this.Hide();
            var HardEnd = new HardEnd();
            HardEnd.Closed += (s, args) => this.Close();
            HardEnd.Show();
        }
    }
}
