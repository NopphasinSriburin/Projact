namespace Poject_lab
{
    public partial class Form1 : Form
    {
        Authen authen = new Authen();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Signin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool status = authen.Checkpassword(username, password);

            if (status)
            {
                Insite insite = new Insite();
                insite.ShowDialog();
            }
            else
            {
                Console.WriteLine("Password is wrong");
            }

        }

        private void Resgiter_Click(object sender, EventArgs e)
        {
            Resgiter resgiter = new Resgiter();
            resgiter.ShowDialog();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}