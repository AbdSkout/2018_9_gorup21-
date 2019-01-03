using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class ForgotPassword : Form
    {
        string answer;
        string password;
        string username;
        public ForgotPassword(string name)
        {
            InitializeComponent();
            username = name;

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("text.txt");
            string name = file.ReadLine();
           string temp = file.ReadLine();
            
            
            if (username == name)
            {
                password = temp;
                 label2.Text = file.ReadLine();
                 answer = file.ReadLine();

            }
            else
               while ( name != null)
            {
                while (name != "***")
                    name = file.ReadLine();

                name= file.ReadLine();
                temp = file.ReadLine();

                if (username == name)
                {
                    password = temp;
                    label2.Text = file.ReadLine();
                    answer = file.ReadLine();

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (answer == textBox1.Text)
            {
                label4.Text="your password is:";
                label4.ForeColor = System.Drawing.Color.Green;

                textBox2.Text = password;
                label4.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label4.Visible = true;
                label4.Text = "wrong answer!";
                label4.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }
    }
}
