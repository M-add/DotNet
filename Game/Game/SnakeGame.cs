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
    public partial class SnakeGame : Form
    {
        private const int GridSize = 30;
        private const int InitialSnakeLength = 3;

        private List<Point> snake;
        private Point food;
        private int score;
        private Direction direction;
        private Timer GameStart;

        enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public SnakeGame()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            snake = new List<Point>
            {
                new Point(2, 2)
            };

            direction = Direction.Right;
            score = 0;

            GameStart = new Timer
            {
                Interval = 200
            };
            GameStart.Tick += TimerTick;
            GameStart.Start();

            GenerateFood();

            DoubleBuffered = true;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollision();
            Invalidate();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        private void SnakeGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            //DrawGrid(e.Graphics);
            DrawSnake(e.Graphics);
            DrawFood(e.Graphics);
            DrawScore(e.Graphics);
        }

        //private void DrawGrid(Graphics g)
        //{
        //    int width = ClientSize.Width;
        //    int height = ClientSize.Height;

        //    for (int x = 0; x < width; x += GridSize)
        //    {
        //        for (int y = 0; y < height; y += GridSize)
        //        {
        //            g.DrawRectangle(Pens.LightGray, x, y, GridSize, GridSize);
        //        }
        //    }
        //}

        private void DrawSnake(Graphics g)
        {
            foreach (Point segment in snake)
            {
                g.FillRectangle(Brushes.Green, segment.X * GridSize, segment.Y * GridSize, 
                    GridSize, GridSize);
            }
            g.FillEllipse(Brushes.Black, snake.Last().X * GridSize + 20, snake.Last().Y * GridSize, 10, 10);
            g.FillEllipse(Brushes.Black, snake.Last().X * GridSize + 20,
                snake.Last().Y * GridSize + 20, 10, 10);
        }

        private void DrawFood(Graphics g)
        {
            g.FillEllipse(Brushes.Red, food.X * GridSize, food.Y * GridSize, GridSize, GridSize);
        }

        private void DrawScore(Graphics g)
        {
            string scoreText = "Score: " + score;
            g.DrawString(scoreText, Font, Brushes.Black, new Point(10, 10));
        }

        private void MoveSnake()
        {
            Point head = snake.Last();
            Point newHead = Point.Empty;

            switch (direction)
            {
                case Direction.Up:
                    newHead = new Point(head.X, head.Y - 1);
                    break;
                case Direction.Down:
                    newHead = new Point(head.X, head.Y + 1);
                    break;
                case Direction.Left:
                    newHead = new Point(head.X - 1, head.Y);
                    break;
                case Direction.Right:
                    newHead = new Point(head.X + 1, head.Y);
                    break;
            }

            snake.Add(newHead);

            if (snake.Count > score + InitialSnakeLength)
            {
                snake.RemoveAt(0);
            }
        }

        private void CheckCollision()
        {
            Point head = snake.Last();

            if (head.X < 0 || head.X >= ClientSize.Width / GridSize ||
                head.Y < 0 || head.Y >= ClientSize.Height / GridSize)
            {
                EndGame();
                return;
            }

            for (int i = 0; i < snake.Count - 1; i++)
            {
                if (head == snake[i])
                {
                    EndGame();
                    return;
                }
            }

            if (head == food)
            {
                score++;
                GenerateFood();
            }
        }

        private void GenerateFood()
        {
            Random rand = new Random();
            food = new Point(rand.Next(ClientSize.Width / GridSize), rand.Next(ClientSize.Height / GridSize));
        }

        private void EndGame()
        {
            GameStart.Stop();
            MessageBox.Show("Game over! Your score: " + score);
            InitializeGame();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    if (direction != Direction.Down)
                        direction = Direction.Up;
                    break;
                case Keys.W:
                    if (direction != Direction.Down)
                        direction = Direction.Up;
                    break;
                case Keys.Down:
                    if (direction != Direction.Up)
                        direction = Direction.Down;
                    break;
                case Keys.S:
                    if (direction != Direction.Up)
                        direction = Direction.Down;
                    break;
                case Keys.Left:
                    if (direction != Direction.Right)
                        direction = Direction.Left;
                    break;
                case Keys.A:
                    if (direction != Direction.Right)
                        direction = Direction.Left;
                    break;
                case Keys.Right:
                    if (direction != Direction.Left)
                        direction = Direction.Right;
                    break;
                case Keys.D:
                    if (direction != Direction.Left)
                        direction = Direction.Right;
                    break;
                case Keys.Space:
                    GameStart.Enabled = !GameStart.Enabled;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
