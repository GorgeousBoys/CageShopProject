using Repository.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        IUserRepository memberRepository = new UserRepository();
        //UI Design Basic, Create file basic for code, Connect Database, 
        private void btnLogin_Click(object sender, EventArgs e)
        {
          
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                var checkMember = memberRepository.Login(username, password);
                if (checkMember != null)
                {
                    MessageBox.Show("Login successfully");
                    frmMain frmMain = new frmMain();
                    frmMain.user = checkMember;
                    frmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
       
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
