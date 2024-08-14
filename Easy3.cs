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
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.DataFormats;

namespace SpotTheDifference
{
    public partial class Easy3 : Form
    {
        //Variable for users current score
        public static int score3;
        public Easy3()
        {
            InitializeComponent();
            //Parses score to this level
            score3 = Easy2.score2;
            //Converts score to a displayable format
            labelScore.Text = Convert.ToString(score3);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(score3);
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score3);
            //Opens next level
            this.Hide();
            var Easy4 = new Easy4();
            Easy4.Closed += (s, args) => this.Close();
            Easy4.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score3);
            //Opens next level
            this.Hide();
            var Easy4 = new Easy4();
            Easy4.Closed += (s, args) => this.Close();
            Easy4.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(score3);
            //Opens next level
            this.Hide();
            var Easy4 = new Easy4();
            Easy4.Closed += (s, args) => this.Close();
            Easy4.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            score3 = score3 + 1;
            labelScore.Text = Convert.ToString(score3);
            //Opens next level
            this.Hide();
            var Easy4 = new Easy4();
            Easy4.Closed += (s, args) => this.Close();
            Easy4.Show();
        }
    }
}
