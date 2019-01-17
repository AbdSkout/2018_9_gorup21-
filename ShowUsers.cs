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
            StreamReader sr = new StreamReader("users.txt");
            int i = 0;
            string line = ".", l;
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("password");
            line = sr.ReadLine();

            while (line != null)
            {
              
                if (line != "***")
                {
                    l = sr.ReadLine(); i++;
                    table.Rows.Add(line, l);
                }
                while (line != "***")
                {
                    line = sr.ReadLine();
                }
                i++;
                line = sr.ReadLine();
            }
            sr.Close();
            dataGridView1.DataSource = table;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);


        }
        private void ShowUsers_Load(object sender, EventArgs e)
        {
            ReadAndShowData();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage p = new AdminPage();
            this.Hide();
            p.ShowDialog();
        }
    }
}
