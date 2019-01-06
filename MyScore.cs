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
    public partial class MyScore : Form
    {
        public MyScore()
        {
            InitializeComponent();
        }

        private void MyScore_Load(object sender, EventArgs e)
        {
            label1.Text = check("snake");
            label5.Text = check("connect4");
        }

        static string check(string name)
        {
            StreamReader Read = new StreamReader(name+".txt");
            string user = Read.ReadLine();

            if (user == Program.username)
            {
                user = Read.ReadLine();
                Read.Close();
                return user;
            }

            while (user != null)
            {
                while (user != "***")
                {
                    user = Read.ReadLine();
                }
                user = Read.ReadLine();

                if (user == Program.username)
                {
                    user = Read.ReadLine();
                    Read.Close();
                    return user;

                }

            }
            Read.Close();
            return null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPage f = new UserPage();
            f.ShowDialog();
        }
    }
}
