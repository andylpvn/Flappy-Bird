using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 8;
        int score = 0;

        public string PlayerName { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;

            if (PipeDown.Left < -80)
            {
                PipeDown.Left = 800;
                score++;
                Score.Text = "Score: " + score.ToString();
            }
            if (pipeUp.Left < -110)
            {
                pipeUp.Left = 950;
                score++;
                Score.Text = "Score: " + score.ToString();
            }

            if (Bird.Bounds.IntersectsWith(PipeDown.Bounds) || Bird.Bounds.IntersectsWith(pipeUp.Bounds) || Bird.Bounds.IntersectsWith(Ground.Bounds))
            {
                endGame();
            }

        }

        internal void SetPlayerName(string playerName)
        {
            PlayerName = playerName;
        }

        private void endGame()
        {
            gameTimer.Stop();
            ScoreUtils.WriteScore(new PlayerScore { Score= score, Name = PlayerName});
            Score.Text = "Game Over! Your score is: " + score;
            this.Close();
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                gravity = -5;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }

        }
    }
}
