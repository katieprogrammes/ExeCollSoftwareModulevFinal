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
    public partial class Medium5 : Form
    {
        //Variable for users current score
        public static int scorem5;
        public Medium5()
        {
            InitializeComponent();
            //Parses score to this level
            scorem5 = Medium4.scorem4;
            //Converts score to a displayable format
            labelScore.Text = Convert.ToString(scorem5);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {   //Displays current score
            Console.WriteLine(scorem5);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //Opens next level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scorem5 = scorem5 + 1;
            labelScore.Text = Convert.ToString(scorem5);
            //Opens next level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //Opens next level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //Opens next level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //Opens next level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem5);
            //Opens next level
            this.Hide();
            var MediumEnd = new MediumEnd();
            MediumEnd.Closed += (s, args) => this.Close();
            MediumEnd.Show();
        }
    }
}
