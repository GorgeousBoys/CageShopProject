using BusinessObject;
using System;
using System.Windows.Forms;
using Repository.Repository;
using BusinessObject.Models;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        IUserRepository memberRepository = new UserRepository();
        BindingSource source;
        public User checkMember { get; set; }

        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Implement the update logic here
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            // Implement the logic for displaying more details
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Implement the search logic
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Refresh the order list
            LoadOrderList();
        }

        private void dgvOrderList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvOrderList.Rows.Count - 1)
                {
                    DataGridViewRow selectedRow = dgvOrderList.Rows[e.RowIndex];

                    // Populate the textboxes with the selected order's information
                    txtOrderName.Text = GetValueFromCell(selectedRow, "OrderName");
                    txtOrderPhone.Text = GetValueFromCell(selectedRow, "OrderPhone");
                    txtOrderPrice.Text = GetValueFromCell(selectedRow, "OrderPrice");
                    txtAddress.Text = GetValueFromCell(selectedRow, "OrderAdress");
                    txtStatus.Text = GetValueFromCell(selectedRow, "OrderStatus");

                    // If OrderUserID is a foreign key to the User table, you can get the user details
                    int orderUserID = int.Parse(GetValueFromCell(selectedRow, "UserID"));
                    User user = memberRepository.FindByID(orderUserID);

                    if (user != null)
                    {
                        // Populate user-related textboxes if needed
                        txtUserID.Text = user.UserId.ToString();
                        // ... (populate other user-related textboxes)
                    }
                    else
                    {
                        // Handle the case when the user is not found
                        txtUserID.Text = "";
                        // ... (clear other user-related textboxes)
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Order Details");
            }
        }

        private void LoadOrderList()
        {
            // Retrieve the list of orders from the database
            var result = orderRepository.GetAllOrders().ToList();

            // Display the list of orders in the DataGridView
            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = result;
        }

        private string GetValueFromCell(DataGridViewRow row, string columnName)
        {
            if (row.Cells[columnName].Value != null)
            {
                return row.Cells[columnName].Value.ToString();
            }
            return string.Empty;
        }

        private void lbOrderDate_Click(object sender, EventArgs e)
        {
            // Handle the click event if needed
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int orderID = int.Parse(txtUserID.Text); // Assuming you have a TextBox named txtOrderID

                    // Delete the order from the database
                    Order orderToDelete = orderRepository.FindByID(orderID);

                    if (orderToDelete != null)
                    {
                        orderRepository.DeleteOrder(orderToDelete);

                        // Refresh the DataGridView with the updated order list
                        LoadOrderList1();

                        MessageBox.Show("Delete order successfully");
                    }
                    else
                    {
                        MessageBox.Show("Order not found", "Error Deleting Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Order");
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            // Refresh the DataGridView with the updated order list
            LoadOrderList1();
            // Clear the text of each textbox
            txtUserID.Text = "";
            txtOrderName.Text = "";
            txtOrderPhone.Text = "";
            txtOrderPrice.Text = "";
            txtAddress.Text = "";
            txtStatus.Text = "";
            txtUserID.Text = ""; // Clear other user-related textboxes if needed

            MessageBox.Show("Order list refreshed");
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have the necessary textboxes for updating an order
                int orderID = int.Parse(txtUserID.Text); // Assuming you have a TextBox named txtOrderID
                Order existingOrder = orderRepository.FindByID(orderID);

                if (existingOrder != null)
                {
                    // Update the order properties based on the textboxes or other controls
                    existingOrder.OrderName = txtOrderName.Text;
                    existingOrder.OrderPhone = txtOrderPhone.Text;
                    existingOrder.OrderPrice = decimal.Parse(txtOrderPrice.Text); // Assuming OrderPrice is a decimal
                    existingOrder.OrderAdress = txtAddress.Text;
                    existingOrder.OrderStatus = txtStatus.Text;

                    // Update the order in the database
                    orderRepository.UpdateOrder(existingOrder);

                    // Refresh the DataGridView with the updated order list
                    LoadOrderList();

                    MessageBox.Show("Update order successfully");
                }
                else
                {
                    MessageBox.Show("Order not found", "Error Updating Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating Order");
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            // Close the form or navigate back to the previous form
            Close();
        }
        private void LoadOrderList1()
        {
            try
            {
                // Retrieve the list of orders from the database
                var result = orderRepository.GetAllOrders().ToList();

                // Display the list of orders in the DataGridView
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Orders");
            }
        }

    }

}

