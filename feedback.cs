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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("feedback.txt", true);
            write.WriteLine(richTextBox1.Text);
            write.Close();
            this.Hide();
            


        }
    }
}
