using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Top10 : Form
    {
        public Top10()
        {
            InitializeComponent();
        }
        Label[] Label = new Label[20];
        private void Top10_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SlateGray;
            string[] Tokens = File.ReadAllLines("Connect4Score.txt");//reading all the names and their scores from a file

            //now we will split each name and score and put them in an arrays of strings for the names and in array of integers for the score
            string[] Temp;//using split function on tokens and putting every name and his score in this and then putting them in a third array
            int i = 0;
            int j = 0;
            string[] NamesAndScores = new string[20];//putting the score and the name in each index of this array of strings
            while (i < Tokens.Length)
            {
                Temp = Tokens[i].Split();
                NamesAndScores[j] = Temp[0];
                j++;
                NamesAndScores[j] = Temp[1];
                j++;
                i++;
            }
            i = 0;
            j = 0;
            int k = 0;
           
            long[] Scores = new long[10];
            while (i < 20)//a loop top put to take the score and put them in an array
            {
         
                if(i%2==1)
                {
                    Scores[k] = Convert.ToInt64(NamesAndScores[i]);
                    k++;
                }
                i++;
            }
           
            Array.Sort<long>(Scores);//using a built inn fuc to sort them from small to bigger
            string[] str = SortNamesAndScores(NamesAndScores, Scores);//a function to match the right names with the right score after sorting
            //so much indexx because there are a lot of things in the loops that print the labels
            j = 9;
            k = 0;
            int c = 0;
            int x = 0;
            int y = 9;

            for (i = 0; i < Label.Length; i++)//printing the scores
            {
                this.Label[i] = new Label();

                if (i % 2 == 0)
                {
                    x = c + 1;//for location
                    this.Label[i].Visible = true;
                    this.Label[i].Location = new System.Drawing.Point(130, 40 * x);
                    this.Label[i].Size = new System.Drawing.Size(150, 30);
                    this.Label[i].Font = new Font("Arial", 12, FontStyle.Regular);
                    this.Label[i].ForeColor = Color.PeachPuff;
                    this.Label[i].BackColor = Color.Transparent;
                    this.Label[i].Text = str[j];
                    c++;
                    j--;//for index in the string
                }
                else
                {
                    x = k + 1;

                    this.Label[i].Visible = true;
                    this.Label[i].Location = new System.Drawing.Point(410, 40 * x);
                    this.Label[i].Size = new System.Drawing.Size(150, 30);
                    this.Label[i].Font = new Font("Arial", 12, FontStyle.Regular);
                    this.Label[i].ForeColor = Color.PeachPuff;
                    this.Label[i].BackColor = Color.Transparent;
                    this.Label[i].Text = Convert.ToString(Scores[y]);
                    k++;
                    y--;
                }
                this.Controls.Add(Label[i]);

            }
        }
        public string[]  SortNamesAndScores(string[] NamesAndScores,long [] Scores)
        {
            string[] str = new string[10];
            int z = 9;
            for(int i = 9; i >= 0; i--)
            {
                for(int j = 0; j < 20; j++)
                {
                    if(j%2==1 && Convert.ToInt64(NamesAndScores[j]) == Scores[i])
                    {
                        str[z] = NamesAndScores[j-1];
                       
                        z--;
                    }
                }
            }
            return str;
        }
    }
}
