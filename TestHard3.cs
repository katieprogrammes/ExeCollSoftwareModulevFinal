using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCollSoftwareModule
{
    public partial class TestHard3 : Form
    {
        //Variable for users current score
        public static int scoreh3;
        public TestHard3()
        {
            InitializeComponent();
            //Parses score to this level
            scoreh3 = TestHard2.scoreth2;
            //Converts current score to a displayable format
            labelScore.Text = Convert.ToString(scoreh3);
        }
        private void labelScore_TextChanged(object sender, EventArgs e)
        {
            //Displays current score
            Console.WriteLine(scoreh3);
        }
    }
}
