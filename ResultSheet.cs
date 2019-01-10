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
    public partial class ResultSheet : Form
    {
        public ResultSheet()
        {
            InitializeComponent();
        }

        private void ResultSheet_Load(object sender, EventArgs e)
        {
            ReadAndShowData();
        }
        private void ReadAndShowData()
        {
            StreamReader cnct4 = new StreamReader("connect4.txt");
            StreamReader snkl = new StreamReader("snake.txt");
            int i = 0;
            string line = cnct4.ReadLine(), l;
            string line2 = snkl.ReadLine(), l2;
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("score in snakes and ladders");
            table.Columns.Add("score in connect4");
            while (line != null)
            {
                if (line != "***" && line2 != "***")
                {
                    l2 = snkl.ReadLine(); i++;
                    l = cnct4.ReadLine(); i++;
                    table.Rows.Add(line, l, l2);
                }
                line = cnct4.ReadLine();
                i++;

                line2 = snkl.ReadLine();
                i++;
            }
            cnct4.Close();
            snkl.Close();
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage page = new AdminPage();
            this.Hide();
            page.ShowDialog();
        }
    }
}
