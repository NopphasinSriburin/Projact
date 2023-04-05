using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poject_lab
{
    public partial class Resgiter : Form
    {
        Authen authen = new Authen();
        public Resgiter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = iusername.Text;
            string Password = ipassword.Text;
            string IDst = iID.Text;
            string date = idate.Text;
            string Age = iage.Text;
            string Branch = iBranch.Text;

            bool status = authen.singup(Username, Password, IDst, date, Age, Branch);

            if (status)
            {
                MessageBox.Show("Sucess");
                this.Close();
            }
            else
            {
                MessageBox.Show("Can't Sign");
            }
        }

        private void idate_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
