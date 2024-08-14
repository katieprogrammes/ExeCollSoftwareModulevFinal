using SpotTheDifference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExeCollSoftwareModule
{
    public partial class TestHard2 : Form
    {
        //Variable for users current score
        public static int scoreth2;
        public TestHard2()
        {
            InitializeComponent();
            //Parses score to this level
            scoreth2 = TestHard1.scoreth;
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scoreth2);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scoreth2);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scoreth2 = scoreth2 + 1;
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth2);
            //Opens next level
            this.Hide();
            var TestHard3 = new TestHard3();
            TestHard3.Closed += (s, args) => this.Close();
            TestHard3.Show();
        }
    }
}
