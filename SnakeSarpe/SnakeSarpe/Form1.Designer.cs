namespace SnakeSarpe
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
            this.lblSnake = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lblCurentScore = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSnake
            // 
            this.lblSnake.AutoSize = true;
            this.lblSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnake.ForeColor = System.Drawing.Color.Gold;
            this.lblSnake.Location = new System.Drawing.Point(102, 32);
            this.lblSnake.Name = "lblSnake";
            this.lblSnake.Size = new System.Drawing.Size(477, 163);
            this.lblSnake.TabIndex = 0;
            this.lblSnake.Text = "Snake";
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Gold;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_play.Location = new System.Drawing.Point(162, 377);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(328, 119);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "PLAY";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Gold;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_exit.Location = new System.Drawing.Point(162, 566);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(328, 119);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.Color.Gold;
            this.lblBestScore.Location = new System.Drawing.Point(93, 879);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(248, 52);
            this.lblBestScore.TabIndex = 3;
            this.lblBestScore.Text = "Best Score:";
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.btn_pause);
            this.panelGame.Controls.Add(this.btn_back);
            this.panelGame.Controls.Add(this.lblCurentScore);
            this.panelGame.Controls.Add(this.lblBestScore);
            this.panelGame.Controls.Add(this.btn_exit);
            this.panelGame.Controls.Add(this.btn_play);
            this.panelGame.Controls.Add(this.lblSnake);
            this.panelGame.Location = new System.Drawing.Point(1, 4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(699, 1022);
            this.panelGame.TabIndex = 4;
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Gold;
            this.btn_pause.Enabled = false;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_pause.Location = new System.Drawing.Point(567, 33);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(80, 84);
            this.btn_pause.TabIndex = 6;
            this.btn_pause.Text = "||";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Visible = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gold;
            this.btn_back.Enabled = false;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_back.Location = new System.Drawing.Point(470, 892);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(195, 69);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lblCurentScore
            // 
            this.lblCurentScore.AutoSize = true;
            this.lblCurentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurentScore.ForeColor = System.Drawing.Color.Gold;
            this.lblCurentScore.Location = new System.Drawing.Point(21, 931);
            this.lblCurentScore.Name = "lblCurentScore";
            this.lblCurentScore.Size = new System.Drawing.Size(307, 52);
            this.lblCurentScore.TabIndex = 4;
            this.lblCurentScore.Text = "Current Score:";
            this.lblCurentScore.Visible = false;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 400;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(698, 1024);
            this.Controls.Add(this.panelGame);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 1080);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSnake;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lblCurentScore;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_back;
    }
}

