using BusinessObject.Models;
using Repository.Repository;
using SalesWinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooWinApp
{
    public partial class frmUserOrders : Form
    {
        public frmUserOrders()
        {
            InitializeComponent();
        }
        public User loginUser { get; set; }
        BindingSource bindingSource;
        public IOrderRepository orderRepository = new OrderRepository();
        private void frmUserOrders_Load(object sender, EventArgs e)
        {
            var orders = orderRepository.GetOrders().Where(x => x.UserId == loginUser.UserId);
            bindingSource = new BindingSource();
            bindingSource.DataSource = orders;

            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orders = orderRepository.GetAllOrders().ToList()[dataGridView1.CurrentRow.Index];
            if (orders.OrderStatus == "Cart")
            {
                MessageBox.Show("This order does not have order detail because still in cart");
                return;
            }
            frmOrderDetail frmOrderDetail = new frmOrderDetail()
            {
                _order = orders,
                _memberManager = loginUser
            };
            frmOrderDetail.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var orders = orderRepository.GetOrders().Where(x => x.UserId == loginUser.UserId).ToList()[dataGridView1.CurrentRow.Index];
            if (orders.OrderStatus == "Cart")
            {
                MessageBox.Show("This order does not have order detail because still in cart");
                return;
            }
            frmOrderDetail frmOrderDetail = new frmOrderDetail()
            {
                _order = orders,
                _memberManager = loginUser
            };
            frmOrderDetail.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
