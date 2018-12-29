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
        bool Y1 = false;
       
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
           // pictureBox1.Location = new Point(x, y);
        }
    }
}
