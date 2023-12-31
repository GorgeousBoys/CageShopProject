﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessObject;
using BusinessObject.Models;
using Repository.Repository;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        private IUserRepository memberRepository = new UserRepository();
        private BindingSource source;
        public User checkMember { get; set; }
        public string SelectedImagePath { get; set; }
        private RoleRepository roleRepository = new RoleRepository();

        public frmMembers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "Missing input fields";
            string title = "Invalid Input";
            if (txtEmail == null) MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                
                // Create a new User object based on the input fields
                User newUser = new User
                {
                    
                    UserName = txtUsername.Text,
                    UserPassword = txtPassword.Text, // You should consider hashing the password
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    DoB = DateTime.Parse(txtDob.Text), // Adjust the format as needed
                    Status = cboMemStatus.Text,
                    RoleId = int.Parse(cboRole.Text), // Make sure to handle parsing errors
                    Gender = cboGender.Text

                };

                // Add the new user to the database with the selected image path
                memberRepository.AddUser(newUser, SelectedImagePath);

                // Refresh the DataGridView with the updated user list
                LoadMemberList();

                MessageBox.Show("Add new member successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Adding Member");
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new User object based on the input fields
                User updatedUser = new User
                {
                    UserId = int.Parse(txtUserId.Text), // Assuming UserID is available in the form
                    UserName = txtUsername.Text,
                    UserPassword = txtPassword.Text, // You should consider hashing the password
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    DoB = DateTime.Parse(txtDob.Text), // Adjust the format as needed
                    Status = cboMemStatus.Text,
                    RoleId = int.Parse(cboRole.Text), // Make sure to handle parsing errors
                    Gender = cboGender.Text
                };

                // Update the user in the database
                memberRepository.UpdateUser(updatedUser, SelectedImagePath);

                // Refresh the DataGridView with the updated user list
                LoadMemberList();

                MessageBox.Show("Update member successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating Member");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int userID = int.Parse(txtUserId.Text); // Assuming UserID is available in the form

                    // Delete the user from the database
                    memberRepository.DeleteUser(memberRepository.FindByID(userID));

                    // Refresh the DataGridView with the updated user list
                    LoadMemberList();

                    MessageBox.Show("Delete member successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Member");
            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            try
            {
                // Load the list of users from the database
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Members");
            }
        }

        private void dgvMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = dgvMemberList.Rows[e.RowIndex];

            // Populate the form fields with the selected user's information
            txtUserId.Text = GetValueFromCell(selectedRow, "UserID");
            txtUsername.Text = GetValueFromCell(selectedRow, "UserName");
            txtPassword.Text = GetValueFromCell(selectedRow, "UserPassword");
            txtEmail.Text = GetValueFromCell(selectedRow, "Email");
            txtPhone.Text = GetValueFromCell(selectedRow, "Phone");
            txtAddress.Text = GetValueFromCell(selectedRow, "Address");
            txtDob.Text = GetValueFromCell(selectedRow, "DoB");
            cboRole.Text = GetValueFromCell(selectedRow, "RoleID");
            cboGender.Text = GetValueFromCell(selectedRow, "Gender");
            cboMemStatus.Text = GetValueFromCell(selectedRow, "Status");

            // Get the byte array from the UserIMG column
            byte[] imageData = selectedRow.Cells["UserIMG"].Value as byte[];

            if (imageData != null)
            {
                // Convert the byte array to an Image
                Image userImage = byteArrayToImage(imageData);

                // Display the image in the PictureBox (assuming 'picUser' is your PictureBox)
                picUser.Image = userImage;
            }
            else
            {
                // Handle the case when there is no image data
                picUser.Image = null;
            }

        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }


        private void LoadMemberList()
        {
            // Retrieve the list of users from the database
            var result = memberRepository.GetAllUser().ToList();

            // Display the list of users in the DataGridView
            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = result;

            cboRole.DataSource = roleRepository.GetAll();
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleID";
        }

        private string GetValueFromCell(DataGridViewRow row, string columnName)
        {
            if (row.Cells[columnName].Value != null)
            {
                return row.Cells[columnName].Value.ToString();
            }
            return string.Empty;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Set the filter to allow only image files
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected image file path
                    string imagePath = openFileDialog.FileName;

                    // Display the selected image in the PictureBox
                    picUser.Image = Image.FromFile(imagePath);

                    // Save the image path to a variable or property for later use
                    // For simplicity, let's assume you have a property in your form
                    // Example: public string SelectedImagePath { get; set; }
                    SelectedImagePath = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Uploading Image");
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtUserId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtDob.Text = "";
            byte[] imageData = null;
        }
    }
}
