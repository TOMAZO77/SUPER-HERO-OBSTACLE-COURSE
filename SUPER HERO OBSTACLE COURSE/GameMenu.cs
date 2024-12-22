using System; // essential classes and base classes
using System.Windows.Forms; // for creating windows-based applications

namespace SUPER_HERO_OBSTACLE_COURSE
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent(); // initialize components
        }

        private void Quit_Button(object sender, EventArgs e)
        {
            // exit the application
            Application.Exit();
        }

        private void PlayGame(object sender, MouseEventArgs e)
        {
            // hide the current menu and show the game screen
            this.Hide();
            GamePlay GameScreen = new GamePlay();
            GameScreen.Show();
            GameScreen.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // no function assigned yet
        }
    }
}
