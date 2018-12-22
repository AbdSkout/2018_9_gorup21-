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
        Button[] gameButtons = new Button[42]; //array of buttons for markers(red and blue)
        bool blue = true; //blue is set to true if the next marker is to be a blue

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Text = "Connect 4";
            this.BackColor = Color.BlueViolet;
          
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
                this.gameButtons[i].Text = Convert.ToString(index);//showing index of a box
                this.gameButtons[i].UseVisualStyleBackColor = false;//true shows the button ,false shows the frame
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
            if (pressedButton.BackColor == Color.BlueViolet)
            {
                // The backcolor will be set based on whether or not blue is true or false
                var newBackColor = blue ? Color.Red : Color.Blue;

                // Get the index of the button that the user clicked
                var buttonToChangeIndex = index;

                // From where the user clicked, look down at each button below (index + 7)
                // until we find the last button that has a BlanchedAlmond backcolor
                while (buttonToChangeIndex + 7 < gameButtons.Count() &&
                       gameButtons[buttonToChangeIndex + 7].BackColor == Color.BlueViolet)
                {
                    buttonToChangeIndex += 7; // Set to the index to point to this button
                }

                // Now we set that button's backcolor
                gameButtons[buttonToChangeIndex].BackColor = newBackColor;
                int temp = VerticalCheck(sender, buttonToChangeIndex, newBackColor);
                if (temp == 1)
                {
                    label6.Visible = true;
                    label6.ForeColor = Color.Red;
                    label6.Size= new System.Drawing.Size(100, 100);
                    label6.Font = new Font("Arial", 15, FontStyle.Regular);
                    label6.Text = "Red Wins!!";
                }
                if (temp == 2)
                {
                    label6.Visible = true;
                    label6.ForeColor = Color.Blue;
                    label6.Size = new System.Drawing.Size(100, 100);
                    label6.Font = new Font("Arial", 15, FontStyle.Regular);
                    label6.Text = "Blue Wins!!";
                }

                // Flip our blue flag
                blue = !blue;
            }
        }
        public int VerticalCheck(object sender,int index,Color color)//checking vertical 4 in row of the same color
        {
            var pressedButton = (Button)sender;
            
            
            int count = 0;//counter if we reach 4 of the same color
            if (color == Color.Red)
            {
                for(int i = index; i < 42; i += 7)
                {
                    if ( i<42 && this.gameButtons[i].BackColor!=Color.Blue)//checking for the red color and cheking  all the col of last index to check if there is a 4 in a col
                    {
                        count++;
                        if (count == 4)
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
               
            }
            if (color == Color.Blue)
            {
                for (int i = index; i < 42; i += 7)
                {
                    if (i < 42 && this.gameButtons[i].BackColor != Color.Red)//checking for the blue color and cheking  all the col of last index to check if there is a 4 in a col 
                    {
                        count++;
                        if (count == 4)
                        {
                            return 2;
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
