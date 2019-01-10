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

                if (user != null && user == name)
                {
                    user = Read.ReadLine(); i++;
                score =int.Parse(user);
                    allfile[i] = (score + 12).ToString();


                    score = int.Parse(user);
                 

                }

            }
            Read.Close();
            File.WriteAllLines(filename, allfile);




        }

        private void trytoeditthefile_Load(object sender, EventArgs e)
        {
            ReadAndShowData();
        }
        private void ReadAndShowData()
        {
            StreamReader cnct4 = new StreamReader("connect4.txt");
            StreamReader snkl = new StreamReader("snake.txt");
            int i = 0;
            string line = cnct4.ReadLine(), l;
            string line2 = snkl.ReadLine(), l2;
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("score in snakes and ladders");
            table.Columns.Add("score in connect4");
            while (line != null)
            {
                if (line != "***" && line2 != "***")
                {
                    l2 = snkl.ReadLine(); i++;
                    l = cnct4.ReadLine(); i++;
                    table.Rows.Add(line, l,l2);
                }
                line = cnct4.ReadLine();
                i++;
                
                line2 = snkl.ReadLine();
                i++;
            }
            cnct4.Close();
            snkl.Close();
            dataGridView1.DataSource = table;
        }
    }
}
