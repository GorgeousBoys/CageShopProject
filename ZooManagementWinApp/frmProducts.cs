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
            try
            {
                var product = GetProductObject1();

                ValidateProduct(product);

                productRepository.AddProduct(product);
                LoadProductList();
                MessageBox.Show("Add new product successfully");
                ClearInputFields(); // Optionally clear input fields after successful addition
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product");
            }
        }

        private void ValidateProduct(Product product)
        {
            if (product == null ||
                string.IsNullOrWhiteSpace(product.CageName) ||
                product.CategoryId <= 0 ||
                product.Price <= 0 ||
                product.CageStatus <= 0 ||
                product.Quantity <= 0 ||
                product.Bar <= 0 ||
                product.DiscountId <= 0 ||
                string.IsNullOrWhiteSpace(product.Size) ||
                string.IsNullOrWhiteSpace(product.Description))
            {
                throw new Exception("Add new product fail. Fill in all required information.");
            }
        }

        private void ClearInputFields()
        {
            mtxtCageID.Text = "";
            txtCageName.Text = "";
            mtxtCategoryID.Text = "";
            txtQuantity.Text = "";
            mtxtPrice.Text = "";
            mtxtDIscountID.Text = "";
            txtMaterial.Text = "";
            txtSize.Text = "";
            txtBar.Text = "";
            rbDescription.Text = "";
            txtCageStatus.Text = "";
        }

        private Product GetProductObject1()
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
                    CageStatus = int.Parse(mtxtDIscountID.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Bar = int.Parse(txtBar.Text),
                    DiscountId = int.Parse(mtxtDIscountID.Text),
                    Size = txtSize.Text,
                    Description = rbDescription.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject1();

                ValidateProductForUpdate(product);

                product.CageId = int.Parse(mtxtCageID.Text);
                productRepository.UpdateProduct(product);
                LoadProductList();
                MessageBox.Show($"Product {product.CageName} updated successfully!", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ValidateProductForUpdate(Product product)
        {
            if (product == null ||
                string.IsNullOrWhiteSpace(product.CageName) ||
                product.CategoryId <= 0 ||
                product.Price <= 0 ||
                product.CageStatus <= 0 ||
                product.Quantity <= 0 ||
                product.Bar <= 0 ||
                product.DiscountId <= 0 ||
                string.IsNullOrWhiteSpace(product.Size) ||
                string.IsNullOrWhiteSpace(product.Description))
            {
                throw new Exception("Update product fail. Fill in all required information.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var productID = int.Parse(mtxtCageID.Text);

                    productRepository.DeleteProduct(productRepository.FindByID(productID));
                    LoadProductList();
                    mtxtCageID.Clear();

                    MessageBox.Show("Product deleted successfully!", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete product", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (IsValidRowIndex(e.RowIndex))
            {
                DataGridViewRow selectedRow = dgvProductList.Rows[e.RowIndex];

                mtxtCageID.Text = GetCellValue(selectedRow, "CageID");
                txtCageName.Text = GetCellValue(selectedRow, "CageName");
                mtxtCategoryID.Text = GetCellValue(selectedRow, "CategoryID");
                txtQuantity.Text = GetCellValue(selectedRow, "Quantity");
                mtxtPrice.Text = GetCellValue(selectedRow, "Price");
                mtxtDIscountID.Text = GetCellValue(selectedRow, "DiscountID");
                txtMaterial.Text = GetCellValue(selectedRow, "Material");
                txtSize.Text = GetCellValue(selectedRow, "Size");
                txtBar.Text = GetCellValue(selectedRow, "Bar");
                rbDescription.Text = GetCellValue(selectedRow, "Description");
                txtCageStatus.Text = GetCellValue(selectedRow, "CageStatus");
            }
        }

        private bool IsValidRowIndex(int rowIndex)
        {
            return rowIndex >= 0 && rowIndex < dgvProductList.Rows.Count - 1;
        }

        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName].Value?.ToString() ?? string.Empty;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtxtCageID.Text = "";
            txtCageName.Text = "";
            mtxtCategoryID.Text = "";
            txtQuantity.Text = "";
            mtxtPrice.Text = "";
            mtxtDIscountID.Text = "";
            txtMaterial.Text = "";
            txtSize.Text = "";
            txtBar.Text = "";
            rbDescription.Text = "";
            txtCageStatus.Text = "";
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
