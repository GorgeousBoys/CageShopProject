using BusinessObject.Models;
using Repository.Repository;

namespace SalesWinApp
{
    public partial class frmOrderDetail : Form
    {
        /*IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;*/
        public Order _order { get; set; }
        OrderDetailRepository orderDetailRepository = null;
        public User _memberManager { get; set; }
        BindingSource bindingSource = null;
        public frmOrderDetail()
        {
            orderDetailRepository = new OrderDetailRepository();
            InitializeComponent();
        }
        public int orderID;
        private void btnBack_Click(object sender, EventArgs e) => Close();
        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderDetailList();
            // LoadOrderDetailList(orderID);
        }
        public void LoadOrderDetailList()
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void gbGeneralInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
