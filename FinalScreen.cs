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

namespace ExeCollSoftwareModule
{
    public partial class FinalScreen : Form
    {
        public FinalScreen()
        {
            InitializeComponent();
            //Displays scores for each difficulty
            easyScore.Text = Convert.ToString(Easy5.score5);
            medScore.Text = Convert.ToString(Medium5.scorem5);
            hardScore.Text = Convert.ToString(Hard5.scoreh5);
            verhardScore.Text = Convert.ToString(VeryHard5.scorevh5);
        }
    }
}
