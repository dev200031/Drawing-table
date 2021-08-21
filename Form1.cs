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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Rectangle");
            comboBox1.Items.Add("Triangle");
            comboBox1.Items.Add("Circle");

         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex== 0)
            {
                this.Hide();
                Rectangles f2 = new Rectangles();
                f2.ShowDialog();
                this.Close();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                this.Hide();
                Triangle f3 = new Triangle();
                f3.ShowDialog();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
