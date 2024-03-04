using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DragAndDrop
{
    public class CircleButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = Math.Min(Width, Height) / 2;

            path.AddEllipse(0, 0, radius * 2, radius * 2);

            this.Region = new Region(path);
            base.OnPaint(pevent);
        }
    }
}
