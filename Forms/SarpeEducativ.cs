using JocEducativ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JocEducativ.Forms
{
    public partial class SarpeEducativ : Form
    {
        List<CircleModel> Snake = new List<CircleModel>();
        CircleModel food = new CircleModel();
        string direction = "down";
        public int punctaj = 0;
        public SarpeEducativ()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;
            startButton.Enabled = false;
            gameTimer.Start();

        }

        private void SarpeEducativ_Load(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000;
            StartGame();
            DrawGame();
        }

        private void StartGame()
        {
            Snake.Clear();
            Random random = new Random();
            int x = random.Next(0, suprafataPanel.Width-20);
            int y = random.Next(0, suprafataPanel.Height / 2-20);
            
            CircleModel cap = new CircleModel();
            {
                cap.X = x;
                cap.Y = y;
            }
            Snake.Add(cap);

            food.X= random.Next(0, suprafataPanel.Width - 20);
            food.Y = random.Next(suprafataPanel.Height / 2, suprafataPanel.Height - 20);

        }

        private void NewFood()
        {
            bool interacts = true;
            
            int x=0;
            int y=0;
            while (interacts == true)
            { bool found = false;
            Random random = new Random();
             x = random.Next(0, suprafataPanel.Width-20);
             y= random.Next(0, suprafataPanel.Height - 20);
               foreach(CircleModel part in Snake)
                {
                    if (Math.Abs(part.X - x) <= 20 && Math.Abs(part.Y -y) <= 20)
                    {
                        found = true;
                    }
                }
                if (found == false)
                {
                    interacts = false;
                }
            }
            food.X= x; food.Y = y;
           
        }

        private void DrawGame()
        {
            Bitmap bitmap = new Bitmap(suprafataPanel.Width, suprafataPanel.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            for(int i=0; i<Snake.Count; i++)
            {
                Brush color;
                if (i == 0) { color = Brushes.White; }
                else { color = Brushes.Green; }
                graphics.FillEllipse(color, Snake[i].X, Snake[i].Y, 20, 20);
            } 
            graphics.FillEllipse(Brushes.Red, food.X, food.Y, 20, 20);
            suprafataPanel.BackgroundImage = bitmap;

        }

        private void SarpeEducativ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (direction != "right")
                {
                    direction = "left";
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (direction != "left")
                {
                    direction = "right";
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (direction != "down")
                {
                    direction = "up";
                }
            }
            if (e.KeyCode == Keys.Z)
            {
                if (direction != "up")
                {
                    direction = "down";
                }
            }
        }

        private void MoveSarpe()
        {
            for(int i= Snake.Count-1; i>=0; i--)
            {
                if (i == 0)
                {
                    switch(direction)
                    {
                        case "left":
                            Snake[0].X-=20; break;
                        case "right":
                            Snake[0].X+=20; break;
                        case "up":
                            Snake[0].Y-=20; break;
                        case "down":
                            Snake[0].Y+=20; break;
                    }
                    if (Snake[0].X<0|| Snake[0].Y < 0 || Snake[0].X > suprafataPanel.Width || Snake[0].Y > suprafataPanel.Height)
                    {
                        Lose();
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[0].X == Snake[j].X && Snake[0].Y == Snake[j].Y)
                        {
                           Lose();
                        }
                    }
                    if ( Math.Abs(Snake[0].X -food.X)<=20 && Math.Abs(Snake[0].Y - food.Y) <= 20)
                    {
                        EatFood();
                    }

                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void EatFood()
        {
            punctaj += 10;
           
           
            NewFood();
            CircleModel corp = new CircleModel();
            corp.X = Snake[Snake.Count - 1].X;
            corp.Y = Snake[Snake.Count-1].Y;
            Snake.Add(corp);
            
          
             
            gameTimer.Stop(); 
             Intrebare intrebare = new Intrebare();
            intrebare.ShowDialog(); 
            punctaj += intrebare.punctaj;
            gameTimer.Start();
           
            punctajLabel.Text = " Afiseaza punctaj : " + punctaj;
        }

        private void Lose()
        {
            gameTimer.Stop();
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            MoveSarpe();
            DrawGame();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }
    }
}
