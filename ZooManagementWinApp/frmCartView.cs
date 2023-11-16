using BusinessObject.Models;
using BusinessObject.Objects;
using DataAccess.DAO;
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
    public partial class frmCartView : Form
    {
        public frmCartView()
        {
            InitializeComponent();
        }
        BindingSource bindingSource;
        public User user;
        ICartRepository cartRepository = new CartRepository();
        IProductRepository productRepository = new ProductRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        IOrderRepository orderRepository = new OrderRepository();
        private void frmCartView_Load(object sender, EventArgs e)
        {
            Dictionary<int, ProductCart> cartDic = cartRepository.GetCart();
            if (cartDic != null)
            {
                LoadCart(cartDic);
            }
            else
            {
                MessageBox.Show("You haven't add any product to cart");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to remove", "Cage Shop", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    var productId = dgvCart.SelectedCells[0].Value.ToString();
                    cartRepository.RemoveFromCart(Int32.Parse(productId));
                    Dictionary<int, ProductCart>? cartDic = cartRepository.GetCart();
                    if (cartDic != null)
                    {
                        MessageBox.Show("Delete successfully");
                        LoadCart(cartDic);
                    }
                    else
                    {
                        dgvCart.DataSource = null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There's some error while removing", "Cage Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCart(Dictionary<int, ProductCart>? cartDic)
        {
            List<KeyValuePair<int, ProductCart>> cartList = cartDic.ToList();
            if (cartDic != null)
            {
                var dataList = cartList.Select(kv => new
                {
                    ID = kv.Key,
                    Price = kv.Value.Price,
                    Quantity = kv.Value.Quantity
                });
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataList;

                dgvCart.DataSource = null;
                dgvCart.DataSource = bindingSource;
            }
            else
            {
                dgvCart.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var productBuy = cartRepository.GetCart().Values.ToList();
            var cartProducts = cartRepository.GetCart();
            if (MessageBox.Show("Are you sure to buy", "Cage Shop", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Order order = new()
                {
                    OrderName = user.UserName,
                    OrderPrice = productBuy.Sum(p => p.Price),
                    OrderStatus = "Pending",
                    UserId = user.UserId,
                    OrderAdress = user.Address,
                    OrderPhone = user.Phone,
                    OrderDate = DateTime.Now
                };
                orderRepository.AddOrder(order);

                int orderId = order.OrderId;

                foreach (var cartProduct in cartProducts)
                {
                    OrderDetail detail = new()
                    {
                        CageId = cartProduct.Key,
                        OrderId = orderId,
                        DetailPrice = cartProduct.Value.Price,
                        DetailQuantity = cartProduct.Value.Quantity
                    };

                    orderDetailRepository.AddOrderDetail(detail);
                }

                MessageBox.Show("Buy successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cartRepository.DeleteCart();
                Dictionary<int, ProductCart> cartDic = cartRepository.GetCart();
                if (cartDic != null)
                {
                    LoadCart(cartDic);
                }
                else
                {
                    dgvCart.DataSource = null;
                }
            }
        }
    }
}