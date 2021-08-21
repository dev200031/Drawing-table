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

    public partial class Circle : Form
    {
        private int draw_way = 0;
        public Circle()
        {
            InitializeComponent();
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

        private void Circle_Load(object sender, EventArgs e)
        {

        }
        Circles circle_draw = new Circles();
        figures figures = new figures();
        private void Circle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && draw_way==0)
            {
                figures.AddShape(new Circles());
                circle_draw.Location = e.Location;
                circle_draw.R = float.Parse(R.Text);
                textbox_s.Text = circle_draw.CircleArea().ToString();
                if (e.Button == MouseButtons.Right)
                {
                    using (var graphics = CreateGraphics())
                    {
                        draw_way++;
                        circle_draw.k = 2;
                        circle_draw.Color = Color.Blue;
                        circle_draw.Paint(graphics);
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            
            circle_draw.k = 1;
            using (var graphics = CreateGraphics())
            {
                circle_draw.Color = Color.Blue;
                circle_draw.Paint(graphics);
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Color f6 = new Form_Color();
            f6.ShowDialog();
            circle_draw.k = 1;
            using (var graphics = CreateGraphics())
            {
                if (Form_Color.answer == "Black")
                    circle_draw.Color = Color.Black;
                if (Form_Color.answer == "Yellow")
                    circle_draw.Color = Color.Yellow;
                if (Form_Color.answer == "Red")
                    circle_draw.Color = Color.Red;
                if (Form_Color.answer == "Green")
                    circle_draw.Color = Color.Green;
                if (Form_Color.answer == "Blue")
                    circle_draw.Color = Color.Blue;
                circle_draw.Paint(graphics);
            }
            f6.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Color f7 = new Form_Color();
            f7.ShowDialog();

            circle_draw.k = 2;
            using (var graphics = CreateGraphics())
            {

                if (Form_Color.answer == "Black")
                    circle_draw.Color = Color.Black;
                if (Form_Color.answer == "Yellow")
                    circle_draw.Color = Color.Yellow;
                if (Form_Color.answer == "Red")
                    circle_draw.Color = Color.Red;
                if (Form_Color.answer == "Green")
                    circle_draw.Color = Color.Green;
                if (Form_Color.answer == "Blue")
                    circle_draw.Color = Color.Blue;
                circle_draw.Paint(graphics);
            }
            f7.Close();
        }
    }
}
