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
    public partial class Help_page : Form
    {
        
        string[] s;
        string snaek="",cocnet4="";
        public Help_page()
        {
            InitializeComponent();
            s = File.ReadAllLines("help.txt");
            int i = 0;
            while (s[i] != "***")
            {
                cocnet4 = s[i] + cocnet4;
                i++;
                if (s[i] == null)
                {
                    break;
                }


            }
            i++;
            try
            {
                while (s[i] != null)
                {
                    snaek = s[i] + snaek;
                    i++;


                }

            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = snaek;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Help page";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = cocnet4;



        }
    }
}
