using ExeCollSoftwareModule;

namespace SpotTheDifference
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //Displays scores for each difficulty
            easyScore.Text = Convert.ToString(Easy5.score5);
            medScore.Text = Convert.ToString(Medium5.scorem5);
            hardScore.Text = Convert.ToString(Hard5.scoreh5);
            verhardScore.Text = Convert.ToString(VeryHard5.scorevh5);
        }

        private void buttonimgEasy_Click(object sender, EventArgs e)
        {
            //Opens the first easy level
            this.Hide();
            var Easy1 = new Easy1();
            Easy1.Closed += (s, args) => this.Close();
            Easy1.Show();
        }

        private void buttonimgMed_Click(object sender, EventArgs e)
        {
            //Opens the first medium level
            this.Hide();
            var Medium1 = new Medium1();
            Medium1.Closed += (s, args) => this.Close();
            Medium1.Show();
        }

        private void buttonimgHard_Click(object sender, EventArgs e)
        {
            //Opens the first hard level
            this.Hide();
            var Hard1 = new Hard1();
            Hard1.Closed += (s, args) => this.Close();
            Hard1.Show();
        }

        private void buttonimgVeryHard_Click(object sender, EventArgs e)
        {
            //Opens the first very hard level
            this.Hide();
            var VeryHard1 = new VeryHard1();
            VeryHard1.Closed += (s, args) => this.Close();
            VeryHard1.Show();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FinalScreen = new FinalScreen();
            FinalScreen.Closed += (s, args) => this.Close();
            FinalScreen.Show();
        }
    }
}