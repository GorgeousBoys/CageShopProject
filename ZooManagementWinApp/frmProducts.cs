using BusinessObject;
using BusinessObject.Models;
using Repository.Repository;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;

        public frmProducts()
        {
            InitializeComponent();
            List<String> options = new List<String>()
            {
                "Price", "Quantity"
            };

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // String name = txtSearch.Text;
            // dgvProductList.DataSource = productRepository.(x=> x.ProductName.Contains(name)).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = GetProductObject();
            try
            {
                if (product != null)
                {
                    productRepository.AddProduct(product);
                    LoadProductList();
                    MessageBox.Show("Add new product successfully");
                }
                else
                {
                    throw new Exception("Add new product fail. Fill in the blank information box!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var product = GetProductObject();
            try
            {
                if (product != null)
                {
                    product.CageId = int.Parse(mtxtCageID.Text);
                    productRepository.UpdateProduct(product);
                    LoadProductList();
                    MessageBox.Show("Update product successfully");
                }
                else
                {
                    throw new Exception("Update product fail. Select a product beside to update!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var productID = int.Parse(mtxtCageID.Text);

                productRepository.DeleteProduct(productRepository.FindByID(productID));
                LoadProductList();
                mtxtCageID.Clear();
                MessageBox.Show("Delete product successfully");
            }
            catch (Exception ex)
            {
                throw new Exception("Delete product fail. Select a product beside to delete!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProductList.Rows.Count - 1)
            {
                mtxtCageID.Text = dgvProductList.Rows[e.RowIndex].Cells["CageID"].Value.ToString();
                mtxtCategoryID.Text = dgvProductList.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
                txtCageName.Text = dgvProductList.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtQuantity.Text = dgvProductList.Rows[e.RowIndex].Cells["Weight"].Value.ToString();
                mtxtPrice.Text = dgvProductList.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                mtxtDIscountID.Text = dgvProductList.Rows[e.RowIndex].Cells["UnitInStock"].Value.ToString();
            }
        }

        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    CategoryId = int.Parse(mtxtCategoryID.Text),
                    CageName = txtCageName.Text,
                    Material = txtQuantity.Text,
                    Price = decimal.Parse(mtxtPrice.Text),
                    CageStatus = int.Parse(mtxtDIscountID.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }

        private void LoadProductList()
        {
            var products = productRepository.GetProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;

                dgvProductList.Columns[0].Width = (int)(dgvProductList.Width * 0.1);
                dgvProductList.Columns[1].Width = (int)(dgvProductList.Width * 0.1);
                dgvProductList.Columns[2].Width = (int)(dgvProductList.Width * 0.21);
                dgvProductList.Columns[3].Width = (int)(dgvProductList.Width * 0.2);
                dgvProductList.Columns[4].Width = (int)(dgvProductList.Width * 0.2);
                dgvProductList.Columns[5].Width = (int)(dgvProductList.Width * 0.12);
                dgvProductList.Columns[6].Width = (int)(dgvProductList.Width * 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }


    }
}
