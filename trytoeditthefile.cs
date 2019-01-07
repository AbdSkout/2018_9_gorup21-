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
    public partial class trytoeditthefile : Form
    {
        public trytoeditthefile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditScore("snake.txt");
        }

        public void EditScore(string filename)
        {
            string name = Program.username;
            string[] allfile;
            allfile = File.ReadAllLines(filename);
            StreamReader Read = new StreamReader(filename);
            string user = Read.ReadLine();
            string result = name ;
            int score=0,i=0;
            if (user == name)
            {
                user = Read.ReadLine();i++;
                score =int.Parse(user);
                allfile[i] = (score + 12).ToString();

            }


            while (user != null)
            {
                while (user != "***")
                {
                    user = Read.ReadLine();i++;
                }
                user = Read.ReadLine(); i++;

                if (user == name)
                {
                    user = Read.ReadLine(); i++;
                score =int.Parse(user);
                    allfile[i] = (score + 12).ToString();


                    score = int.Parse(user);
                 

                }

            }
            File.WriteAllLines(filename, allfile);




        }

        private void trytoeditthefile_Load(object sender, EventArgs e)
        {

        }
    }
}
