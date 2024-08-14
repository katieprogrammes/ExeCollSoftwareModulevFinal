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
    public partial class Easy4 : Form
    {
        //Variable for users current score
        public static int score4;
        public Easy4()
        {
            InitializeComponent();
            //Parses score to this level
            score4 = Easy3.score3;
            //Converts score to a displayable format
            labelScore.Text = Convert.ToString(score4);
        }
        private void textBoxScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(score4);
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score4);
            //Opens next level
            this.Hide();
            var Easy5 = new Easy5();
            Easy5.Closed += (s, args) => this.Close();
            Easy5.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score4);
            //Opens next level
            this.Hide();
            var Easy5 = new Easy5();
            Easy5.Closed += (s, args) => this.Close();
            Easy5.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            score4 = score4 + 1;
            labelScore.Text = Convert.ToString(score4);
            //Opens next level
            this.Hide();
            var Easy5 = new Easy5();
            Easy5.Closed += (s, args) => this.Close();
            Easy5.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score4);
            //Opens next level
            this.Hide();
            var Easy5 = new Easy5();
            Easy5.Closed += (s, args) => this.Close();
            Easy5.Show();
        }
    }
}
