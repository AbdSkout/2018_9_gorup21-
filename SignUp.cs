﻿using System;
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
    public partial class SignUp : Form
    {
       static bool Flag = false;
        public SignUp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) && (textBox1.Text!=""))
            {
                label6.Visible = true;
                label6.Text = "This User Name is already exists";
                Flag = false;
                


            }


            else if(textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox3.Text != "" && comboBox1.Text != "")
            {
                StreamWriter write = new StreamWriter("users.txt", true);
                write.WriteLine(textBox1.Text);
                write.WriteLine(textBox2.Text);
                write.WriteLine(comboBox1.Text);
                write.WriteLine(textBox4.Text);
                write.WriteLine(textBox3.Text);
                write.WriteLine("***");
                write.Close();
                label6.Visible = false;
                Flag = true;
                StreamWriter writesnake = new StreamWriter("snake.txt", true);
                writesnake.WriteLine(textBox1.Text);
                writesnake.WriteLine(0);
                writesnake.WriteLine("***");
                writesnake.Close();
                StreamWriter writeconnect = new StreamWriter("connect4.txt", true);
                writeconnect.WriteLine(textBox1.Text);
                writeconnect.WriteLine(0);
                writeconnect.WriteLine("***");
                writeconnect.Close();


            }


            if (Flag)
            {
                this.Hide();
                HomePage f1 = new HomePage();
                f1.ShowDialog();
            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



       static bool check(string name)
        {
            StreamReader Read = new StreamReader("users.txt");
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage f1 = new HomePage();
            this.Hide();
            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}