using BusinessObject;
using BusinessObject.Models;
using ZooWinApp;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public User user { get; set; }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Email.Equals("admin@gmail.com"))
            {
                frmMembers f = new frmMembers();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.checkMember = user;
            f.Show();
            }
            else
            {
                productManagementToolStripMenuItem.Enabled = false;
                MessageBox.Show("Your role does not support this function", "Normal user role");
            }
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Email.Equals("admin@gmail.com"))
            {
                frmProducts f = new frmProducts();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                productManagementToolStripMenuItem.Enabled = false;
                MessageBox.Show("Your role does not support this function", "Normal user role");
            }
        }
        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders f = new frmOrders();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.checkMember = user;
            f.Show();
        }
    }
}
