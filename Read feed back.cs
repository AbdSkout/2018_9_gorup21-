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
    public partial class Read_feed_back : Form
    {
        int c = 0;
        string read;
        string feed;
        

        public Read_feed_back()
        {
            InitializeComponent();
        }

       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamReader file = new StreamReader("feedback.txt");
            button1.Visible = true;
            int i = 0;
            feed = "";
            while (i < c)
            {
                read=file.ReadLine();
                if (read == "***")
                    i++;
                if (read =="")
                    break;

            }
            read = file.ReadLine();
            textBox1.Text = read;
            while (read != "***" && read!=null)
            {
                
                read = file.ReadLine();
                if(read!="***")
                 feed = feed + read;

            }
             textBox2.Text =feed;
             
            

            if (textBox1.Text == "")
            {
                textBox2.Text = "No feed back";
                button2.Visible = false;

            }
            else
            {
                c++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader other = new StreamReader("feedback.txt");
            button2.Visible = true;
            int i = 0;
            if (c <= 1)
            {
                textBox2.Text = "No feed back";
                textBox1.Text = "";
                button1.Visible = false;

            }
            else
            {

                feed = "";
                c--;

                while (i < (c - 1))
                {
                    read = other.ReadLine();
                    if (read == "***")
                        i++;
                }
                read = other.ReadLine();
                textBox1.Text = read;


                while (read != "***" && read != null)
                {

                    read = other.ReadLine();
                    if (read != "***")
                        feed = feed + read;

                }
                textBox2.Text = feed;

                

            }
          }
    }
}
