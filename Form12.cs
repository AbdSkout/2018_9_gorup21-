using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form12 : Form
    {

        static string player2;
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10("pc");
            f10.Show();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                button3.Visible = true;
            else
                button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Visible == true)
            {
                this.Hide();
                Form10 f10 = new Form10(textBox1.Text);
                f10.Show();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label2.Visible = true;
            textBox1.Visible = true;
            player2 = textBox1.Text;
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
