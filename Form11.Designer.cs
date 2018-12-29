namespace WindowsFormsApp1
{
    partial class Form11
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.Panel();
            this.P3 = new System.Windows.Forms.Panel();
            this.P1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "please choose vs who  you want to play";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(94, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Computer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(94, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Player";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2 Name:";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.Transparent;
            this.P2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.animated_dog_png_hd_cute_dog_clipart_image_320;
            this.P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.P2.Location = new System.Drawing.Point(630, 82);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(61, 69);
            this.P2.TabIndex = 8;
            // 
            // P3
            // 
            this.P3.BackColor = System.Drawing.Color.Transparent;
            this.P3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.milyj_kot;
            this.P3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.P3.Location = new System.Drawing.Point(522, 189);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(61, 69);
            this.P3.TabIndex = 7;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.Transparent;
            this.P1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.aa6;
            this.P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.P1.Location = new System.Drawing.Point(522, 82);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(61, 69);
            this.P1.TabIndex = 6;
            this.P1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(646, 59);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(533, 59);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "1";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(533, 159);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "3";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(421, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 39);
            this.label3.TabIndex = 11;
            this.label3.Tag = "";
            this.label3.Text = "Chosse the picture";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(757, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Panel P3;
        private System.Windows.Forms.Panel P2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label3;
    }
}