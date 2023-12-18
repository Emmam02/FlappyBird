
namespace Flappy_Bird
{
    partial class flappyBird
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PipeBottom = new PictureBox();
            Bird = new PictureBox();
            Ground = new PictureBox();
            PipeTop = new PictureBox();
            ScoreText = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeTop).BeginInit();
            SuspendLayout();
            // 
            // PipeBottom
            // 
            PipeBottom.Image = Properties.Resources.pipe;
            PipeBottom.Location = new Point(475, 480);
            PipeBottom.Name = "PipeBottom";
            PipeBottom.Size = new Size(124, 294);
            PipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeBottom.TabIndex = 0;
            PipeBottom.TabStop = false;
            // 
            // Bird
            // 
            Bird.Image = Properties.Resources.bird;
            Bird.Location = new Point(229, 280);
            Bird.Name = "Bird";
            Bird.Size = new Size(93, 75);
            Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            Bird.TabIndex = 1;
            Bird.TabStop = false;
            // 
            // Ground
            // 
            Ground.BackColor = Color.FromArgb(222, 216, 149);
            Ground.Image = Properties.Resources.ground;
            Ground.Location = new Point(-6, 766);
            Ground.Name = "Ground";
            Ground.Size = new Size(816, 90);
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
            Ground.TabIndex = 2;
            Ground.TabStop = false;
            // 
            // PipeTop
            // 
            PipeTop.Image = Properties.Resources.pipedown;
            PipeTop.Location = new Point(577, -1);
            PipeTop.Name = "PipeTop";
            PipeTop.Size = new Size(124, 233);
            PipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeTop.TabIndex = 3;
            PipeTop.TabStop = false;
            // 
            // ScoreText
            // 
            ScoreText.AutoSize = true;
            ScoreText.BackColor = Color.FromArgb(222, 216, 149);
            ScoreText.Font = new Font("Sitka Banner", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreText.Location = new Point(12, 766);
            ScoreText.Name = "ScoreText";
            ScoreText.Size = new Size(102, 47);
            ScoreText.TabIndex = 4;
            ScoreText.Text = "Score :";
            ScoreText.Click += ScoreText_Click;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // flappyBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(804, 851);
            Controls.Add(ScoreText);
            Controls.Add(Bird);
            Controls.Add(PipeTop);
            Controls.Add(Ground);
            Controls.Add(PipeBottom);
            Name = "flappyBird";
            Text = "FlappyBird";
            KeyDown += GameKeyIsDown;
            KeyUp += GameKeyIsUp;
            ((System.ComponentModel.ISupportInitialize)PipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeTop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox PipeBottom;
        private PictureBox Bird;
        private PictureBox Ground;
        private PictureBox PipeTop;
        private Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}
