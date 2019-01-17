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
        int name, start = 0, end=-1, i = 0, contuo=1;
        int f = 0;
        string[] s;
        
            
        public Read_feed_back()
        {
            InitializeComponent();
            s = File.ReadAllLines("feedback.txt");
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            contuo = 1;
             i = 0;
            

            name = end+1;
            start = name + 1;
            try
            {
                textBox1.Text = s[name];
            }
            catch
            {
                textBox1.Text = "no feed back";
                textBox2.Text = "no feed back";
                f = 1;
                
            }

            
            if(f==0)
            { 
             while (s[start + i] != "***")
             {
                i++;
             }
             end = start + i;
             label1.Text = s[end];
             label2.Text = s[start];
             for (int x=start ; x <=(end-1); x++)
             {
                feed = s[x] + feed;
             }
             textBox2.Text = feed;
             feed = "";
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
            f = 0;i = 0;
            i =name-2;

            try
            {
                while (s[i] != "***")
                {

                    if (i > 0)
                        i--;
                    else
                        break;

                }
            }
            catch
            {
                textBox1.Text = "no feed back";
                textBox2.Text = "no feed back";
                contuo = 0;
                end = -1;
            }
            if(contuo==1)
            { 
            if (i == 0)
            {
                name = 0;
                start = 1;
            }
            else
            {
                name = i + 1;
                start = name + 1;
            }
             
            i = 0;
            while (s[start + i] != "***")
            {
                i++;
            }
            end = start + i;
            for (int x = start; x <= (end - 1); x++)
            {
                feed = s[x] + feed;
            }
            textBox1.Text = s[name];
            textBox2.Text = feed;
            feed = "";
            }
           



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage f = new AdminPage();
            f.ShowDialog();
        }

        private void Read_feed_back_Load(object sender, EventArgs e)
        {

        }
    }
}