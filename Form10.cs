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
    public partial class Form10 : Form
    {
        int player1_score = 1;
        int player2_score = 1;
        int time = 0;
            Point[,] matrix = new Point[10, 10];

        public Form10()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Location = new Point(panel1.Location.X,panel1.Location.Y);//in order to be the panel and the tablepanel in the same location
            tableLayoutPanel1.Width = panel1.Width;//in order to be the width of the panel equal to the tablepanle 
            tableLayoutPanel1.Height= panel1.Height;//in order to be the height of the panel equal to the tablepanle 

            int x, y,dx,dy;
            dy=tableLayoutPanel1.Height / 10;//give us the distance for example distance between the [0,0] and [0,1]
            dx = tableLayoutPanel1.Width / 10;//give us the distance for example distance between the [0,0] and [1,0]
            x = tableLayoutPanel1.Location.X;//the x of the start point
            y = tableLayoutPanel1.Location.Y + 9 * tableLayoutPanel1.Height / 10;//the y of the start ppoint
                    matrix[0, 0] = new Point(x , y );
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {

                    for (int j = 0; j < 10; j++)
                    {
                        matrix[j, i] = new Point(x+9*tableLayoutPanel1.Width/10 - j * dx, y - i * dy);

                    }
                    matrix[0, i] = new Point(x+9 * dx, y - i * dy);
                }
                else
                {
                    for (int j = 0; j < 10; j++)
                    {
                        matrix[j, i] = new Point(x + j * dx, y - i * dy);
                    }
                    matrix[0, i] = new Point(0, y - i* dy);

                }
            }

            panel5.Location = matrix[0, 0];//put the first player in the beginning in the [0,0]

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            int c = 0;
            Random rnd = new Random();
            c = rnd.Next(1, 7);
            label5.Text = "the random number is : " + c.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\user\Documents\GitHub\2018_9_gorup21-\img\p" + c.ToString() + ".png");


            if (time % 2 == 0)//we want to update the score of the first player
            {
                player1_score += c;
                //UPDATE THE NEW WHERE
                //player1_score = nextstep(player1_score);
                label3.Text = player1_score.ToString();
                textBox1.Text = label6.Text + System.Environment.NewLine + textBox1.Text;

                if (player1_score < 100)
                    if (player1_score % 10 != 0)
                    {
                        if ((player1_score / 10) % 2 == 1)
                        {
                        panel5.Location = matrix[(player1_score) % 10-1, player1_score / 10];
                        }
                        else
                        {
                            panel5.Location = matrix[(player1_score) % 10-1, player1_score / 10];

                        }
                    }
                    else
                    {
                        if ((player1_score / 10) % 2 == 1)
                        {
                            panel5.Location = matrix[9, player1_score / 10-1];

                        }
                        else if ((player1_score / 10) % 2 == 0)
                        { 
                            panel5.Location = matrix[9, (player1_score / 10)-1];
                        }

                        
                    }

            }
            else //we want to update the score of the srcond player
            {

                player2_score += c;
                //UPDATE THE NEW WHERE
                label4.Text = player2_score.ToString();

            }
            time++;
        }
       

    }
}