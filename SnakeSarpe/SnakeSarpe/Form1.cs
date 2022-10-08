using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeSarpe
{
    public partial class Form1 : Form
    {

        Dictionary<Point, bool> ht = new Dictionary<Point, bool>();
        Point[] snake = new Point[257];
        Random rand = new Random();
        Graphics g;
        int[,] dir = { {-1,0},{1,0 },{0,-1 },{0,1 } };
        Button[] btns = new Button[4];
        int currentDir ;
        int currentScore;
        int bestScore = 0;
        Point pnt = new Point(-1,-1);
        

        public Form1()
        {
            InitializeComponent();
        }


        void winner()
        {
            timerClock.Enabled = false;
            lblSnake.Text = "Won!";

            btn_back.Visible = true;
            btn_back.Enabled = true;
            if (currentScore > bestScore) bestScore = currentScore;
            lblBestScore.Text = "Best Score: " + bestScore.ToString();
        }

        void loser()
        {
            lblSnake.Text = "Lose!";
            timerClock.Enabled = false;

            btn_back.Visible = true;
            btn_back.Enabled = true;

            if (currentScore > bestScore) bestScore = currentScore;
            lblBestScore.Text = "Best Score: " + bestScore.ToString();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            btn_play.Enabled = false;
            btn_play.Visible = false;
            btn_exit.Enabled = false;
            btn_exit.Visible = false;

            lblBestScore.Visible = false;

            lblCurentScore.Visible = true;

            btn_pause.Visible = true;
            btn_pause.Enabled = true;

            ht.Clear();
            for (int i = 0; i <= currentScore; i++) snake[i] = new Point(0,0);

            for (int i = 0; i < 4; i++)
            {
                Button temp = new Button();
                panelGame.Controls.Add(temp);
                temp.Height = 50;
                temp.Width = 50;
                temp.BackColor = Color.Gold;
                temp.Font = new Font("Arial", 20, FontStyle.Bold);
                temp.ForeColor = Color.SteelBlue;
                temp.Location = new Point(205 + dir[i, 0] * 190, 335 + dir[i, 1] * 190);
                temp.Click += new EventHandler(this.btn_dir);
                btns[i] = temp;
            }
            btns[0].Text = "<";
            btns[1].Text = ">";
            btns[2].Text = "^";
            btns[3].Text = "v";


            g = panelGame.CreateGraphics();

            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 16; j++)
                    g.FillRectangle(new SolidBrush(Color.LightGreen),70+i*20,200+j*20,20,20);

            currentDir = 3;
            currentScore = 0;
            lblCurentScore.Text = "Current Score: " + currentScore.ToString(); 
            timerClock.Enabled = true;
        
            snake[0] =(new Point(8, 8));
            pnt = snake[0];
            ht.Add(snake[0], true);
            while (pnt == snake[0] )
            { pnt.X = rand.Next(0,15); pnt.Y = rand.Next(0,15); }
            g.FillRectangle(new SolidBrush(Color.Green), 70 + pnt.X * 20, 200 + pnt.Y * 20, 20, 20);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            if (currentScore == 256) winner();
            int x = (snake[0].X + dir[currentDir, 0]) % 16;
            if (x < 0) x = 15;
            int y = (snake[0].Y + dir[currentDir, 1])%16;
            if (y < 0) y = 15;
            Point temp = new Point(x,y) ;
            Point temp2= new Point(-1,1);

            

            if (ht.ContainsKey(temp) == true) { loser();return; }

            g.FillRectangle(new SolidBrush(Color.Red), 70 + temp.X * 20, 200 + temp.Y * 20, 20, 20);

            for(int i = 0; i <= currentScore; i++)
            {
                temp2 = snake[i];
                snake[i] = temp;
                temp = temp2;
            }
            //MessageBox.Show(temp2.X.ToString() + " " + temp2.Y.ToString());
            if(temp2 == pnt)
            {
                currentScore++;
                snake[currentScore] = temp;
                lblCurentScore.Text = "Current Score: " + currentScore.ToString();

                while (ht.ContainsKey(pnt) == true) {pnt.X = rand.Next(0, 15); pnt.Y = rand.Next(0, 15); }
                g.FillRectangle(new SolidBrush(Color.Green), 70 + pnt.X * 20, 200 + pnt.Y * 20, 20, 20);

            }
            else
                g.FillRectangle(new SolidBrush(Color.LightGreen), 70 + temp.X * 20, 200 + temp.Y * 20, 20, 20);
            ht.Clear();
            for (int i = 0; i <= currentScore; i++) ht.Add(snake[i], true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//MessageBox.Show(e.KeyCode.ToString());
            
        }

        private void btn_dir(object sender, EventArgs e)
        {
            if (sender.Equals(btns[0]) && currentDir != 1) currentDir = 0;
            if (sender.Equals(btns[1]) && currentDir != 0) currentDir = 1;
            if (sender.Equals(btns[2]) && currentDir != 3) currentDir = 2;
            if (sender.Equals(btns[3]) && currentDir != 2) currentDir = 3;

        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (lblSnake.Text != "Snake") return;
            if(timerClock.Enabled == true)
            timerClock.Enabled = false;
            else 
            timerClock.Enabled = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            g.Clear(Color.SteelBlue);
            for (int i = 0; i < 4; i++) panelGame.Controls.Remove(btns[i]);
            lblSnake.Text = "Snake";
            lblCurentScore.Visible = false;
            btn_back.Enabled = false;
            btn_back.Visible = false;

            btn_play.Visible = true;
            btn_play.Enabled = true;

            btn_exit.Enabled = true;
            btn_exit.Visible = true;

            lblBestScore.Visible = true;

        }
    }
}
