using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing_Table
{
    class Circles : Scene
    {
        public override double CircleArea()
        {
            return Math.PI * r * r;
        }
        public int k;
        public Color Color { get; set; }
        public Point Location { get; set; }
        public void Paint(Graphics graphics)
        {
            if (k == 1)
                using (var brush = new SolidBrush(Color.FromArgb(
                    Math.Min(byte.MaxValue, Color.R + 100),
                    Math.Min(byte.MaxValue, Color.G + 100),
                    Math.Min(byte.MaxValue, Color.B + 100))))
                {
                    graphics.FillEllipse(brush, Location.X, Location.Y,R, R);
                }
            if (k == 2)
                using (var pen = new Pen(Color, 2))
            {
                graphics.DrawEllipse(pen, Location.X, Location.Y, R, R);
            }
        }
        public bool Contains(Point point)
        {
            return
                Location.X < point.X && point.X < Location.X + R &&
                Location.Y < point.X && point.Y < Location.Y + R;
        }
    }
}
