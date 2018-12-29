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
        static int help;
        static int sumx = 1,sumy=1;
        static int time = 0;
        static int c = 0;
        int flag_pc = 0;
        Point[,] matrix = new Point[10, 10];

        public Form10(string str)
        {
            InitializeComponent();
            label2.Text =str;
            if (str == "pc")
                flag_pc = 1;
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
            panel5.Visible = true;
            panel6.Visible = true;
            
            Random rnd = new Random();
            c =rnd.Next(1, 7);
            label5.Text = "the random number is : " + c.ToString();
            pictureBox1.Image = Image.FromFile(@"C: \Users\abd\Desktop\Githere\Test07\img\p" + c.ToString() + ".png");


            if (time % 2 == 0)//we want to update the score of the first player
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;

                sumx = c + sumx;
                help = sumx - c;
                timer1.Start();
                if (flag_pc == 1)
                {
                   
                }
            }
           
            else
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                label3.Text = "we out ";
                sumy = c + sumy;
                help = sumy - c;
                timer2.Start();

            }

            
            time++;
        }
        private int nextstep(int currentscore)
        {
            label6.Text ="from " + currentscore.ToString()+" ";
            switch (currentscore)
            {
                case 2:
                    label6.Text += "up to 38";
                    return 38;
                case 7:
                    label6.Text += "up to 14";
                    return 14;
                case 8:
                    label6.Text += "up to 31";
                    return 31;
                case 15:
                    label6.Text += "up to 26";
                    return 26;
                case 16:
                    label6.Text += "down to 6";
                    return 6;
                case 21:
                    label6.Text += "up to 42";
                    return 42;
                case 28:
                    label6.Text += "up to 84";
                    return 84;
                case 36:
                    label6.Text += "up to 44";
                    return 44;
                case 46:
                    label6.Text += "down to 25";
                    return 25;
                case 49:
                    label6.Text += "down to 11";
                    return 11;
                case 51:
                    label6.Text += "up to 67";
                    return 67;
                case 62:
                    label6.Text += "down to 19";
                    return 19;
                case 64:
                    label6.Text += "down to 60";
                    return 60;
                case 71:
                    label6.Text += "up to 91";
                    return 91;
                case 74:
                    label6.Text += "down to 53";
                    return 53;
                case 78:
                    label6.Text += "up to 98";
                    return 98;
                case 87:
                    label6.Text += "up to 94";
                    return 94;
                case 89:
                    label6.Text += "down to 68";
                    return 68;
                case 92:
                    label6.Text += "down to 88";
                    return 88;
                case 95:
                    label6.Text += "down to 75";
                    return 75;
                case 99:
                    label6.Text += "down to 80";
                    return 80;

                default:
                    label6.Text = "up to "+currentscore.ToString();
                    return currentscore;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel6.Location = matrix[help % 10, help / 10];
            help++;
            c--;
            if (help == sumy)
            {
                help = nextstep(help) - 1;
                if (sumy != (help + 1))
                {
                    c++;

                }

            }
            if (c == 0)
            {
                sumy = nextstep(sumy);
                timer2.Stop();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            button1_Click_1(sender, e);
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              panel5.Location = matrix[help % 10, help / 10];
            help++;
            c--;
            if (help == sumx)
            {
                help = nextstep(help) - 1;
                if (sumx != (help + 1))
                {
                    c++;
                    
                }

            }
            if (c == 0)
            {
                sumx = nextstep(sumx);
                timer1.Stop();

            }


        }
    }
}
