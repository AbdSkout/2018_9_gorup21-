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
        string filename1;//for taking the name of a file
       
        public Top10(string filename)
        {
            filename1 = filename;
            InitializeComponent();
        }
        Label[] Label = new Label[20];
        string[] Tokens = null;//reading all the names and their scores from a file

        private void Top10_Load(object sender, EventArgs e)
        {
            this.Text = filename1 + " Top 10";
            this.BackColor = Color.SlateGray;
        
            Tokens = TakingScore(filename1+".txt");//reading all the names and their scores from a file

            int i = 0;
            int j = 0;
            int size = Tokens.Length;
            string[] NamesAndScores = new string[size-1];//putting the score and the name in each index of this array of strings
            while (i < Tokens.Length)//taking out the "***" nd puting them in array
            {
                if (i % 3 == 0)
                {
                    NamesAndScores[j] = Tokens[i];
                    j++;
                }
                else if (i % 3 == 1)
                {
                    NamesAndScores[j] = Tokens[i];
                    j++;
                }

                i++;
            }
            i = 0;
            j = 0;
            int k = 0;
            double NewSize = Convert.ToDouble(size - 1);//if the size is in odd number 
            NewSize = Math.Floor(NewSize / 2);

            long[] Scores = new long[Convert.ToInt32(NewSize)];
            while (i < size-1)//a loop top put to take the score and put them in an array
            {
         
                if(i%2==1 )
                {
                  
                    Scores[k] = Convert.ToInt64(NamesAndScores[i]);
                    k++;
                }
                i++;
            }
           
            Array.Sort<long>(Scores);//using a built inn fuc to sort them from small to bigger
            string[] str = SortNamesAndScores(NamesAndScores, Scores);//a function to match the right names with the right score after sorting
            int count = 0;
            for (i = 0; i < str.Length; i++)//for the time there is null in str and because in the Scores array well have 0 if there is nothing 
            {   
                if(str[i]!=null)
                    count ++;
            }
            PrintingtoScreen(str, Scores, count);
           
        }
        public string[]  SortNamesAndScores(string[] NamesAndScores,long [] Scores)
        {
            int size = (Tokens.Length) - 1;
            double NewSize = Convert.ToDouble(size );//if the size is in odd number 
            NewSize = Math.Floor(NewSize / 2);
            string[] str = new string[Convert.ToInt32(NewSize)];
            int z = Convert.ToInt32(NewSize) - 1;
            for(int i = z; i >= 0; i--)
            {
                for(int j = 0; j < size; j++)
                {
                    if(j%2==1 && Convert.ToInt64(NamesAndScores[j]) == Scores[i] )
                    {
                        if (z < 0)
                        {
                            break;
                        }
                        str[z] = NamesAndScores[j-1];
                       
                        z--;
                    }
                }
            }
            return str;
        }
        public string [] TakingScore(string filename)//editing the score in the connect 4 file
        {
            string name = Program.username;
            string[] allfile;
            allfile = File.ReadAllLines(filename);
            StreamReader Read = new StreamReader(filename);
            string user = Read.ReadLine();
            string result = name;
            int i = 0;
            if (user == name)
            {
                user = Read.ReadLine(); i++;
                Read.Close();
            }


            while ( user != null)
            {
                while ( user != "***")
                {
                    user = Read.ReadLine(); i++;
                }
                user = Read.ReadLine(); i++;

                if (user == name)
                {
                    if (i > allfile.Length-1)
                    {
                        break;
                    }
                    user = Read.ReadLine(); i++;
                    allfile[i] = user.ToString();

                }

            }
            Read.Close();
            return allfile;

        }
        public void PrintingtoScreen(string[] str,long [] Scores,int count)//prints the labels
        {
            int size = (Tokens.Length) - 1;
            double NewSize = Convert.ToDouble(size );//if the size is in odd number 
            NewSize = Math.Floor(NewSize / 2);
            int i=0,j,k;
            //because  the str and the array well be sorted by smaller to bigger we need to take the last 10 numbers which is why j and y are decleard like that
            j = Convert.ToInt32(NewSize)-1;
            k = 0;
            int c = 0;
            int x = 0;
            int y = Convert.ToInt32(NewSize) - 1;

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
                    this.Label[i].ForeColor = Color.BurlyWood;
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
                    this.Label[i].ForeColor = Color.BurlyWood;
                    this.Label[i].BackColor = Color.Transparent;
                    if (count !=0 && y == (size/2-1) - count)
                    {
                        break;
                    }
                    this.Label[i].Text = Convert.ToString(Scores[y]);
                    k++;
                    y--;
                }
                this.Controls.Add(Label[i]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filename1 == "connect4")
            {
                this.Hide();
                Connect4 connect = new Connect4();
                connect.ShowDialog();
            }
            else if (filename1 == "snake")
            {
                this.Hide();
                ChoosingPlayer snake = new ChoosingPlayer();
                snake.ShowDialog();
            }
        }
    }
}
