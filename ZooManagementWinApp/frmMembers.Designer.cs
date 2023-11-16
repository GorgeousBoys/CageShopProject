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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            gbDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            panel1.SuspendLayout();
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
            gbDetailInfo.Location = new Point(21, 39);
            gbDetailInfo.Name = "gbDetailInfo";
            gbDetailInfo.Size = new Size(670, 433);
            gbDetailInfo.TabIndex = 7;
            gbDetailInfo.TabStop = false;
            gbDetailInfo.Text = "Detail Information";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(452, 250);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(190, 27);
            txtGender.TabIndex = 41;
            // 
            // txtRoleId
            // 
            txtRoleId.Location = new Point(105, 251);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.Size = new Size(212, 27);
            txtRoleId.TabIndex = 40;
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
            picUser.Location = new Point(105, 293);
            picUser.Name = "picUser";
            picUser.Size = new Size(212, 119);
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
            // txtStatus
            // 
            txtStatus.Location = new Point(107, 197);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(210, 27);
            txtStatus.TabIndex = 33;
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
            txtAddress.Location = new Point(452, 92);
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
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
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
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(116, 86, 120);
            button1.Location = new Point(217, 55);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 31);
            button1.TabIndex = 28;
            button1.Text = "REMOVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(116, 86, 120);
            button2.Location = new Point(74, 55);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 29;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(116, 86, 120);
            button3.Location = new Point(375, 55);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(113, 31);
            button3.TabIndex = 30;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(116, 86, 120);
            button4.Location = new Point(518, 55);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(113, 31);
            button4.TabIndex = 31;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(116, 86, 174);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(8, 474);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 139);
            panel1.TabIndex = 32;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 624);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
    }
}