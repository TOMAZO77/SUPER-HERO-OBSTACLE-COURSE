using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SUPER_HERO_OBSTACLE_COURSE
{

    public partial class GameMenu : Form
    {
        public GameMenu()
        {

            InitializeComponent();
        }

       
        


        private void Quit_Button(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayGame(object sender, MouseEventArgs e)
        {
            this.Hide();
            GamePlay GameScreen = new GamePlay();
            GameScreen.Show();

        }
    }
}
