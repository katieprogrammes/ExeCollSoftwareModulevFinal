using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace SpotTheDifference
{
    public partial class Hard2 : Form
    {
        //Variable for users current score
        public static int scoreh2;
        public Hard2()
        {
            InitializeComponent();
            //Parses score to this level
            scoreh2 = Hard1.scoreh;
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scoreh2);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scoreh2);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scoreh2 = scoreh2+1;
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreh2);
            //Opens next level
            this.Hide();
            var Hard3 = new Hard3();
            Hard3.Closed += (s, args) => this.Close();
            Hard3.Show();
        }
    }
}
