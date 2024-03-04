using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Bot : Knights
    {
        private Timer timer;
        private float speed = 3;

        public Bot()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 33;
            timer.Tick += Update;
            timer.Start();
            DoubleBuffered = true;
        }

        private void Update(object sender, EventArgs e)
        {
            Monster monster = Closest();
            if (monster != null)
            {
                MoveTowards(monster.Location.X, monster.Location.Y, speed);
            }
        }

        public void MoveTowards(int x, int y, float speed)
        {
            Point point = Location;

            float tx = x - point.X;
            float ty = y - point.Y;
            float length = (float)Math.Sqrt(tx * tx + ty * ty);

            if (length > speed)
            {
                point.X = (int)(point.X + speed * tx / length);
                point.Y = (int)(point.Y + speed * ty / length);

                Location = new Point(point.X, point.Y);
            }
            else
            {
                point.X = x;
                point.Y = y;
                Location = new Point(point.X, point.Y);
            }
        }

        private Monster Closest()
        {
            Monster closest = null;
            int distance = 9999;

            if (Core.Monsters.Count > 0)
            {
                foreach (var monster in Core.Monsters)
                {
                    float tx = monster.Location.X - Location.X;
                    float ty = monster.Location.Y - Location.Y;
                    int length = (int)Math.Sqrt(tx * tx + ty * ty);

                    if (length < distance)
                    {
                        distance = length;
                        closest = monster;
                    }
                }
            }

            return closest;
        }
    }
}
