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
                MessageBox.Show("Korisinièko ime i lozinka nisu uneseni!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisnièko ime nije uneseno!", "Problem", MessageBoxButtons.OK,
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
                    FrmStudents frmStudents = new FrmStudents();
                    Hide();
                    frmStudents.ShowDialog();
                    //ako je show, mogu se koristiti obadvije forme
                    Close();
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