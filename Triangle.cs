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
    public partial class Triangle : Form
    {
        private int draw_way=0;
        public Triangle()
        {
            InitializeComponent();
            
        }

        private void Triangle_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            triangle_draw.k = 1;
            using (var graphics = CreateGraphics())
            {

                triangle_draw.Color = Color.Blue;
                triangle_draw.Paint(graphics);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Triangle_MouseUp(object sender, MouseEventArgs e)
        {
            figures figures = new figures();
            Triangles triangle_draw = new Triangles();
            figures.AddShape(new Triangles());
            triangle_draw.Location = e.Location;
            triangle_draw.A = float.Parse(A.Text);
            triangle_draw.B = float.Parse(B.Text);
            triangle_draw.C = float.Parse(C.Text);
            textbox_s.Text = triangle_draw.TrianglesArea().ToString();
            if (e.Button == MouseButtons.Right)
            {
                using (var graphics = CreateGraphics())
                {
                    triangle_draw.Paint(graphics);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Triangles triangle_draw = new Triangles();
        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Triangle_MouseDown(object sender, MouseEventArgs e)
        {
            if (draw_way == 0)
                if (e.Button == MouseButtons.Right)
                {
                    triangle_draw.k = 2;
                    triangle_draw.Location = e.Location;
                    triangle_draw.A = int.Parse(A.Text);
                    triangle_draw.B = int.Parse(B.Text);
                    triangle_draw.C = int.Parse(C.Text);
                    triangle_draw.Color = Color.Blue;
                    using (var graphics = CreateGraphics())
                    {
                        triangle_draw.Paint(graphics);
                        draw_way++;
                    }

                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Color f6 = new Form_Color();
            f6.ShowDialog();

            using (var graphics = CreateGraphics())
            {
                triangle_draw.k = 1;
                if (Form_Color.answer == "Black")
                    triangle_draw.Color = Color.Black;
                if (Form_Color.answer == "Yellow")
                    triangle_draw.Color = Color.Yellow;
                if (Form_Color.answer == "Red")
                    triangle_draw.Color = Color.Red;
                if (Form_Color.answer == "Green")
                    triangle_draw.Color = Color.Green;
                if (Form_Color.answer == "Blue")
                    triangle_draw.Color = Color.Blue;
                triangle_draw.Paint(graphics);
            }
            f6.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Color f6 = new Form_Color();
            f6.ShowDialog();
            f6.Close();
            using (var graphics = CreateGraphics())
            {
                triangle_draw.k = 2;
                if (Form_Color.answer == "Black")
                    triangle_draw.Color = Color.Black;
                if (Form_Color.answer == "Yellow")
                    triangle_draw.Color = Color.Yellow;
                if (Form_Color.answer == "Red")
                    triangle_draw.Color = Color.Red;
                if (Form_Color.answer == "Green")
                    triangle_draw.Color = Color.Green;
                if (Form_Color.answer == "Blue")
                    triangle_draw.Color = Color.Blue;
                triangle_draw.Paint(graphics);
            }
        }
    }
}
