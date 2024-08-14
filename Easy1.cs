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
    public partial class Easy1 : Form
    {
        //Creates variable to monitor the users score
        public static int score = 0;
        public Easy1()
        {
            InitializeComponent();
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(score);
        }

        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(score);
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            score = +1;
            labelScore.Text = Convert.ToString(score);
            //Opens next level
            this.Hide();
            var Easy2 = new Easy2();
            Easy2.Closed += (s, args) => this.Close();
            Easy2.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score);
            //Opens next level
            this.Hide();
            var Easy2 = new Easy2();
            Easy2.Closed += (s, args) => this.Close();
            Easy2.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score);
            //Opens next level
            this.Hide();
            var Easy2 = new Easy2();
            Easy2.Closed += (s, args) => this.Close();
            Easy2.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score);
            //Opens next level
            this.Hide();
            var Easy2 = new Easy2();
            Easy2.Closed += (s, args) => this.Close();
            Easy2.Show();
        }
    }
}
