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

        int x = 21, y = 467, sumx = 0,dx=67;
        bool Y1 = false;
       
        public Form8()
        {
            InitializeComponent();
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
            if (sumx < 10 || sumx == 10)
            {
                n = n * dx;
                x = x + n;
            }
            else if (sumx > 10)
            {
                y = y - 49;
                n = n - (sumx - 10);

                x = x + ((sumx - 10)*dx);
               // dx = -1 * dx;
              //  n = n *dx;
               // x = x + n;
              //  sumx = 0;
            }
            pictureBox1.Location = new Point(x, y);
        }
    }
}
