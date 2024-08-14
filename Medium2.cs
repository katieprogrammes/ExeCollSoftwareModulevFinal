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
    public partial class Medium2 : Form
    {
        //Variable for users current score
        public static int scorem2;
        public Medium2()
        {
            InitializeComponent();
            //Parses score to this level
            scorem2 = Medium1.scorem;
            //Converts score to a displayable format
            labelScore.Text = Convert.ToString(scorem2);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {   //Displays current score
            Console.WriteLine(scorem2);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem2);
            //Opens next level
            this.Hide();
            var Medium3 = new Medium3();
            Medium3.Closed += (s, args) => this.Close();
            Medium3.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem2);
            //Opens next level
            this.Hide();
            var Medium3 = new Medium3();
            Medium3.Closed += (s, args) => this.Close();
            Medium3.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scorem2 = scorem2 + 1;
            labelScore.Text = Convert.ToString(scorem2);
            //Opens next level
            this.Hide();
            var Medium3 = new Medium3();
            Medium3.Closed += (s, args) => this.Close();
            Medium3.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem2);
            //Opens next level
            this.Hide();
            var Medium3 = new Medium3();
            Medium3.Closed += (s, args) => this.Close();
            Medium3.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem2);
            //Opens next level
            this.Hide();
            var Medium3 = new Medium3();
            Medium3.Closed += (s, args) => this.Close();
            Medium3.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scorem2);
            //Opens next level
            this.Hide();
            var Medium3 = new Medium3();
            Medium3.Closed += (s, args) => this.Close();
            Medium3.Show();
        }
    }
}
