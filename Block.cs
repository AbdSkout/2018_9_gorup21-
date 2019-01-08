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
        public Block()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool test;
            
            HomePage h = new HomePage();
            test = h.check(textBox1.Text);

            if (test)
            {
                StreamWriter write = new StreamWriter("blacklist.txt", true);
                write.WriteLine(textBox1.Text);
                write.Close();
                label1.Text = "here";
                
            }
            else
            {
                label1.Text = "this player not exist";

            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage f = new AdminPage();
            this.Hide();
            f.ShowDialog();
        }
    }
}
