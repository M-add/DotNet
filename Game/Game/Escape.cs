using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Escape : Form
    {
        private int Brick = 20;
        private int radius = 30;
        private int temp = 31;
        private bool up = false;
        private bool down = true;

        private Label ScoreLabel;
        private Random rand = new Random();
        private List<int> random;
        private Timer timer;
        private Color[] CannonBallColor;
        private List<CanonBall> CannonBalls;
        private PictureBox Player;

        public Escape()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //KeyPreview = true;
            CannonBalls = new List<CanonBall>();
            ScoreLabel = new Label()
            {
                AutoSize = false,
                Size = new Size(100, 50),
                BackColor = Color.HotPink,
                Location = new Point(Right - 120, Top + 10),
                Text = "0",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Tai Le", 10, FontStyle.Regular)
            };
            Controls.Add(ScoreLabel);

            timer = new Timer()
            {
                Interval = 1000
            };
            timer.Tick += TimerTick;
            timer.Start();

            KeyDown += EscapeKeyDown;
        }
   
        private void Escape_Load(object sender, EventArgs e)
        {
            random = new List<int>();
            for (int x = 1; x < ClientSize.Width - 3; x += Brick)
            {
                random.Add(rand.Next(10, 15));
            }

            CannonBallColor = new Color[]
            {
                Color.Black,
                Color.SteelBlue,
                Color.LawnGreen,
                Color.Crimson,
            };

            Player = new PictureBox()
            {
                Image = Properties.Resources.Assassin,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(10, Height / 2),
                Size = new Size(50, 40)
            };
            Controls.Add(Player);
        }
        private void TimerTick(object sender, EventArgs e)
        {
            foreach (var cannonBall in CannonBalls)
            {
                if (cannonBall.IsActive)
                    cannonBall.Move();
            }
            CannonBalls.RemoveAll(c => !c.IsActive);

            if (down)
            {
                if (temp <= 58)
                {
                    temp += 7;
                }
                else
                {
                    temp -= 7;
                    down = false;
                    up = true;
                }
            }
            else if (up)
            {
                if (temp >= 33)
                {
                    temp -= 7;
                }
                else
                {
                    temp += 7;
                    down = true;
                    up = false;
                }
            }
            Invalidate();
        }

        private void CheckCollison()
        {
            int Score = int.Parse(ScoreLabel.Text);

            for (int i = 0; i < CannonBalls.Count; i++)
            {
                var ball = CannonBalls[i];
                if (Player.Bounds.IntersectsWith(new Rectangle(ball.X, ball.Y, ball.radius, ball.radius)))
                {
                    if (ball.color == Color.Black)
                    {
                        timer.Stop();
                        MessageBox.Show("Game Over Your Score is - " + Score);
                    }
                    else if (ball.color == Color.Crimson)
                    {
                        Score += 5;
                    }
                    else if (ball.color == Color.SteelBlue)
                    {
                        Score += 3;
                    }
                    else if (ball.color == Color.LawnGreen)
                    {
                        Score += 1;
                    }
                    ScoreLabel.Text = Score.ToString();
                    CannonBalls.RemoveAt(i);
                }
            }
        }

        private void EscapePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.OrangeRed, 3);
            DrawLowerWall(e.Graphics, pen);
            DrawUpperWall(e.Graphics, pen);
            DrawCanon(e.Graphics);
        }

        private void DrawCanon(Graphics g)
        {
            int x = ClientSize.Width - 70;
            //int y = rand.Next((Height * 41) / 100, (Height * 63) / 100);
            int y = (Height * temp) / 100;
            g.FillRectangle(Brushes.RoyalBlue, x, y, 80, 35);
            Color color = CannonBallColor[rand.Next(0, 4)];
            CanonBall cannon = new CanonBall(x - radius, y + 1, color);
            CannonBalls.Add(cannon);

            FireCanon(g);
        }
        private void FireCanon(Graphics g)
        {
            bool ColorProb = true;
            foreach (var cannonBall in CannonBalls)
            {
                g.FillEllipse(new SolidBrush(cannonBall.color), cannonBall.X, cannonBall.Y, radius, radius);
                if (cannonBall.X <= 0)
                {
                    cannonBall.IsActive = false;
                }
                int n = rand.Next(0, 100);
                if (ColorProb && n == 3)
                {
                    ColorProb = false;
                    cannonBall.color = CannonBallColor[rand.Next(0, 4)];
                }
            }
        }

        private void DrawUpperWall(Graphics g, Pen pen)
        {
            int LowX = 1;
            int LowY = 1;
            int height = (Height * 30) / 100, count = 0;


            g.FillRectangle(Brushes.Orange, LowX, LowY, ClientSize.Width - 3, height);

            for (int x = LowX; x < ClientSize.Width - 3; x += Brick)
            {
                for (int y = LowY; y < height - 10; y += random[count])
                {
                    g.DrawRectangle(Pens.White, x, y, Brick, random[count]);
                }
                count++;
            }

            g.DrawRectangle(pen, LowX, LowY, ClientSize.Width - 3, height);
        }

        private void DrawLowerWall(Graphics g, Pen pen)
        {
            int LowX = 1;
            int LowY = (Height * 70) / 100;
            int count = 0;

            g.FillRectangle(Brushes.Orange, LowX, LowY, ClientSize.Width - 3, Height - LowY);

            for (int x = LowX; x < ClientSize.Width - 3; x += Brick)
            {
                for (int y = LowY; y < Height; y += random[count])
                {
                    g.DrawRectangle(Pens.White, x, y, Brick, random[count]);
                }
                count++;
            }

            g.DrawRectangle(pen, LowX, LowY, ClientSize.Width - 3, Height - LowY);
        }

        private void EscapeKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && Player.Top - 6 > (Height * 30) / 100)
            {
                Player.Location = new Point(Player.Location.X, Player.Location.Y - 6);
            }
            if (e.KeyCode == Keys.S && Player.Location.Y + Player.Height + 6 < (Height * 70) / 100)
            {
                Player.Location = new Point(Player.Location.X, Player.Location.Y + 6);
            }
            if (e.KeyCode == Keys.D && Player.Location.X + Player.Width + 6 < (ClientSize.Width * 70) / 100)
            {
                Player.Location = new Point(Player.Location.X + 6, Player.Location.Y);
            }
            if (e.KeyCode == Keys.A && Player.Location.X - 6 > 0)
            {
                Player.Location = new Point(Player.Location.X - 6, Player.Location.Y);
            }
            CheckCollison();
         }

        private void EscapeKeyUp(object sender, KeyEventArgs e)
        {
        }
    }

    public class CanonBall
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int radius = 30;
        public int Speed { get; } = 60;
        public Color color;
        public bool IsActive { get; set; } = true;

        public CanonBall(int x, int y, Color c)
        {
            X = x;
            Y = y;
            color = c;
        }

        public void Move()
        {
            X -= Speed;
        }
    }
}
