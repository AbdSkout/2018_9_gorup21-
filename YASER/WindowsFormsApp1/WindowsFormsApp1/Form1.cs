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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //label3.Text = "right password!";
            string username, password;
            StreamReader file = new StreamReader(@"C:\Users\user\Desktop\New folder\text.txt");
            username = file.ReadLine();
           
            while (username != null)
            {
                if (username == (textBox1.Text))
                {
                    password = file.ReadLine();
                    if (textBox2.Text != password)
                    {
                        label3.Visible = true;
                        label3.Text = "wrong password!";
                        break;
                    }
                    else
                    {
                        label3.Text = "right password!";
                        break;

                        //go to the next page
                        /*
                         thia.Hide();
                         Form2 f2=new Form2();
                         f2.ShowDialouge();
                         */
                    }
                }
                else
                {
                    while (username != "***")
                        username = file.ReadLine();
                    username = file.ReadLine();
                }
            }
            file.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
