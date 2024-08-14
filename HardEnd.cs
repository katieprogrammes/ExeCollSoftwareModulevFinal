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
    public partial class HardEnd : Form
    {
        public HardEnd()
        {
            InitializeComponent();
            //Brings in the final score and displays it
            labelScore.Text = Convert.ToString(Hard5.scoreh5);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //Returns user to the main menu
            this.Hide();
            var MainMenu = new MainMenu();
            MainMenu.Closed += (s, args) => this.Close();
            MainMenu.Show();
        }
    }
}
