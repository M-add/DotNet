using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToe
{
    class RoundButton:Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; 

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(Width - (radius * 2), Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(0, Height - (radius * 2), radius * 2, radius * 2, 90, 90);
           
            this.Region = new Region(path);
            base.OnPaint(e);
        }
    }
}
