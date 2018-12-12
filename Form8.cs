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
        int player1_score = 0;
        int player2_score = 0;
        int time = 0;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            int c = 0;
            Random rnd = new Random();
            c = rnd.Next(1, 7);
            label5.Text = "the random number is : " + c.ToString();
            pictureBox2.Image = Image.FromFile(@"C: \Users\abd\Desktop\Githere\Test7\img\p" + c.ToString() + ".png");


            if (time % 2 == 0)//we want to update the score of the first player
            {
                player1_score += c;
                //UPDATE THE NEW WHERE
                label3.Text = player1_score.ToString();
            }
            else //we want to update the score of the srcond player
            {

                player2_score += c;
                //UPDATE THE NEW WHERE
                label4.Text = player2_score.ToString();

            }
            time++;
            
            int n = c;
            sumx = sumx + n;
            if (sumx < 9 || sumx == 9)
            {
                n = n * dx;
                x = x + n;
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
            pictureBox1.Location = new Point(x, y);





        }

    }
            
        }
    