using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPER_HERO_OBSTACLE_COURSE
{
    public partial class GamePlay : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 40;
        int score = 0;
        int obstacleSpeed = 11;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        PictureBox projectile;

        public GamePlay()
        {
            InitializeComponent();
            InitializeProjectile();
            GameReset();
        }

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
            projectile = new PictureBox();
            projectile.Size = new Size(50, 5); // Size of the projectile
            projectile.BackColor = Color.Yellow; // Set the color to yellow
            projectile.Visible = false; // Initially invisible
            this.Controls.Add(projectile);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
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

            if (batman.Top > 529 && jumping == false)
            {
                force = 40;
                batman.Top = 529;
                jumpSpeed = 7;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -200)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(600, 900) + (x.Width * 15);
                        score++;
                    }

                    if (batman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        batman.Image = Properties.Resources.dead;
                        txtScore.Text += " Press R to restart the game! ";
                    }

                    if (projectile.Visible && projectile.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Left = this.ClientSize.Width + rand.Next(600, 900) + (x.Width * 15);
                        projectile.Visible = false;
                        score++;
                    }
                }
            }

            if (projectile.Visible)
            {
                projectile.Left += 20; // Speed of the projectile
                if (projectile.Left > this.ClientSize.Width)
                {
                    projectile.Visible = false;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
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
            if (!projectile.Visible)
            {
                projectile.Location = new Point(batman.Left + batman.Width, batman.Top + batman.Height / 2);
                projectile.Visible = true;
                projectile.BringToFront();
            }
        }

        private void GameReset()
        {
            force = 40;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 11;
            txtScore.Text = "Score: " + score;
            batman.Image = Properties.Resources.running;
            isGameOver = true;
            batman.Top = 529;

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
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void axMSVidCtl1_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            GameMenu GameScreen = new GameMenu();
            this.Hide();
            GameScreen.Show();
            GameReset();
            GameScreen.Focus();
        }

        private void button2_MouseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
