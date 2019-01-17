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
    public partial class specialAbility : Form
    {
        public specialAbility()
        {
            InitializeComponent();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            specialAbility special = new specialAbility();
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string trackBar = Convert.ToString(trackBar1.Value);
            chose.Text = trackBar;
        }

        private void specialAbility_Load(object sender, EventArgs e)
        {

        }
    }
}
