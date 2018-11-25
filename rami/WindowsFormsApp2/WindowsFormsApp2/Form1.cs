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
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string answer;
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(@"C:\Users\abd\Desktop\s\text.txt");
            string username = textBox1.Text;
            string temp = file.ReadLine();
            temp = file.ReadLine();
            while (temp != username && temp != null) 
            {
                temp = file.ReadLine();
            }
            password=file.ReadLine();
            label2.Text = file.ReadLine();
            answer = file.ReadLine();
            file.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answer == textBox1.Text )
            {
                textBox2.Text = answer;
                label4.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label4.Visible = true;
                label4.Text = "wrong answer!";
            }

        }
    }
}
