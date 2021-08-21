namespace Drawing_Table
{
    partial class Rectangles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_s = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(626, 102);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 22);
            this.A.TabIndex = 1;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(626, 131);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 22);
            this.B.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 52);
            this.label1.TabIndex = 14;
            this.label1.Text = "RECTANGLE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 25);
            this.button1.TabIndex = 32;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Would you like to change the shape?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rectangle",
            "Triangle",
            "Circle"});
            this.comboBox1.Location = new System.Drawing.Point(471, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 351);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 21);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fill";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "B";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 33);
            this.button2.TabIndex = 40;
            this.button2.Text = "Change Fill Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 32);
            this.button3.TabIndex = 41;
            this.button3.Text = "Border Color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "S";
            // 
            // textbox_s
            // 
            this.textbox_s.Location = new System.Drawing.Point(626, 181);
            this.textbox_s.Name = "textbox_s";
            this.textbox_s.Size = new System.Drawing.Size(100, 22);
            this.textbox_s.TabIndex = 43;
            // 
            // Rectangles
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(738, 385);
            this.Controls.Add(this.textbox_s);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Rectangles";
            this.Load += new System.EventHandler(this.Rectangles_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rectangles_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rectangles_MouseDown_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rectangles_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_s;
    }
}