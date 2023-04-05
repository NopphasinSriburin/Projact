using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poject_lab
{
    public partial class Allstd : Form
    {
        Insite Insite = new Insite();
        public Allstd()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string line;
            string filename = "C:\\Users\\nappa\\Desktop\\Poject lab\\Poject lab\\datauser.csv";

            try
            {
                StreamReader sr = new StreamReader(filename);

                while ((line = sr.ReadLine()) != null)
                {
                    string[] row = line.Split(',');
                    dataGridView1.Rows.Add(row[2], row[4], row[5]);
                }

            }
            catch (Exception ex) { }
        }
    }
}
