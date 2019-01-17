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
    public partial class Block : Form
    {
       public bool Test;
        public Block()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            label1.Visible = false;
            bool test;
            string r;
            HomePage h = new HomePage();
            test = h.check(textBox1.Text);
            StreamReader read = new StreamReader("blacklist.txt");
            r = read.ReadLine();
            while (r != "" && r != null)
            {
                if (r == textBox1.Text)
                {
                    label1.Text = "this player alredy blocd";
                    test = false;

                    break;
                }
                r = read.ReadLine();
            }
            read.Close();

            if (test)
            {
                StreamWriter write = new StreamWriter("blacklist.txt", true);
                write.WriteLine(textBox1.Text);
                write.Close();
                
                label1.Text = "block done";
                label1.Visible = true;

            }
            else if (test == false && label1.Text == "this player alredy blocd")
            {
                label1.Visible = true;
                

            }
            else
            {
                label1.Visible = true;

                label1.Text = "this player not exit";

            }
           
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Test = false;
            }


        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            AdminPage f = new AdminPage();
            this.Hide();
            f.ShowDialog();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
