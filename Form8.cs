using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {

        int x = 21, y = 467, helpx, x1, sumx = 0, dx = 67;
        int c = 0;
        static int  i=1;
        static  PictureBox[] p = new PictureBox[100];
       
     
        bool Y1 = false;
       
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (i > 1)
                p[i - 1].Visible = false;

            if (i == 3)
                timer1.Stop();
            else
            {
                p[i].Visible = true;
                i++;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string a = textBox1.Text;
            int n = a[0] - '0' ;
            sumx = sumx + n;
            /*
            if (sumx < 9 || sumx == 9)
            {
                label1.Text = "we in if";
                //n = n * dx;
                //x = x + n;
                while (n!=0)
                {
                    
                    x = x + dx;
                    pictureBox1.Location = new Point(x, y);
                    n = n - 1;
                    System.Threading.Thread.Sleep(500);



                }


            }
            else if (sumx > 9)
            {
                y = y - 49;
                x1 = 9 - (sumx - n);
                helpx = n - x1;
                dx = dx * -1;
                x = x + (helpx - x1 - 1) * dx;
                sumx = helpx - 1;



            }
            */
            // pictureBox1.Location = new Point(x, y);



             p[1] = pi;
            p[2] = p2;
            p[3] = p3;
            p[4] = p4;
            p[5] = p5;
            p[6] = p6;
            p[7] = p7;
            p[8] = p8;
            p[9] = p9;
            p[10] = p10;
            p[11] = p11;
            p[12] = p10;
            p[11] = p11;
            p[12] = p12;
            p[13] = p13;
            p[14] = p14;
            p[15] = p15;
            p[16] = p16;
            p[17] = p17;
            p[18] = p18;
            p[19] = p19;
            p[20] = p20;
            p[21] = p21;
            p[22] = p22;
            p[23] = p23;
            p[24] = p24;
            p[25] = p25;
            p[26] = p26;
            p[27] = p27;
            p[28] = p28;

            for (int i =1; i <= 28; i++)
            {
                p[i].Visible = false;
            }
            
            
            
                timer1.Start();
                
           



        }
    }
}
