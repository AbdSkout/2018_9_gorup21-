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
    public partial class you_are_blocked : Form
    {
        public you_are_blocked()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage f1 = new HomePage();
            this.Hide();
            f1.ShowDialog();
        }

        private void you_are_blocked_Load(object sender, EventArgs e)
        {

        }
    }
}
