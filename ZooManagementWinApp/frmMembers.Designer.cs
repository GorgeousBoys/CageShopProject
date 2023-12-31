﻿namespace SalesWinApp
{
    partial class frmMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            gbDetailInfo = new GroupBox();
            cboRole = new ComboBox();
            cboGender = new ComboBox();
            cboMemStatus = new ComboBox();
            btnRefesh = new Button();
            btnUpload = new Button();
            txtUsername = new TextBox();
            picUser = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtDob = new TextBox();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUserId = new TextBox();
            lbCity = new Label();
            lbCountry = new Label();
            lbCompany = new Label();
            lbPassword = new Label();
            lbGmail = new Label();
            lbMemberID = new Label();
            gbGeneralInfo = new GroupBox();
            dgvMemberList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            gbDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.FromArgb(116, 86, 120);
            lbTitle.Location = new Point(622, -3);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(311, 38);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "Member Management";
            // 
            // gbDetailInfo
            // 
            gbDetailInfo.Controls.Add(cboRole);
            gbDetailInfo.Controls.Add(cboGender);
            gbDetailInfo.Controls.Add(cboMemStatus);
            gbDetailInfo.Controls.Add(btnRefesh);
            gbDetailInfo.Controls.Add(btnUpload);
            gbDetailInfo.Controls.Add(txtUsername);
            gbDetailInfo.Controls.Add(picUser);
            gbDetailInfo.Controls.Add(label5);
            gbDetailInfo.Controls.Add(label4);
            gbDetailInfo.Controls.Add(label3);
            gbDetailInfo.Controls.Add(label2);
            gbDetailInfo.Controls.Add(label1);
            gbDetailInfo.Controls.Add(txtPhone);
            gbDetailInfo.Controls.Add(txtDob);
            gbDetailInfo.Controls.Add(txtAddress);
            gbDetailInfo.Controls.Add(txtPassword);
            gbDetailInfo.Controls.Add(txtEmail);
            gbDetailInfo.Controls.Add(txtUserId);
            gbDetailInfo.Controls.Add(lbCity);
            gbDetailInfo.Controls.Add(lbCountry);
            gbDetailInfo.Controls.Add(lbCompany);
            gbDetailInfo.Controls.Add(lbPassword);
            gbDetailInfo.Controls.Add(lbGmail);
            gbDetailInfo.Controls.Add(lbMemberID);
            gbDetailInfo.FlatStyle = FlatStyle.Popup;
            gbDetailInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbDetailInfo.Location = new Point(21, 39);
            gbDetailInfo.Name = "gbDetailInfo";
            gbDetailInfo.Size = new Size(670, 433);
            gbDetailInfo.TabIndex = 7;
            gbDetailInfo.TabStop = false;
            gbDetailInfo.Text = "Detail Information";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(107, 254);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(210, 28);
            cboRole.TabIndex = 48;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(452, 251);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(190, 28);
            cboGender.TabIndex = 47;
            // 
            // cboMemStatus
            // 
            cboMemStatus.FormattingEnabled = true;
            cboMemStatus.Items.AddRange(new object[] { "Active", "Suspended" });
            cboMemStatus.Location = new Point(107, 194);
            cboMemStatus.Name = "cboMemStatus";
            cboMemStatus.Size = new Size(210, 28);
            cboMemStatus.TabIndex = 43;
            // 
            // btnRefesh
            // 
            btnRefesh.BackColor = SystemColors.ButtonHighlight;
            btnRefesh.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefesh.ForeColor = Color.FromArgb(116, 86, 120);
            btnRefesh.Location = new Point(516, 333);
            btnRefesh.Margin = new Padding(3, 4, 3, 4);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(113, 31);
            btnRefesh.TabIndex = 32;
            btnRefesh.Text = "REFESH";
            btnRefesh.UseVisualStyleBackColor = false;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = SystemColors.ButtonHighlight;
            btnUpload.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpload.ForeColor = Color.FromArgb(116, 86, 120);
            btnUpload.Location = new Point(369, 333);
            btnUpload.Margin = new Padding(3, 4, 3, 4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(113, 31);
            btnUpload.TabIndex = 42;
            btnUpload.Text = "UPLOAD";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(452, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 27);
            txtUsername.TabIndex = 39;
            // 
            // picUser
            // 
            picUser.Location = new Point(105, 299);
            picUser.Name = "picUser";
            picUser.Size = new Size(212, 119);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 38;
            picUser.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 257);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 37;
            label5.Text = "RoleId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 333);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 36;
            label4.Text = "UserIMG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 254);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 35;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 200);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 34;
            label2.Text = "UserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 197);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 32;
            label1.Text = "Status";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(452, 38);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(190, 27);
            txtPhone.TabIndex = 31;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(452, 139);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(190, 27);
            txtDob.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(452, 85);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(190, 27);
            txtAddress.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(107, 37);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(210, 27);
            txtUserId.TabIndex = 6;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(349, 92);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(58, 20);
            lbCity.TabIndex = 5;
            lbCity.Text = "Address";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(349, 44);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(49, 20);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Phone";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(349, 142);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(36, 20);
            lbCompany.TabIndex = 3;
            lbCompany.Text = "Dob";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(14, 147);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.Location = new Point(14, 96);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(45, 20);
            lbGmail.TabIndex = 1;
            lbGmail.Text = "Email";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(14, 45);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(56, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "User ID";
            // 
            // gbGeneralInfo
            // 
            gbGeneralInfo.Controls.Add(dgvMemberList);
            gbGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbGeneralInfo.Location = new Point(697, 39);
            gbGeneralInfo.Name = "gbGeneralInfo";
            gbGeneralInfo.Size = new Size(656, 573);
            gbGeneralInfo.TabIndex = 8;
            gbGeneralInfo.TabStop = false;
            gbGeneralInfo.Text = "General Information";
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(17, 26);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(617, 527);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellClick += dgvMemberList_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(116, 86, 120);
            btnAdd.Location = new Point(42, 538);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 31);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonHighlight;
            btnUpdate.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(116, 86, 120);
            btnUpdate.Location = new Point(212, 538);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 31);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonHighlight;
            btnDelete.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(116, 86, 120);
            btnDelete.Location = new Point(370, 538);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 31);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(116, 86, 120);
            btnBack.Location = new Point(537, 538);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 31);
            btnBack.TabIndex = 46;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 624);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(gbGeneralInfo);
            Controls.Add(gbDetailInfo);
            Controls.Add(lbTitle);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMembers_Load;
            gbDetailInfo.ResumeLayout(false);
            gbDetailInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbTitle;
        private GroupBox gbDetailInfo;
        private GroupBox gbGeneralInfo;
        private TextBox txtPassword;
        private Label lbCity;
        private Label lbCountry;
        private Label lbCompany;
        private Label lbPassword;
        private Label lbGmail;
        private Label lbMemberID;
        private TextBox txtDob;
        private TextBox txtAddress;
        private DataGridView dgvMemberList;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtUserId;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox picUser;
        private TextBox txtUsername;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnBack;
        private Panel panel1;
        private Button btnUpload;
        private Button btnRefesh;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox cboMemStatus;
        private ComboBox cboGender;
        private ComboBox cboRole;
    }
}