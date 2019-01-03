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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            StreamReader file = new StreamReader("text.txt");
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
                        else if (textBox2.Text == "admin")
                        {
                        this.Hide();
                        AdminPage f5 = new AdminPage();
                        f5.Show();

                        }
                        else
                        {
                            label3.Visible = true;
                            label3.Text = "right password!";
                        break;
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

            if(label3.Text== "right password!") {
                
                this.Hide();
                UserPage f4 = new UserPage();
                f4.Show();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (check(name))
            {
                this.Hide();
                ForgotPassword f6 = new ForgotPassword(name);
                f6.ShowDialog();
            }
            else
            {
                label3.Text = "wrong username";
                label3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //StreamWriter write = new StreamWriter(@"C:\Users\abdalsk\Desktop\a",true);
            this.Hide();
            SignUp f2 = new SignUp();
            f2.ShowDialog();


            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestPage f3 = new GuestPage();
            f3.Show();

        }
        static bool check(string name)
        {
            StreamReader Read = new StreamReader("text.txt");
            string user = Read.ReadLine();


            if (user == name)
            {
                Read.Close();
                return true;
            }

            while (user != null)
            {
                while (user != "***")
                {
                    user = Read.ReadLine();
                }
                user = Read.ReadLine();

                if (user == name)
                {
                    Read.Close();
                    return true;

                }

            }
            Read.Close();
            return false;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
