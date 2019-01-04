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
            int i = 0;
            while (i < (c * 3))
            {
                file.ReadLine();
                i++;

            }
            read = file.ReadLine();
            textBox1.Text = read;
            read = file.ReadLine();
            textBox2.Text =read;
            read = file.ReadLine();

            if (textBox1.Text == "")
            {
                textBox2.Text = "No feed back";

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
            int i = 0;
            if(c>0)
              c--;

            while (i < (3 * (c-1)))
            {
                read = other.ReadLine();
                i++;
            }

            if (c < 0)
                c = 0;
            read = other.ReadLine();
            textBox1.Text = read;
            read = other.ReadLine();
            textBox2.Text = read;
            read = other.ReadLine();

            
            

        }
    }
}
