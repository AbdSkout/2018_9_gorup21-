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


            /*
          StreamReader file = new StreamReader("feedback.txt");
          button1.Visible = true;
          int i = 0;
          feed ="";
          while (i < c)
          {
              read =file.ReadLine();
              if (read == "***")
                  i++;


          }
          read = file.ReadLine();
          textBox1.Text = read;
          while (read != "***" && read!="" &&read!=null)
          {
              read = file.ReadLine();
              if (read != "***")
                  feed = feed + read;

          }
          textBox2.Text = feed;



          if (textBox1.Text=="")
          {
              textBox2.Text = "No feed back";
              button2.Visible = false;

          }
          else
          {
              c++;
          }
         */
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
            /*
             StreamReader other = new StreamReader("feedback.txt");
             button2.Visible = true;
             int i = 0;
             if (c <1)
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


                 while (read!= "***" && read!="")
                 {

                     read = other.ReadLine();
                     if (read != "***")
                         feed = feed + read;

                 }
                 textBox2.Text = feed;



             }
             other.Close();
             */



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