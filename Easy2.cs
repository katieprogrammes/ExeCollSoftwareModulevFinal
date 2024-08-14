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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpotTheDifference
{
    public partial class Easy2 : Form
    {
        //Variable for users current score
        public static int score2;
        public Easy2()
        {
            InitializeComponent();
            //Parses score to this level
            score2 = Easy1.score;
            //Converts score to a displayable format
            labelScore.Text = Convert.ToString(score2);
        }

        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(score2);
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score2);
            //Opens next level
            this.Hide();
            var Easy3 = new Easy3();
            Easy3.Closed += (s, args) => this.Close();
            Easy3.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score2);
            //Opens next level
            this.Hide();
            var Easy3 = new Easy3();
            Easy3.Closed += (s, args) => this.Close();
            Easy3.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            score2 = score2 + 1;
            labelScore.Text = Convert.ToString(score2);
            //Opens next level
            this.Hide();
            var Easy3 = new Easy3();
            Easy3.Closed += (s, args) => this.Close();
            Easy3.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score2);
            //Opens next level
            this.Hide();
            var Easy3 = new Easy3();
            Easy3.Closed += (s, args) => this.Close();
            Easy3.Show();
        }
    }
}
