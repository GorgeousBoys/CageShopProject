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
            // if Member
            if(_memberManager.RoleId == 1)
            {
                bindingSource = new BindingSource();
                List<OrderDetail> orderDetail = orderDetailRepository.FindByOrderID(_order.OrderId);
                bindingSource.DataSource = orderDetail;

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = bindingSource;
            }
            
            /* var orderDetails = orderDetailRepository.GetOrderDetails(orderId);
             try
             {
                 source = new BindingSource();
                 source.DataSource = orderDetails;

                 dgvOrderDetailList.DataSource = null;
                 dgvOrderDetailList.DataSource = source;

                 dgvOrderDetailList.Columns[0].Width = (int)(dgvOrderDetailList.Width * 0.15);
                 dgvOrderDetailList.Columns[1].Width = (int)(dgvOrderDetailList.Width * 0.15);
                 dgvOrderDetailList.Columns[2].Width = (int)(dgvOrderDetailList.Width * 0.3);
                 dgvOrderDetailList.Columns[3].Width = (int)(dgvOrderDetailList.Width * 0.15);
                 dgvOrderDetailList.Columns[4].Width = (int)(dgvOrderDetailList.Width * 0.15);
                 dgvOrderDetailList.Columns[5].Width = (int)(dgvOrderDetailList.Width * 0);
                 dgvOrderDetailList.Columns[6].Width = (int)(dgvOrderDetailList.Width * 0);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Load orderDetail list");
             }*/
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
