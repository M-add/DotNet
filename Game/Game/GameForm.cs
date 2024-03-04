using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {
        private KnightPlayer Player;
        private Bot bot;

        int Count = Core.Enemies;
        private HashSet<Monster> defeated = new HashSet<Monster>();
        private List<Monster> temp = new List<Monster>();
        private int[] MonstrerMoments = { 10, -10, 0, 15, -15, };

        private Timer MonsterTimer;
        private Timer MonsterMoment;
        private DateTime time;
        private int width;
        private int height;

        public GameForm(KnightPlayer player)
        {
            InitializeComponent();

            width = Width;
            height = Height;

            RemainLabel.Text = Core.Enemies.ToString();

            Player = player;
            Player.Location = new Point(0, (Height * 33) / 100);

            bot = new Bot();
            bot.Location = new Point(0, (Height * 10) / 100);

            MainPanel.Controls.Add(Player);
            MainPanel.Controls.Add(bot);

            MonsterTimer = new Timer
            {
                Interval = 1000
            };
            MonsterTimer.Tick += DeployMonsters;

            time = DateTime.Now;
            MonsterTimer.Start();

            MonsterMoment = new Timer()
            {
                Interval = 300
            };
            MonsterMoment.Tick += MonsterMomentTick;
            MonsterMoment.Start();

            DoubleBuffered = true;
        }

        private void MonsterMomentTick(object sender, EventArgs e)
        {
            Random move = new Random();
            foreach (Monster monster in temp)
            {
                int x = MonstrerMoments[move.Next(0, 4)];
                int y = MonstrerMoments[move.Next(0, 4)];

                int newX = monster.Left + x;
                int newY = monster.Top + y;

                if (newX >= 0 && newX + monster.Width <= MainPanel.Width &&
                    newY >= 0 && newY + monster.Height <= MainPanel.Height)
                {
                    monster.Left = newX;
                    monster.Top = newY;
                }

                //if(monster.Location.X >= MainPanel.Width || monster.Location.Y >= MainPanel.Height)
                //{
                //    Close();
                //    MessageBox.Show("Game Over");
                //}
            }
        }
        private bool CheckBounds(Monster Current)
        {
            if (temp.Count > 0)
            {
                foreach (Monster monster in temp)
                {
                    if (Current != monster && Current.Bounds.IntersectsWith(monster.Bounds))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void DeployMonsters(object sender, EventArgs e)
        {
            Random spawn = new Random();
            if (temp.Count < Core.Enemies)
            {
                int x = spawn.Next(0, Width - (Width * 13) / 100);
                int y = spawn.Next(0, Height - (Height * 22) / 100);
                if (x == Player.Location.X)
                {
                    x += (x + Player.Width <= Width) ? Player.Width : -Player.Width;
                }
                Monster monsters = new Monster(x, y);
                monsters.Size = new Size((Width * 13) / 100, (Height * 22) / 100);

                if (CheckBounds(monsters) && !monsters.Bounds.IntersectsWith(RemainLabel.Bounds) && Core.Monsters.Count < Core.Enemies)
                {
                    temp.Add(monsters);
                    Core.Monsters.Add(temp[temp.Count - 1]);
                    Graphics g = MainPanel.CreateGraphics();
                    // g.DrawImage(monsters.pic.Image , monsters.Location);
                    MainPanel.Controls.Add(temp[temp.Count - 1]);
                }
            }

            if (defeated.Count == Core.Enemies)
            {
                MonsterTimer.Stop();
                MonsterMoment.Stop();
                Player.StandBy();

                TimeSpan elapsedTime = DateTime.Now - time;
                defeated.Clear();
                Core.IsDown = Core.IsLeft = Core.IsUp = Core.IsRight = false;
                temp.Clear();

                LevelCompletion display = new LevelCompletion(elapsedTime);
                display.Size = new Size((Width * 50 / 100), (Height * 49) / 100);
                Hide();
                display.Show();

                bot.Dispose();
            }
        }

        private void GameFormLoad(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp && Player.Location.Y - 4 > 0)
            {
                Core.IsUp = true;
                //Player.Top -= 4;
            }
            if (e.KeyCode == Core.KeyDown && Player.Location.Y + Player.Height + 4 < MainPanel.Height)
            {
                Core.IsDown = true;
                //Player.Top += 4;
            }
            if (e.KeyCode == Core.KeyRight && Player.Location.X + Player.Width + 4 < MainPanel.Width)
            {
                Core.IsRight = true;
                //Player.Left += 4;
                Player.RunRight();
            }
            if (e.KeyCode == Core.KeyLeft && Player.Location.X - 4 > 0)
            {
                Core.IsLeft = true;
                //Player.Left -= 4;
                Player.RunLeft();
            }
        }
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = false;
            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = false;
            if (e.KeyCode == Core.KeyRight)
                Core.IsRight = false;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = false;

            if (!Core.IsUp && !Core.IsDown && !Core.IsRight && !Core.IsLeft)
            {
                Player.StandBy();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Core.GameState = WindowState;

            if (Player != null)
            {
                Player.Size = new Size((Width * 9) / 100, (Height * 20) / 100);
                bot.Size = new Size((Width * 9) / 100, (Height * 20) / 100);
            }

            //RemainLabel.Size = new Size((Width * 12) / 100, (Height * 10) / 100);
            if (temp.Count > 0)
            {
                foreach (Monster monster in temp)
                {
                    monster.Size = new Size((Width * 13) / 100, (Height * 22) / 100);
                    int x = (int)(monster.Location.X / (float)width * 100);
                    int y = (int)(monster.Location.Y / (float)height * 100);
                    monster.Location = new Point((Width * x) / 100, (Height * y) / 100);
                }
            }
            if (Player != null)
            {
                Player.Location = new Point(Player.Location.X, (Height * 45) / 100);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void updateBot(object sender, EventArgs e)
        {
            try
            {
                foreach (var monster in Core.Monsters)
                {
                    foreach (Knights control in MainPanel.Controls.OfType<Knights>())
                    {
                        if (control.Bounds.IntersectsWith(monster.Bounds))
                        {
                            monster.OnTouch();
                            defeated.Add(monster);
                            RemainLabel.Text = (Core.Enemies - defeated.Count).ToString();
                            Core.Monsters.Remove(monster);
                        }
                    }
                }
            }
            catch { }
        }
    }
}
