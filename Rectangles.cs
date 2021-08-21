using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Table
{
    public partial class Rectangles : Form
    {
        private int draw_way = 0;
        public Rectangles()
        {
            InitializeComponent();
        }    
        protected override void OnPaint(PaintEventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rectangles_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Rectangles_Load(object sender, EventArgs e)
        {

        }
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _selectedRectangle = null;
        
        Rectangle rectangle_draw = new Rectangle();
        
        private void Rectangles_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.Hide();
                Rectangles f2 = new Rectangles();
                f2.ShowDialog();
                this.Close();
            }


            if (comboBox1.SelectedIndex == 1)
            {
                this.Hide();
                Triangle f4 = new Triangle();
                f4.ShowDialog();
                this.Close();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                this.Hide();
                Circle f4 = new Circle();
                f4.ShowDialog();
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rectangle_draw.k = 1;
            using (var graphics = CreateGraphics())
            {
               
                    rectangle_draw.Color = Color.Blue;
                rectangle_draw.Paint(graphics);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            using (var graphics = CreateGraphics())
            {
                rectangle_draw.k = 2;
               

                rectangle_draw.Paint(graphics);

            }
        }

        private void Rectangles_MouseDown_1(object sender, MouseEventArgs e)
        {
            figures figures = new figures();
            if (draw_way == 0)
                if (e.Button == MouseButtons.Right)
                {
                    figures.AddShape(new Rectangle());
                    rectangle_draw.k = 2;
                    rectangle_draw.Location = e.Location;
                    rectangle_draw.Widht = int.Parse(A.Text);
                    rectangle_draw.Height = int.Parse(B.Text);
                    textbox_s.Text = rectangle_draw.RectangleArea().ToString();
                    rectangle_draw.Color = Color.Blue;
                    using (var graphics = CreateGraphics())
                    {
                        rectangle_draw.Paint(graphics);
                        draw_way++;
                    }

                }
            
        }

        private void Rectangles_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Color f5 = new Form_Color();
            f5.ShowDialog();
            using (var graphics = CreateGraphics())
            {
                rectangle_draw.k = 1;
                if (Form_Color.answer == "Black")
                    rectangle_draw.Color = Color.Black;
                if (Form_Color.answer == "Yellow")
                    rectangle_draw.Color = Color.Yellow;
                if (Form_Color.answer == "Red")
                    rectangle_draw.Color = Color.Red;
                if (Form_Color.answer == "Green")
                    rectangle_draw.Color = Color.Green;
                if (Form_Color.answer == "Blue")
                    rectangle_draw.Color = Color.Blue;
                rectangle_draw.Paint(graphics);
            }
            f5.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Color f6 = new Form_Color();
            f6.ShowDialog();

            using (var graphics = CreateGraphics())
            {
                rectangle_draw.k = 2;
                if (Form_Color.answer == "Black")
                    rectangle_draw.Color = Color.Black;
                if (Form_Color.answer == "Yellow")
                    rectangle_draw.Color = Color.Yellow;
                if (Form_Color.answer == "Red")
                    rectangle_draw.Color = Color.Red;
                if (Form_Color.answer == "Green")
                    rectangle_draw.Color = Color.Green;
                if (Form_Color.answer == "Blue")
                    rectangle_draw.Color = Color.Blue;
                rectangle_draw.Paint(graphics);
            }
            f6.Close();
        }
    }
}

