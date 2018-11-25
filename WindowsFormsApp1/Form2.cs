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
    public partial class Form2 : Form
    {
        public Form2()
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
            
            string first = textBox1.Text;
            string name = check(first);
            StreamWriter write = new StreamWriter(@"D:\here\text.txt", true);
            write.WriteLine(name);
            write.WriteLine(textBox2.Text);
            write.WriteLine(comboBox1.Text);
            write.WriteLine(textBox3.Text);
            write.WriteLine(textBox4.Text);
            write.WriteLine("0");
            write.WriteLine("***");
            write.Close();



            // this.Hide();
            //  Form1 f1 = new Form1();
            // f1.ShowDialog();




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

        string check(string name) {

            StreamReader re = new StreamReader(@"D:\here\text.txt");
            string user = re.ReadLine();

            while (user != null && user != name)
            {
               user = re.ReadLine();
            }

            if (user == name)
            {
                label6.Text = "this user is used";
                label6.Visible = true;
                


            }

            label6.Visible = false;

            re.Close();

            return name;
        }
    }
    }
