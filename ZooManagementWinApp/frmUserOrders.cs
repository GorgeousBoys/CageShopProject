using BusinessObject.Models;
using Repository.Repository;
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
    }
}
