using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public static class Core
    {
        public static KnightPlayer player;

        public readonly static Keys KeyUp = Keys.W;
        public readonly static Keys KeyLeft = Keys.A;
        public readonly static Keys KeyRight = Keys.D;
        public readonly static Keys KeyDown = Keys.S;

        public static bool IsUp = false;
        public static bool IsDown = false;
        public static bool IsRight = false;
        public static bool IsLeft = false;

        public static List<Monster> Monsters = new List<Monster>();
        public static int Level = 1;
        public static int Enemies = 5;

        public static FormWindowState FormState;
        public static FormWindowState GameState;
    }
}
