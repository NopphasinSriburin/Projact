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
    public partial class Insite : Form
    {
        Authen authen = new Authen();
        public Insite()
        {
            InitializeComponent();
        }

        private void Insite_Load(object sender, EventArgs e)
        {

        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AllstdexamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line;
            string filename = "C:\\Users\\nappa\\Desktop\\Poject lab\\Poject lab\\datauser.csv";
            //file = new StreamReader(filename);
            //line = file.ReadLine();
            //string[] data = line.Split(',');

            try
            {
                StreamReader sr = new StreamReader(filename);

                while ((line = sr.ReadLine()) != null)
                {
                    string[] row = line.Split(',');
                    Allstd allstd = new Allstd();
                    allstd.ShowDialog();
                }

            }
            catch (Exception ex) { }

            
        }
    }
}
