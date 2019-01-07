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
            EditScore();
        }

        public void EditScore()
        {
            string name = "yaser",allfile;
            allfile = File.ReadAllText("snake.txt");
            StreamReader Read = new StreamReader("snake.txt");
            string user = Read.ReadLine();
            string result = name ;
            int score=0;
            if (user == name)
            {
                user = Read.ReadLine();
                score =int.Parse(user);
                result =result +"\r\n"+ score.ToString();
               label1.Text = result;
                //------ return true;
                //return;
            }


            while (user != null)
            {
                while (user != "***")
                {
                    user = Read.ReadLine();
                }
                user = Read.ReadLine();

                if (user == name)
                {
                    user = Read.ReadLine();
                    
                    score = int.Parse(user);
                result =result + "\n" + score.ToString();
                   // label1.Text = user;
                    //-----return true;

                }

            }
            Read.Close();
            allfile.Replace(name, "***");
            string a = (score + 2).ToString();
            File.WriteAllText("snakeq.txt", allfile);
            StreamWriter write = new StreamWriter("snakeq.txt", true);
            write.WriteLine(name);
            write.WriteLine(a);
            write.WriteLine("***");
            write.Close();
            //label1.Text = result;

            label1.Text = allfile;



        }

        private void trytoeditthefile_Load(object sender, EventArgs e)
        {

        }
    }
}
