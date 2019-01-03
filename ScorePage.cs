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
    public partial class ScorePage : Form
    {
        public ScorePage()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
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
            string[] Names = new string[10];
            long[] Scores = new long[10];
            while (i < 20)
            {
                if (i %2== 0)
                {
                    Names[j] = NamesAndScores[i];
                    j++;
                }
                else
                {
                    Scores[k] =Convert.ToInt64( NamesAndScores[i]);
                    k++;
                }
                i++;
            }
            
        }

        
    }
}
