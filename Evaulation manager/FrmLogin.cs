namespace Evaulation_manager
{
    public partial class FrmLogin : Form
    {
        string username = "nastavnik";
        string password = "test";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" && txtPassword.Text == "")
            {
                MessageBox.Show("Korisini�ko ime i lozinka nisu uneseni!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisni�ko ime nije uneseno!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if(txtUsername.Text==username && txtPassword.Text==password)
                {
                    MessageBox.Show("Dobrodo�li!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }
    }
}