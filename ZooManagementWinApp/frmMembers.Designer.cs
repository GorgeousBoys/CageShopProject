namespace SalesWinApp
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lbTitle = new Label();
            gbDetailInfo = new GroupBox();
            txtGender = new TextBox();
            txtRoleId = new TextBox();
            txtUsername = new TextBox();
            picUser = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtStatus = new TextBox();
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
            btnBack = new Button();
            gbDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Location = new Point(59, 388);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = SystemColors.ControlDarkDark;
            btnUpdate.Location = new Point(289, 388);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 33);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = SystemColors.ControlDarkDark;
            btnDelete.Location = new Point(172, 388);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 33);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = SystemColors.ControlText;
            lbTitle.Location = new Point(544, -2);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(245, 30);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "Member Management";
            // 
            // gbDetailInfo
            // 
            gbDetailInfo.Controls.Add(txtGender);
            gbDetailInfo.Controls.Add(txtRoleId);
            gbDetailInfo.Controls.Add(txtUsername);
            gbDetailInfo.Controls.Add(picUser);
            gbDetailInfo.Controls.Add(label5);
            gbDetailInfo.Controls.Add(label4);
            gbDetailInfo.Controls.Add(label3);
            gbDetailInfo.Controls.Add(label2);
            gbDetailInfo.Controls.Add(txtStatus);
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
            gbDetailInfo.Location = new Point(18, 29);
            gbDetailInfo.Margin = new Padding(3, 2, 3, 2);
            gbDetailInfo.Name = "gbDetailInfo";
            gbDetailInfo.Padding = new Padding(3, 2, 3, 2);
            gbDetailInfo.Size = new Size(748, 325);
            gbDetailInfo.TabIndex = 7;
            gbDetailInfo.TabStop = false;
            gbDetailInfo.Text = "Detail Information";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(439, 185);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(255, 23);
            txtGender.TabIndex = 41;
            // 
            // txtRoleId
            // 
            txtRoleId.Location = new Point(92, 188);
            txtRoleId.Margin = new Padding(3, 2, 3, 2);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.Size = new Size(253, 23);
            txtRoleId.TabIndex = 40;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(439, 148);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(255, 23);
            txtUsername.TabIndex = 39;
            // 
            // picUser
            // 
            picUser.Location = new Point(92, 220);
            picUser.Margin = new Padding(3, 2, 3, 2);
            picUser.Name = "picUser";
            picUser.Size = new Size(338, 89);
            picUser.TabIndex = 38;
            picUser.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 193);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 37;
            label5.Text = "RoleId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 250);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 36;
            label4.Text = "UserIMG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 188);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 35;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 151);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 34;
            label2.Text = "UserName";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(94, 148);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(251, 23);
            txtStatus.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 148);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 32;
            label1.Text = "Status";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(439, 28);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(255, 23);
            txtPhone.TabIndex = 31;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(439, 104);
            txtDob.Margin = new Padding(3, 2, 3, 2);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(255, 23);
            txtDob.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(439, 68);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(255, 23);
            txtAddress.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 104);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(251, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 67);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(94, 28);
            txtUserId.Margin = new Padding(3, 2, 3, 2);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(251, 23);
            txtUserId.TabIndex = 6;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(371, 73);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(49, 15);
            lbCity.TabIndex = 5;
            lbCity.Text = "Address";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(371, 34);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(40, 15);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Phone";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(371, 109);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(29, 15);
            lbCompany.TabIndex = 3;
            lbCompany.Text = "Dob";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(12, 110);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.Location = new Point(12, 72);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(36, 15);
            lbGmail.TabIndex = 1;
            lbGmail.Text = "Email";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(12, 34);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(65, 15);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // gbGeneralInfo
            // 
            gbGeneralInfo.Controls.Add(dgvMemberList);
            gbGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbGeneralInfo.Location = new Point(824, 40);
            gbGeneralInfo.Margin = new Padding(3, 2, 3, 2);
            gbGeneralInfo.Name = "gbGeneralInfo";
            gbGeneralInfo.Padding = new Padding(3, 2, 3, 2);
            gbGeneralInfo.Size = new Size(360, 380);
            gbGeneralInfo.TabIndex = 8;
            gbGeneralInfo.TabStop = false;
            gbGeneralInfo.Text = "General Information";
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(5, 20);
            dgvMemberList.Margin = new Padding(3, 2, 3, 2);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(349, 344);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellClick += dgvMemberList_CellClick;
            // 
            // btnBack
            // 
            btnBack.ForeColor = SystemColors.ControlDarkDark;
            btnBack.Location = new Point(414, 388);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(77, 33);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 468);
            Controls.Add(btnBack);
            Controls.Add(gbGeneralInfo);
            Controls.Add(gbDetailInfo);
            Controls.Add(btnDelete);
            Controls.Add(lbTitle);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
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
        private Button btnBack;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtUserId;
        private TextBox txtStatus;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox picUser;
        private TextBox txtUsername;
        private TextBox txtGender;
        private TextBox txtRoleId;
    }
}