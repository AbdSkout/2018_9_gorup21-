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
    public partial class ChoosingPlayer : Form
    {

        static string player2;
        public ChoosingPlayer()
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
            SnakesAndLadders f10 = new SnakesAndLadders("pc");
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
                SnakesAndLadders f10 = new SnakesAndLadders(textBox1.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.isadmin == true) 
            {
                AdminPage page = new AdminPage();
                this.Hide();
                page.ShowDialog();
            }
            else
                if (Program.username == null)
                {
                    GuestPage g = new GuestPage();
                    this.Hide();
                    g.Show();
                }
                else
                {
                    this.Hide();
                    UserPage u = new UserPage();
                    u.Show();
                }
        }
    }
}
