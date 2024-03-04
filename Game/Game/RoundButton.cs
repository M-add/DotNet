using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class RoundButton : Button
    {
        private Color defaultColor; 
        public RoundButton()
        {
            defaultColor = BackColor;
            FlatStyle = FlatStyle.Flat;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            path.AddArc(5, 5, radius * 2, radius * 2, 180, 90);
            path.AddArc(Width - (radius * 2) - 5, 5, radius * 2, radius * 2, 270, 90);
            path.AddArc(Width - (radius * 2) - 5, Height - (radius * 2) - 5, radius * 2, radius * 2, 0, 90);
            path.AddArc(5, Height - (radius * 2) - 5, radius * 2, radius * 2, 90, 90);

            Region = new Region(path);
            base.OnPaint(e);
        }

        //protected override void OnMouseMove(MouseEventArgs mevent)
        //{
        //    base.OnMouseMove(mevent);
        //    defaultColor = BackColor;
        //    BackColor = Color.FromArgb(150, defaultColor);
        //}
        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    base.OnMouseLeave(e);
        //    BackColor = defaultColor;
        //}
    }
}
