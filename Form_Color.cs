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
    public partial class Form_Color : Form
    {
        public static string answer;
        public Form_Color()
        {
            InitializeComponent();
            //Black.AutoCheck = false;
        }

        private void Black_CheckedChanged(object sender, EventArgs e)
        {
            //bBlack.AutoCheck = true;
            answer = "Black"; 
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            answer = "Blue"; 
        }

        private void Yellow_CheckedChanged(object sender, EventArgs e)
        {
            answer = "Yellow"; 
        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            answer = "Red"; 
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            answer = "Green";
        }

        private void Form_Color_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
