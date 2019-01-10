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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect4 s = new Connect4();
            this.Hide();
            s.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoosingPlayer s = new ChoosingPlayer();
            this.Hide();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowUsers s = new ShowUsers();
            this.Hide();
            s.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResultSheet resultSheet = new ResultSheet();
            this.Hide();
            resultSheet.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Read_feed_back f1 = new Read_feed_back();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.isadmin = false;
            Program.username = null;
            Program.nameingame= null;
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Block b = new Block();
            this.Hide();
            b.Show();
        }
    }
}
