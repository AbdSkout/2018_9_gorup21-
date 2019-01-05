using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect4 f = new Connect4();
            this.Hide();

            f.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoosingPlayer f = new ChoosingPlayer();
            this.Hide();

            f.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            feedback feed = new feedback();
            feed.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }
    }
}
