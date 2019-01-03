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
        public Read_feed_back()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("feedback.txt");

            read = file.ReadLine();
            listBox1.Items.Add("Name :" + read);

            while (read != "")
            {
                read = file.ReadLine();
                listBox1.Items.Add("feed is :" + read);
                read = file.ReadLine();
                listBox1.Items.Add("Name:" + read);
            }

        }
    }
}
