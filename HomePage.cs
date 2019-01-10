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

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
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
                        for (int i = 0; i <= 2; i++)
                        {
                            Program.nameingame = file.ReadLine();

                        }

                        this.Hide();
                        AdminPage f5 = new AdminPage();
                        f5.Show();

                    }
                    else
                    {
                        for (int i = 0; i <= 2; i++)
                        {
                            Program.nameingame = file.ReadLine();

                        }
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

                bool flag_block=false;
                StreamReader s = new StreamReader("blacklist.txt");
                string test = s.ReadLine();
                if (test == textBox1.Text)
                    flag_block = true;

                while (test != "" && test!=null)
                {
                    test = s.ReadLine();
                    if (test == textBox1.Text)
                        flag_block = true;

                }
                this.Hide();
                if (flag_block)
                {
                    you_are_blocked y = new you_are_blocked();
                    y.Show();


                }
                else
                {
                    UserPage f4 = new UserPage();
                    Program.username = username;
                    f4.Show();
                }
            }


        }

        public void button4_Click(object sender, EventArgs e)
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

        public void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            SignUp f2 = new SignUp();
            f2.ShowDialog();


            
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestPage f3 = new GuestPage();
            f3.Show();
            Random rnd = new Random();
           int c = rnd.Next(1, 100);
            string guset = "guset" + c.ToString();
            Program.nameingame = guset;
        }
        public bool check(string name)
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

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp f2 = new SignUp();
            f2.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
                        Program.isadmin = true;
                        for (int i = 0; i <= 2; i++)
                        {
                            Program.nameingame = file.ReadLine();

                        }

                        this.Hide();
                        AdminPage f5 = new AdminPage();
                        f5.Show();

                    }
                    else
                    {
                        for (int i = 0; i <= 2; i++)
                        {
                            Program.nameingame = file.ReadLine();

                        }
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

            if (label3.Text == "right password!")
            {

                bool flag_block = false;
                StreamReader s = new StreamReader("blacklist.txt");
                string test = s.ReadLine();
                if (test == textBox1.Text)
                    flag_block = true;

                while (test != "" && test != null)
                {
                    test = s.ReadLine();
                    if (test == textBox1.Text)
                        flag_block = true;

                }
                s.Close();
                this.Hide();
                if (flag_block)
                {
                    you_are_blocked y = new you_are_blocked();
                    y.Show();


                }
                else
                {
                    UserPage f4 = new UserPage();
                    Program.username = username;
                    f4.Show();
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestPage f3 = new GuestPage();
            f3.Show();
            Random rnd = new Random();
            int c = rnd.Next(1, 100);
            string guset = "guset" + c.ToString();
            Program.nameingame = guset;
            
        }
    }
}
