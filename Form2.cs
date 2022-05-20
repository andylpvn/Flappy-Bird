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
    public partial class Form2 : Form
    {
        private string PlayerName = "John Doe";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.SetPlayerName(PlayerName);
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controls c1 = new Controls();
            c1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScoreBoard f4 = new ScoreBoard();
            f4.Show();
            f4.SetScores();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            PlayerName = textBox1.Text;
        }
    }
}
