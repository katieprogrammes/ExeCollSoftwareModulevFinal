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
    public partial class TestHard1 : Form
    {
        //Creates variable to monitor the users score
        public static int scoreth = 0;
        public TestHard1()
        {
            InitializeComponent();
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scoreth);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays score
            Console.WriteLine(scoreth);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            //Increases score by one due to correct click
            scoreth = +1;
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Keeps score the same due to incorrect click
            labelScore.Text = Convert.ToString(scoreth);
            //Opens next level
            this.Hide();
            var TestHard2 = new TestHard2();
            TestHard2.Closed += (s, args) => this.Close();
            TestHard2.Show();
        }
    }
}
