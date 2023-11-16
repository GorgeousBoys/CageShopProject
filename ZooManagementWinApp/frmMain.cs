using AutoMapper;
using BusinessObject.DTO;
using BusinessObject.Mapper;
using BusinessObject.Models;
using Repository.Repository;
using ZooWinApp;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        IProductRepository productRepository = new ProductRepository();
        ICartRepository cartRepository = new CartRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource bindingSource;
        public User user { get; set; }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user != null && user.Email.Equals("admin@gmail.com"))
            {
                frmMembers f = new frmMembers();
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
            if (user.Email.Equals("admin@gmail.com"))
            {
                frmOrders f = new frmOrders();
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            IEnumerable<Product> products = productRepository.GetProducts();
            LoadProducts(products);
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if (user.RoleId == 1)
            {
                frmCartView frmCart = new frmCartView()
                {
                    user = user,
                };
                frmCart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only user allowed");
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.RoleId == 1)
                {
                    int productId = Int32.Parse(dgvCage.SelectedCells[0].Value.ToString());
                    int quantity = 0;
                    decimal price = decimal.Parse(dgvCage.SelectedCells[4].Value.ToString());
                    if (productId != null)
                    {
                        quantity += 1;
                        MessageBox.Show("This product is added to your cart successfully.", "Cage Shop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cartRepository.AddToCart(productId, quantity, price);
                    }
                    else
                    {
                        MessageBox.Show("This product may be no longer available.", "Cage Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Only user allowed");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on the whole cell", "Cage Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.RoleId == 1)
                {
                    var productBuy = productRepository.GetProducts().ToList()[dgvCage.CurrentRow.Index];
                    if (productBuy != null)
                    {
                        if (MessageBox.Show("Would you like to buy it? ", "Buy Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Order order = new()
                            {
                                OrderName = user.UserName,
                                OrderPrice = productBuy.Price,
                                OrderStatus = "Pending",
                                UserId = user.UserId,
                                OrderAdress = user.Address,
                                OrderPhone = user.Phone,
                                OrderDate = DateTime.Now
                            };
                            orderRepository.AddOrder(order);

                            int orderId = order.OrderId;

                            OrderDetail detail = new()
                            {
                                CageId = productBuy.CageId,
                                OrderId = orderId,
                                DetailPrice = order.OrderPrice,
                                DetailQuantity = 1
                            };
                            orderDetailRepository.AddOrderDetail(detail);

                            MessageBox.Show("Buy successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Only user allowed");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string material = cbMaterial.Text;

                IEnumerable<Product> products = productRepository.FilterByMaterial(material);

                LoadProducts(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnViewMyOrders_Click(object sender, EventArgs e)
        {
            if (user.RoleId == 1)
            {
                frmUserOrders frmUserOrders = new()
                {
                    loginUser = user,
                };
                frmUserOrders.Show();
            }
            else
            {
                MessageBox.Show("Only user allowed");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string description = txtSearch.Text;
            IEnumerable<Product> productsSearch = productRepository.SearchByDescriptionKeyword(description);
            if (productsSearch.Count() > 0)
            {
                LoadProducts(productsSearch);
            }
            else
            {
                MessageBox.Show("Not found");
            }

        }

        private void btnFilterBar_Click(object sender, EventArgs e)
        {
            try
            {
                string bar = txtBar.Text;
                if (bar.Length > 0) { txtBar.Text = bar; }
                IEnumerable<Product> products = productRepository.FilterByBar(bar);
                LoadProducts(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal min = decimal.Parse(txtMin.Text);
                decimal max = decimal.Parse(txtMax.Text);
                IEnumerable<Product> products = productRepository.FilterByPrice(min, max);
                LoadProducts(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IEnumerable<Product> products = productRepository.GetProducts();
            LoadProducts(products);
        }

        private void LoadProducts(IEnumerable<Product> products)
        {
            var config = new MapperConfiguration(cfg =>
            {
                MappingProfiles.createMap(cfg);
            });
            var mapProducts = config.CreateMapper();

            var productDtos = products.Select(product => mapProducts.Map<Product, ProductDTO>(product));

            bindingSource = new BindingSource();
            bindingSource.DataSource = productDtos;

            dgvCage.DataSource = null;
            dgvCage.DataSource = bindingSource;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide the current form (frmMain)
            this.Hide();

            // Create an instance of the login form (assuming it's named frmLogin)
            frmLogin loginForm = new frmLogin();

            // Show the login form
            loginForm.Show();
        }

    }
}
