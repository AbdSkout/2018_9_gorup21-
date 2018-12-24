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
{//dfsdfsd
    public partial class Form9 : Form
    {
        int player1_score = 0;
        int player2_score = 0;
        int time = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            Random rnd = new Random();
            c = rnd.Next(1, 7);
            label5.Text = "the random number is : " + c.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\user\Documents\GitHub\Test07\img\p" + c.ToString() + ".png");


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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
        }
    }
}
