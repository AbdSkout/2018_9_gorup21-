﻿using System;
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
    public partial class GuestPage : Form
    {
        public GuestPage()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD:GuestPage.cs

        }

=======

        }

>>>>>>> connect4:GuestPage.cs
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connect4 f10 = new Connect4();
            f10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }
    }
}
