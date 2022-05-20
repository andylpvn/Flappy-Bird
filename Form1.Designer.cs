namespace FlappyBirds
{
    partial class Form1
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
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(573, 603);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(105, 33);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::FlappyBirds.Properties.Resources.pipedown;
            this.pipeUp.Location = new System.Drawing.Point(538, -9);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(177, 197);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 3;
            this.pipeUp.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.Image = global::FlappyBirds.Properties.Resources.pipe;
            this.PipeDown.Location = new System.Drawing.Point(756, 343);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(177, 224);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 2;
            this.PipeDown.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::FlappyBirds.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(109, 224);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(91, 79);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBirds.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-7, 564);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1201, 98);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(781, 645);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
    }
}

