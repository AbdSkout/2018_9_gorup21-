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
    public partial class Read_feed_back : Form
    {
        string read;
        StreamReader file = new StreamReader("feedback.txt");

        public Read_feed_back()
        {
            InitializeComponent();
        }

       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            read = file.ReadLine();
            textBox1.Text = read;
            read = file.ReadLine();
            textBox2.Text =read;
            read = file.ReadLine();

            if (textBox1.Text == "")

                textBox2.Text = "No feed back";

               

        }
    }
}
