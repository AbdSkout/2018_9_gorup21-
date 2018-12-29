using System;
using System.Diagnostics;
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
        Button[] gameButtons = new Button[42]; //array of buttons for markers(red and blue)

        bool blue = false; //blue is set to false if the next marker is red
        int[,] mat = new int[6, 7];//our mat that we are gonna use to determine who won
        //Making a tick for the score
        private int ticks,mins=0,secs=0;
        
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Text = "Connect 4";
            this.BackColor = Color.SlateGray;
            timer1.Start();
            for (int i = 0; i < gameButtons.Length; i++)
            {
                int index = i;
                this.gameButtons[i] = new Button();
                int x = 10 + (i % 7) * 50;
                int y = 10 + (i / 7) * 50;

                this.gameButtons[i].Location = new System.Drawing.Point(x, y);
                this.gameButtons[i].Name = "btn" + (index + 1);
                this.gameButtons[i].Size = new System.Drawing.Size(50, 50);
                this.gameButtons[i].TabIndex = i;
                this.gameButtons[i].UseVisualStyleBackColor = true;//true shows the button ,false shows the frame
                this.gameButtons[i].Visible = true;//shows the button


                gameButtons[i].Click += (sender1, ex) => this.ButtonHasBeenPressed(sender1, index); //sending the the clicked button with index from 0-42
                this.Controls.Add(gameButtons[i]);
            }
        }
        private void ButtonHasBeenPressed(object sender, int index)
        {
            // Get the button that the user pressed
            var pressedButton = (Button)sender;

            // Only do something if they clicked a "neutral" button
            if (pressedButton.BackColor == Color.SlateGray)
            {
                // The backcolor will be set based on whether or not blue is true or false
                var newBackColor = blue ? Color.Blue : Color.Red;

                // Get the index of the button that the user clicked
                var buttonToChangeIndex = index;

                // From where the user clicked, look down at each button below (index + 7)
                // until we find the last button that has a BlanchedAlmond backcolor
                while (buttonToChangeIndex + 7 < gameButtons.Count() &&
                       gameButtons[buttonToChangeIndex + 7].BackColor == Color.SlateGray)
                {
                    buttonToChangeIndex += 7; // Set to the index to point to this button
                }

                // Now we set that button's backcolor
                gameButtons[buttonToChangeIndex].BackColor = newBackColor;
                int matCol = buttonToChangeIndex % 7;//taking the col of the of the button that now changed color
                int matRow = buttonToChangeIndex / 7;//taking the row of the of the button that has changed color

                if (newBackColor == Color.Red)
                {
                    mat[matRow, matCol] = 1;//1 is for the red color
                }
                else if (newBackColor == Color.Blue)
                {
                    mat[matRow, matCol] = 2;//2 is for the blue color
                }

                int Player = 0;//we will check the value of our player by the returened value from our check functions
                
                Player = DiagonalCheck(mat, matRow, matCol);//first we check diagonal
                if (Player == 0)//if didn't work we will check vertical
                {
                    Player = VerticalCheck(mat, matRow, matCol);
                }
                if(Player == 0)//if both didn't change the player value then we will check horizontally else then we don't have four of the same color constantly 
                {
                    Player = horizontalCheck(mat, matRow, matCol);//horizontal check function here
                }




                if (Player == 1)//if we have red color then it prints it in label6 and changes the size and color to red and added a popup question box to know if the player wants to continue or not
                {
                    timer1.Stop();

                    if (ticks < 10)
                    {
                        label4.Text = (ticks * 1000).ToString();//score is bigger under one minute
                    }
                    else if (ticks < 60)
                    {
                        label4.Text = (ticks * 100).ToString();//score is bigger under one minute

                    }
                    else if (ticks < 120)
                    {
                        label4.Text = (ticks * 10).ToString();//score out it decress

                    }
                    else
                    {
                        label4.Text = ticks.ToString();//score out the same one

                    }
                    pictureBox2.Visible = false;//not showing the img of red cicrlce
                    pictureBox1.Visible = true;//showing image of winner

                    DialogResult result = MessageBox.Show("Do you want to continue playing?", "Connect 4", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        Form10 f10 = new Form10();
                        f10.ShowDialog();


                    }
                    else if (result == DialogResult.No)
                    {
                        this.Hide();
                        Form3 f3 = new Form3();
                        f3.ShowDialog();

                    }
                }
                if (Player == 2)//if we have blue color then it prints it in label6 and changes the size and color to blue
                {
                    timer1.Stop();

                    if (ticks < 10)//scores
                    {
                        label5.Text = (ticks * 1000).ToString();//score is bigger under one minute
                    }
                    else if (ticks < 60)
                    {
                        label5.Text = (ticks * 100).ToString();//score is bigger under one minute

                    }
                    else if (ticks < 120)
                    {
                        label5.Text = (ticks * 10).ToString();//score out it decress

                    }
                    else
                    {
                        label5.Text = ticks.ToString();//score out the same one

                    }
                    pictureBox3.Visible = false;//not showing the img of blue cicrlce
                    pictureBox4.Visible = true;//showing image of winner

                    DialogResult result = MessageBox.Show("Do you want to continue playing?", "Connect 4", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        Form10 f10 = new Form10();
                        f10.ShowDialog();


                    }
                    else if (result == DialogResult.No)
                    {
                        this.Hide();
                        Form3 f3 = new Form3();
                        f3.ShowDialog();

                    }
                }

                // Flip our blue flag
                blue = !blue;
            }
        }
        public int horizontalCheck(int[,] mat,int Row,int Col)
        {
            int count = 0;
            int flag = 0;//if the flag had changed it sims like we have another color that cut thesequence.
            int check=Col;
            int player = 2;//it is set to the blue color else it will be set to red if the last player is red
            if (blue == false)
            {
                player = 1;
            }

            if (mat[Row, Col] == player)//checking if the color was send red and cheking in this func a horizontal check if we have four 1's
            {
                if (check != 6)//if the player choice was one of the last right squares we cant count squares from there.
                {
                    if (mat[Row, (check + 1)] == player)
                    {
                        for (int i = Col; i < 7 && flag==0; i++)
                        {
                            if (mat[Row, i] == player)
                            {
                                count++;
                            }
                            else
                                flag++;

                            if (count == 4)
                            {
                                return player;
                            }
                        }
                    }
                }
                flag = 1;
                count = 0;
                if (check != 0)//if the player choice was one of the last left squares we cant count squares from there.
                {
                    if (mat[Row, (check - 1)] == player)
                    {
                        for (int i = Col; i >= 0 && flag==1; i--)
                        {
                            if (mat[Row, i] == player)
                            {
                                count++;
                            }
                            else
                                flag++;

                            if (count == 4)
                            {
                                return player;
                            }
                        }
                        count = 0;
                    }
                }
            }
            return 0;
        }
        public int VerticalCheck(int[,] mat, int Row, int Col)
        {
            int player = 2;//it is set to the blue color else it will be set to red if the last player is red
            if (blue == false)
            {
                player = 1;
            }
            int count = 0;

            if (mat[Row, Col] == player)//checking if the color was send red and cheking in this func a vertical check if we have four 1's
            {

                for (int i = Row; i < 6; i++)//we get the row and the col of the last element that has been entered and then we check  each row of the same col and the same with the blue
                {
                    if (mat[i, Col] == player) {
                        count++;
                        if (count == 4)//if we reach four reds in a col which are constive then return 2 which is the color red for us 
                        {
                            return player;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            return 0;
        }
        public int DiagonalCheck(int[,] mat, int Row, int Col)// a function that checks the diagonal of four colors
        {
            int player = 2;//it is set to the blue color else it will be set to red if the last player is red
            if (blue == false)
            {
                player = 1;
            }
            bool FourInDiag;
            int i = Math.Abs(Row - Col);
            int j=0;
            FourInDiag = Checkfour(mat, i, j);//we send the the row of the first index in the dignaol line the index is in it
            //and we have three options either the rows are bigger or they are equal or the oppiste 
            //and the three cases are covered and are send to the check four function which cheks if we have a four of the same color in the diagonal line

            if (FourInDiag == true)
            {
                return player;
            }
            if (Row + Col < 7)
            {
                j = Row + Col;
                i = 0;
                FourInDiag = Checkfour(mat, i, j);
                if (FourInDiag == true)
                {
                    return player;
                }
            }else if(Row+Col>6)
            {
                j = 6;
                i = Col - (7 - Row - 1);
                FourInDiag = Checkfour(mat, i, j);
                if (FourInDiag == true)
                {
                    return player;
                }
            }
            
                 


            return 0;
        }
        public bool Checkfour(int [,]mat,int Row,int Col)//checks four in dignoal in the four ways
        {
        int count = 0;
        int player = 2;//the player is set to the blue color else it will be set to red if the last player is red
        if (blue == false)
        {
            player = 1;
        }

        int i = Row, j = Col;

                while (i < 6 && j  <7 && i >= 0 && j >= 0)
                {
                    if (mat[i, j] == player)//four down right
                    {
                        count++;

                    }
                    else
                    { count = 0; }
                    j++;
                    i++;
                }
                if (count == 4)
                    return true;
                else
                {
                    count = 0;
                    i = Row;
                    j = Col;
                }
                while (i < 6 && j < 7 && i >= 0 && j >= 0)
                    {
                        if (mat[i, j] == player)//four up left
                        {

                            count++;

                        }
                        else
                        { count = 0; }
                        j--;
                        i--;
                }

                if (count == 4)
                    return true;
                else
                {
                    count = 0;
                    i = Row;
                    j = Col;
                }
                while (i < 6 && j < 7 && i >= 0 && j >= 0)
                {
                    if (mat[i, j] == player)//four down left
                    {

                        count++;

                    }
                    else
                    { count = 0; }
                    j--;
                    i++;
                }

                if (count == 4)
                    return true;
                else
                {
                    count = 0;
                    i = Row;
                    j = Col;
                }
                while (i < 6 && j < 7 && i >= 0 && j >= 0)
                {
                    if (mat[i, j] == player)//four up right
                    {

                        count++;

                    }
                    else
                    { count = 0; }
                    j++;
                    i--;
                }

                if (count == 4)
                    return true;
                else
                {
                    count = 0;
                    i = Row;
                    j = Col;
                }




            
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks < 10)
            {
                label7.Text = "0" + mins.ToString() + ":" +"0" + ticks.ToString();
            }
            else if (ticks>=10 && ticks <60)
            {
                secs = ticks;
                label7.Text = "0" + mins.ToString()+ ":" + secs.ToString();
            }
            else if (ticks>=60)
            {
                secs = ticks % 60;
                mins = ticks / 60;
                mins = mins % 60;
                if (mins < 10)
                {
                    if (secs < 10)
                    {
                        label7.Text = "0" + mins.ToString() + ":" + "0" + secs.ToString();
                    }
                    else if (secs >= 10 && secs < 60)
                    {
                        
                        label7.Text = "0" + mins.ToString() + ":" + secs.ToString();
                    }
                }
                else
                {
                    if (secs < 10)
                    {
                        label7.Text = mins.ToString() + ":" + "0" + secs.ToString();
                    }
                    else if (secs >= 10 && secs < 60)
                    {
                        
                        label7.Text =  mins.ToString() + ":" + secs.ToString();
                    }
                }

            }

        }
    }
}
