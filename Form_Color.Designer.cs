namespace Drawing_Table
{
    partial class Form_Color
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
            this.Green = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.Yellow = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Black = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(129, 227);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(69, 21);
            this.Green.TabIndex = 9;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(129, 191);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(55, 21);
            this.Red.TabIndex = 8;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.Location = new System.Drawing.Point(129, 154);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(69, 21);
            this.Yellow.TabIndex = 7;
            this.Yellow.TabStop = true;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.CheckedChanged += new System.EventHandler(this.Yellow_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(129, 117);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(57, 21);
            this.Blue.TabIndex = 6;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // Black
            // 
            this.Black.AutoSize = true;
            this.Black.Location = new System.Drawing.Point(129, 80);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(63, 21);
            this.Black.TabIndex = 5;
            this.Black.TabStop = true;
            this.Black.Text = "Black";
            this.Black.UseVisualStyleBackColor = true;
            this.Black.CheckedChanged += new System.EventHandler(this.Black_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Black);
            this.Name = "Form_Color";
            this.Text = "Form_Color";
            this.Load += new System.EventHandler(this.Form_Color_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Yellow;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Black;
        private System.Windows.Forms.Button button1;
    }
}