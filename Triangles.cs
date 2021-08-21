using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing_Table
{
    class Triangles : Scene
    {
        public override double TrianglesArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public int k;

        public Point Location { get; set; }
        public Color Color { get; set; }
        public void Paint(Graphics graphics)
        {
                if (k == 1)
                    using (var brush = new SolidBrush(Color.FromArgb(
                        Math.Min(byte.MaxValue, Color.R + 100),
                        Math.Min(byte.MaxValue, Color.G + 100),
                        Math.Min(byte.MaxValue, Color.B + 100))))
                    {
                    PointF[] points = {
                        new PointF(Location.X, Location.Y), new PointF(Location.X + C / 2, Location.Y + A),
                        new PointF(Location.X + C / 2, Location.Y + A),new PointF(Location.X - C / 2, Location.Y + A),
                        new PointF(Location.X - C / 2, Location.Y + A), new PointF(Location.X, Location.Y)
                        };
                    graphics.FillPolygon(brush, points);
                    }
            
            if (k == 2)
                using (var pen = new Pen(Color, 2))
            {
                graphics.DrawLine(pen, Location.X, Location.Y, Location.X + C / 2, Location.Y + A);
                graphics.DrawLine(pen, Location.X + C / 2, Location.Y + A, Location.X - C / 2, Location.Y + A);
                graphics.DrawLine(pen, Location.X - C / 2, Location.Y + A, Location.X, Location.Y);
            }

        }
        public bool Contains(Point point)
        {
            return
                Location.X - C / 2 < point.X && point.X < (Location.X - C / 2) + C &&
                Location.Y < point.Y && point.Y < Location.Y + A;
        }
    }
}
