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
    public partial class Easy5 : Form
    {
        //Variable for users current score
        public static int score5;
        public Easy5()
        {
            InitializeComponent();
            //Parses score to this level
            score5 = Easy4.score4;
            //Converts score to a displayable format
            labelScore.Text = Convert.ToString(score5);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(score5);
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score5);
            //Opens next level
            this.Hide();
            var EasyEnd = new EasyEnd();
            EasyEnd.Closed += (s, args) => this.Close();
            EasyEnd.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            score5 = score5 + 1;
            labelScore.Text = Convert.ToString(score5);
            //Opens next level
            this.Hide();
            var EasyEnd = new EasyEnd();
            EasyEnd.Closed += (s, args) => this.Close();
            EasyEnd.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score5);
            //Opens next level
            this.Hide();
            var EasyEnd = new EasyEnd();
            EasyEnd.Closed += (s, args) => this.Close();
            EasyEnd.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score5);
            //Opens next level
            this.Hide();
            var EasyEnd = new EasyEnd();
            EasyEnd.Closed += (s, args) => this.Close();
            EasyEnd.Show();
        }
    }
}
