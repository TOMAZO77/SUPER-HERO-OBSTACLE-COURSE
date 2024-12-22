using System; // essential classes and base classes
using System.Drawing; // for basic graphics functionality
using System.Windows.Forms; // for creating windows-based applications

namespace SUPER_HERO_OBSTACLE_COURSE
{
    public partial class GamePlay : Form
    {
        bool jumping = false; // is batman currently jumping?
        int jumpSpeed; // speed of the jump
        int force = 40; // force applied to the jump
        int score = 0; // player's score
        int obstacleSpeed = 11; // speed at which obstacles move towards batman
        Random rand = new Random(); // random number generator for obstacle positions
        int position; // position variable for obstacles
        bool isGameOver = false; // is the game over?
        PictureBox projectile; // picturebox to represent the projectile

        public GamePlay()
        {
            InitializeComponent();
            InitializeProjectile(); // set up the projectile
            GameReset(); // start the game with default settings
        }

        // enable double buffering for smoother graphics
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void InitializeProjectile()
        {
            // set up the projectile with size and color
            projectile = new PictureBox();
            projectile.Size = new Size(50, 5); // size of the projectile
            projectile.BackColor = Color.Yellow; // color of the projectile
            projectile.Visible = false; // initially invisible
            this.Controls.Add(projectile);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            // handle batman's jump and gravity effect
            batman.Top += jumpSpeed;
            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            // ensure batman doesn't fall through the ground
            if (batman.Top > 529 && jumping == false)
            {
                force = 40;
                batman.Top = 529;
                jumpSpeed = 7;
            }

            // loop through controls to handle obstacles
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed; // move obstacle to the left

                    if (x.Left < -200)
                    {
                        // reset obstacle position and increase score
                        x.Left = this.ClientSize.Width + rand.Next(600, 900) + (x.Width * 15);
                        score++;
                    }

                    // check for collision between batman and obstacle
                    if (batman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        batman.Image = Properties.Resources.dead;
                        txtScore.Text += " Press R to restart the game! ";
                    }

                    // check for collision between projectile and obstacle
                    if (projectile.Visible && projectile.Bounds.IntersectsWith(x.Bounds))
                    {
                        // reset obstacle position and make projectile invisible
                        x.Left = this.ClientSize.Width + rand.Next(600, 900) + (x.Width * 15);
                        projectile.Visible = false;
                        score++;
                    }
                }
            }

            // move the projectile if it's visible
            if (projectile.Visible)
            {
                projectile.Left += 20; // speed of the projectile
                if (projectile.Left > this.ClientSize.Width)
                {
                    projectile.Visible = false;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            // handle key down events for jumping and firing the projectile
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
            if (e.KeyCode == Keys.B)
            {
                FireProjectile();
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            // handle key up events for stopping the jump and resetting the game
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void FireProjectile()
        {
            // fire the projectile if it isn't already visible
            if (!projectile.Visible)
            {
                projectile.Location = new Point(batman.Left + batman.Width, batman.Top + batman.Height / 2);
                projectile.Visible = true;
                projectile.BringToFront();
            }
        }

        private void GameReset()
        {
            // reset game settings to start a new game
            force = 40;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 11;
            txtScore.Text = "Score: " + score;
            batman.Image = Properties.Resources.running;
            isGameOver = true;
            batman.Top = 529;

            // reset obstacles' positions
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 1500) + (x.Width * 15);
                    x.Left = position;
                }
            }

            gameTimer.Interval = 20;
            gameTimer.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void axMSVidCtl1_Enter(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            // no function assigned yet
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // handle button1 click to navigate to GameMenu and reset the game
            GameMenu GameScreen = new GameMenu();
            this.Hide();
            GameScreen.Show();
            GameReset();
            GameScreen.Focus();
        }

        private void button2_MouseClick(object sender, EventArgs e)
        {
            // handle button2 click to exit the application
            Application.Exit();
        }
    }
}
