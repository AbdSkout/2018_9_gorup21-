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
    public partial class ShowUsers : Form
    {
        public ShowUsers()
        {
            InitializeComponent();
        }
        private void ReadAndShowData()
        {
            StreamReader sr = new StreamReader("connect4.txt");
            int i = 0;
            bool flag = false;
            string line = sr.ReadLine(), l;
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("score");
        a:
            while (line != null)
            {
                if (line != "***")
                {
                    l = sr.ReadLine(); i++;
                    table.Rows.Add(line, l);
                }
                line = sr.ReadLine();
                i++;
            }
            sr.Close();
            dataGridView1.DataSource = table;
        }
    }
}
