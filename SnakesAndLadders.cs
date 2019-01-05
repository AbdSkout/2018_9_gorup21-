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
    public partial class SnakesAndLadders : Form
    {
        static int helpx, helpy;
        static int sumx = 1, sumy = 1;
        static int time = 0;
        static int specail1 = 0;
        static int specail2 = 0;
        static int c = 0;
        int sp1 = 4;
        int sp2 = 4;
        static int move = 0;//move show us to go ajead or go back
        int flag_pc = 0;
        Point[,] matrix = new Point[10, 10];
        string name;
        

        public SnakesAndLadders(string player2_name)
        {
            InitializeComponent();
            label2.Text = player2_name;
            if (player2_name == "pc")
                flag_pc = 1;

            name = player2_name;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            sumx = 1;
            sumy = 1;
            label1.Text = Program.nameingame;
            tableLayoutPanel1.Location = new Point(panel1.Location.X, panel1.Location.Y);//in order to be the panel and the tablepanel in the same location
            tableLayoutPanel1.Width = panel1.Width;//in order to be the width of the panel equal to the tablepanle 
            tableLayoutPanel1.Height = panel1.Height;//in order to be the height of the panel equal to the tablepanle 
            int x, y, dx, dy;
            dy = tableLayoutPanel1.Height / 10;//give us the distance for example distance between the [0,0] and [0,1]
            dx = tableLayoutPanel1.Width / 10;//give us the distance for example distance between the [0,0] and [1,0]
            x = tableLayoutPanel1.Location.X;//the x of the start point
            y = tableLayoutPanel1.Location.Y + 9 * tableLayoutPanel1.Height / 10;//the y of the start ppoint
            matrix[0, 0] = new Point(x, y);
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {

                    for (int j = 0; j < 10; j++)
                    {
                        matrix[j, i] = new Point(x + 9 * tableLayoutPanel1.Width / 10 - j * dx, y - i * dy);

                    }
                    matrix[0, i] = new Point(x + 9 * dx, y - i * dy);
                }
                else
                {
                    for (int j = 0; j < 10; j++)
                    {
                        matrix[j, i] = new Point(x + j * dx, y - i * dy);
                    }
                    matrix[0, i] = new Point(0, y - i * dy);

                }
            }
            panel6.Location = panel5.Location = matrix[0, 0];//put the first player in the beginning in the [0,0]
            panel5.Visible = true;
            panel6.Visible = true;

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            panel5.Visible = true;
            panel6.Visible = true;
            button1.Enabled = false;
            move = 1;

            Random rnd = new Random();
            c = rnd.Next(1, 7);//random number
            label5.Text = "the random number is : " + c.ToString();
            pictureBox1.Image = Image.FromFile("p" + c.ToString() + ".png");


            if (time % 2 == 0)//we want to update the score of the first player
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                if (sp1>0)//specail2 <= 2 && time / 2 > 2)
                {
                    
                    button2.Enabled = true;
                    button2.Visible = true;
                    sp1--;
                }
                else
                {
                    button2.Enabled = false;
                    button2.Visible = false;
                }

                helpx = sumx;
                sumx = c + sumx;
                if (sumx > 100)
                    sumx = 200 - sumx;
                timer1.Start();

            }

            else
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;

                if (sp2>0) //specail1 <= 2 && time / 2 > 2)
                {
                    button2.Enabled = true;
                    button2.Visible = true;
                    sp2--;
                }
                else
                {
                    button2.Enabled = false;
                    button2.Visible = false;
                }
                
                

                helpy = sumy;
                sumy = c + sumy;
                if (sumy > 100)
                    sumy = 200 - sumy;
                timer2.Start();

            }
            if (sumx == 100)
            {
                string win = Program.nameingame;
                DialogResult result = MessageBox.Show( win + " win \n Do you want to continue playing?", "snakes and ladders", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    SnakesAndLadders sneak = new SnakesAndLadders(name);
                    sneak.ShowDialog();


                }
                else
                {
                   
                        this.Hide();
                    if (Program.username == null)
                    {
                        GuestPage g = new GuestPage();
                        g.Show();

                    }
                    else
                    {
                        UserPage g = new UserPage();
                        g.Show();

                    }
                }

            }
            if (sumy == 100)
            {
                
                DialogResult result = MessageBox.Show( name+" win \n Do you want to continue playing?", "snakes and ladders", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    SnakesAndLadders sneak = new SnakesAndLadders(name);
                    sneak.ShowDialog();


                }
                else
                {

                    this.Hide();
                    if (Program.username == null)
                    {
                        GuestPage g = new GuestPage();
                        g.Show();

                    }
                    else
                    {
                        UserPage g = new UserPage();
                        g.Show();

                    }

                }


               
            }
            if (flag_pc != 1)
                time++;

            else
            {
                time += 2;
            }
        }
        private int nextstep(int currentscore)
        {
            label6.Text = "from " + currentscore.ToString() + " ";
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
                    label6.Text = "up to " + currentscore.ToString();
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
            if (helpy == 100)
            {
                move = -1;
            }

            if (helpy % 10 != 0)
            {
                panel6.Location = matrix[(helpy) % 10 - 1, helpy / 10];
            }
            else
            {
                panel6.Location = matrix[9, helpy / 10 - 1];
            }

            if (c == 0)
            {
                helpy = nextstep(helpy);
                if (helpy % 10 != 0)
                {
                    panel6.Location = matrix[(helpy) % 10 - 1, helpy / 10];
                }
                else
                {
                    panel6.Location = matrix[9, helpy / 10 - 1];
                }
                sumy = helpy;
                timer2.Stop();
                button1.Enabled = true;
                if (sp1 > 0)
                {
                    button2.Visible = true;
                    button2.Enabled = true;
                }
                    return;
            }
            if (c == -1)
            {

            }
            helpy += move;
            c--;
            //-----------------------------------------------------------------------

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



        }

        private void button2_Click(object sender, EventArgs e)
        {
            specialAbility special = new specialAbility();
            special.ShowDialog();
            move = 1;
            //int c = 0, k = 0;
            c = Convert.ToInt16(special.chose.Text);
            if (time % 2 == 0)//we want to update the score of the first player
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;


                helpx = sumx;
                sumx = c + sumx;
                if (sumx > 100)
                    sumx = 200 - sumx;
                timer1.Start();

            }

            else
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                

                helpy = sumy;
                sumy = c + sumy;
                if (sumy > 100)
                    sumy = 200 - sumy;
                timer2.Start();

            }
            if (sumx == 100)
            {
                DialogResult result = MessageBox.Show( Program.nameingame+" win \n Do you want to continue playing?", "snakes and ladders", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    SnakesAndLadders sneak = new SnakesAndLadders(name);
                    sneak.ShowDialog();


                }
                else
                {

                    this.Hide();
                    if (Program.username == null)
                    {
                        GuestPage g = new GuestPage();
                        g.Show();

                    }
                    else
                    {
                        UserPage g = new UserPage();
                        g.Show();

                    }

                }
            }
            if (sumy == 100)
            {
                DialogResult result = MessageBox.Show( name+" win \n Do you want to continue playing?", "snakes and ladders", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    SnakesAndLadders sneak = new SnakesAndLadders(name);
                    sneak.ShowDialog();


                }
                else
                {

                    this.Hide();
                    if (Program.username == null)
                    {
                        GuestPage g = new GuestPage();
                        g.Show();

                    }
                    else
                    {
                        UserPage g = new UserPage();
                        g.Show();

                    }

                }




            }
            if (flag_pc != 1) 
                time++;
            else
            {
                time += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.username == null)
            {
                this.Hide();
                GuestPage f1 = new GuestPage();
                f1.Show();

            }
            else
            {
                this.Hide();
                UserPage f1 = new UserPage();
                f1.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (helpx == 100)
            {
                move = -1;
            }

            if (helpx % 10 != 0)
            {
                panel5.Location = matrix[(helpx) % 10 - 1, helpx / 10];
            }
            else
            {
                panel5.Location = matrix[9, helpx / 10 - 1];
            }

            if (c == 0)
            {
                helpx = nextstep(helpx);
                if (helpx % 10 != 0)
                {
                    panel5.Location = matrix[(helpx) % 10 - 1, helpx / 10];
                }
                else
                {
                    panel5.Location = matrix[9, helpx / 10 - 1];
                }
                sumx = helpx;
                timer1.Stop();
                if (flag_pc == 1)
                {
                    move = 1;
                    nextpc();
                }
                else
                {
                    button1.Enabled = true;
                }
                return;
            }
            if (c == -1)
            {

            }
            helpx += move;
            c--;

        } 




        public void nextpc()
        {
            panel5.Visible = true;
            panel6.Visible = true;

            button2.Visible = false;
            button2.Enabled = false;

            Random rnd = new Random();
            c = rnd.Next(1, 7);
            label5.Text = "the random number is : " + c.ToString();
            pictureBox1.Image = Image.FromFile("p" + c.ToString() + ".png");
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            
            sumy = c + sumy;
            helpy = sumy - c;
            timer2.Start();
            
        }
    }
}
