using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace Drawing_Table
{
    
    class Rectangle:Scene
    {
        public override double RectangleArea()
        {
            return Widht*Height;
        }
        public int k;
        public Point Location { get; set; }
        public Color Color { get; set; }
        public int order { get; set; }
        public void Paint(Graphics graphics)
        {
            if(k==1)
            using (var brush = new SolidBrush(Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 100),
                Math.Min(byte.MaxValue, Color.G + 100),
                Math.Min(byte.MaxValue, Color.B + 100))))
            {
                graphics.FillRectangle(brush, Location.X, Location.Y, Widht, Height);
            }
            if (k == 2)
                using (var pen = new Pen(Color, 2))
            {
                graphics.DrawRectangle(pen, Location.X, Location.Y, Widht, Height);
                graphics.DrawLine(pen, Location.X, Location.Y, Location.X + Widht, Location.Y + Height);
            }
        }
        public bool Contains(Point point)
        {
            return
                Location.X < point.X && point.X < Location.X + Widht &&
                Location.Y < point.X && point.Y < Location.Y + Height;
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    } 
}
