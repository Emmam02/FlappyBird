namespace Flappy_Bird
{
    public partial class flappyBird : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;


        public flappyBird()
        {
            InitializeComponent();
        }



        private void GameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score: " + score.ToString();

            if (PipeBottom.Right < 0)
            {
                PipeBottom.Left = 800;
                score++;
            }
            if (PipeTop.Left < -100)
            {
                PipeTop.Left = 1000;

            }

            if (Bird.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                Bird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                Bird.Bounds.IntersectsWith(Ground.Bounds) ||
                Bird.Top <-25)
            {
                EndGame();
            }

            if(score > 10) pipeSpeed = 15;
            
            if(score > 20) pipeSpeed = 25;

        }


        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }
        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void EndGame()
        {
            GameTimer.Stop();
            ScoreText.Text = $"Game over! Total score: {score}";
        }

        private void ScoreText_Click(object sender, EventArgs e)
        {

        }
    }
}

