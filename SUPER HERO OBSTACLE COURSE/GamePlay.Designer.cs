namespace SUPER_HERO_OBSTACLE_COURSE
{
    partial class GamePlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.obstacle_3 = new System.Windows.Forms.PictureBox();
            this.obstacle = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.obstacle_2 = new System.Windows.Forms.PictureBox();
            this.batman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batman)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Green;
            this.txtScore.Location = new System.Drawing.Point(2, 1);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(134, 32);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "Score: 0";
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // obstacle_3
            // 
            this.obstacle_3.BackColor = System.Drawing.Color.Transparent;
            this.obstacle_3.Image = global::SUPER_HERO_OBSTACLE_COURSE.Properties.Resources.car;
            this.obstacle_3.Location = new System.Drawing.Point(814, 440);
            this.obstacle_3.Name = "obstacle_3";
            this.obstacle_3.Size = new System.Drawing.Size(226, 188);
            this.obstacle_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstacle_3.TabIndex = 1;
            this.obstacle_3.TabStop = false;
            this.obstacle_3.Tag = "obstacle";
            // 
            // obstacle
            // 
            this.obstacle.BackColor = System.Drawing.Color.Transparent;
            this.obstacle.Image = global::SUPER_HERO_OBSTACLE_COURSE.Properties.Resources.bat;
            this.obstacle.Location = new System.Drawing.Point(1344, 514);
            this.obstacle.Name = "obstacle";
            this.obstacle.Size = new System.Drawing.Size(62, 62);
            this.obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstacle.TabIndex = 12;
            this.obstacle.TabStop = false;
            this.obstacle.Tag = "obstacle";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::SUPER_HERO_OBSTACLE_COURSE.Properties.Resources.bat;
            this.pictureBox5.Location = new System.Drawing.Point(700, 354);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 62);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SUPER_HERO_OBSTACLE_COURSE.Properties.Resources.bat;
            this.pictureBox4.Location = new System.Drawing.Point(1364, 366);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SUPER_HERO_OBSTACLE_COURSE.Properties.Resources.obsticle5;
            this.pictureBox2.Location = new System.Drawing.Point(1147, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SUPER_HERO_OBSTACLE_COURSE.Properties.Resources.bat;
            this.pictureBox1.Location = new System.Drawing.Point(216, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "obstacle";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // obstacle_2
            // 
            this.obstacle_2.BackColor = System.Drawing.Color.Transparent;
            this.obstacle_2.Image = global::SUPER_HERO_OBSTACLE_COURSE.Properties.Resources.rocks;
            this.obstacle_2.Location = new System.Drawing.Point(442, 482);
            this.obstacle_2.Name = "obstacle_2";
            this.obstacle_2.Size = new System.Drawing.Size(155, 121);
            this.obstacle_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle_2.TabIndex = 3;
            this.obstacle_2.TabStop = false;
            this.obstacle_2.Tag = "obstacle";
            // 
            // batman
            // 
            this.batman.BackColor = System.Drawing.Color.Transparent;
            this.batman.Image = global::SUPER_HERO_OBSTACLE_COURSE.Properties.Resources.batman;
            this.batman.Location = new System.Drawing.Point(-13, 456);
            this.batman.Name = "batman";
            this.batman.Size = new System.Drawing.Size(185, 152);
            this.batman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.batman.TabIndex = 4;
            this.batman.TabStop = false;
            this.batman.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1447, 588);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.obstacle_3);
            this.Controls.Add(this.obstacle);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obstacle_2);
            this.Controls.Add(this.batman);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "GamePlay";
            this.Text = "Batman Obstacle Course";
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox obstacle_3;
        private System.Windows.Forms.PictureBox obstacle_2;
        private System.Windows.Forms.PictureBox batman;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox obstacle;
    }
}

