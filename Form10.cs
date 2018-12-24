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
        int[,] mat = new int[6, 7];//our mat that we are gonna use to determine who won
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
                int matCol = buttonToChangeIndex % 7;//taking the col of the of the button that now changed color
                int matRow = buttonToChangeIndex / 7;//taking the row of the of the button that has changed color

                if (newBackColor == Color.Red)
                {
                    mat[matRow, matCol] = 1;
                }
                else if (newBackColor == Color.Blue)
                {
                    mat[matRow, matCol] = 2;
                }
                // Flip our blue flag
                blue = !blue;
            }
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
