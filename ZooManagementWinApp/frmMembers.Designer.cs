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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbDetailInfo = new System.Windows.Forms.GroupBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbGmail = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.gbGeneralInfo = new System.Windows.Forms.GroupBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbDetailInfo.SuspendLayout();
            this.gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Location = new System.Drawing.Point(822, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Location = new System.Drawing.Point(822, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(45, 44);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(822, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(363, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(311, 38);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Member Management";
            // 
            // gbDetailInfo
            // 
            this.gbDetailInfo.Controls.Add(this.txtCountry);
            this.gbDetailInfo.Controls.Add(this.txtCompany);
            this.gbDetailInfo.Controls.Add(this.txtCity);
            this.gbDetailInfo.Controls.Add(this.btnDelete);
            this.gbDetailInfo.Controls.Add(this.txtPassword);
            this.gbDetailInfo.Controls.Add(this.txtGmail);
            this.gbDetailInfo.Controls.Add(this.txtMemberID);
            this.gbDetailInfo.Controls.Add(this.btnUpdate);
            this.gbDetailInfo.Controls.Add(this.btnAdd);
            this.gbDetailInfo.Controls.Add(this.lbCity);
            this.gbDetailInfo.Controls.Add(this.lbCountry);
            this.gbDetailInfo.Controls.Add(this.lbCompany);
            this.gbDetailInfo.Controls.Add(this.lbPassword);
            this.gbDetailInfo.Controls.Add(this.lbGmail);
            this.gbDetailInfo.Controls.Add(this.lbMemberID);
            this.gbDetailInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDetailInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbDetailInfo.Location = new System.Drawing.Point(12, 64);
            this.gbDetailInfo.Name = "gbDetailInfo";
            this.gbDetailInfo.Size = new System.Drawing.Size(880, 177);
            this.gbDetailInfo.TabIndex = 7;
            this.gbDetailInfo.TabStop = false;
            this.gbDetailInfo.Text = "Detail Information";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(502, 38);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(291, 27);
            this.txtCountry.TabIndex = 31;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(502, 139);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(291, 27);
            this.txtCompany.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(502, 91);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(291, 27);
            this.txtCity.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(286, 27);
            this.txtPassword.TabIndex = 8;
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(108, 89);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(286, 27);
            this.txtGmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(108, 38);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(286, 27);
            this.txtMemberID.TabIndex = 6;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(424, 97);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(35, 20);
            this.lbCity.TabIndex = 5;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(424, 46);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 4;
            this.lbCountry.Text = "Country";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Location = new System.Drawing.Point(424, 145);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(71, 20);
            this.lbCompany.TabIndex = 3;
            this.lbCompany.Text = "Company";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(14, 146);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // lbGmail
            // 
            this.lbGmail.AutoSize = true;
            this.lbGmail.Location = new System.Drawing.Point(14, 96);
            this.lbGmail.Name = "lbGmail";
            this.lbGmail.Size = new System.Drawing.Size(48, 20);
            this.lbGmail.TabIndex = 1;
            this.lbGmail.Text = "Gmail";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(14, 46);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(80, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // gbGeneralInfo
            // 
            this.gbGeneralInfo.Controls.Add(this.dgvMemberList);
            this.gbGeneralInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbGeneralInfo.Location = new System.Drawing.Point(12, 247);
            this.gbGeneralInfo.Name = "gbGeneralInfo";
            this.gbGeneralInfo.Size = new System.Drawing.Size(940, 281);
            this.gbGeneralInfo.TabIndex = 8;
            this.gbGeneralInfo.TabStop = false;
            this.gbGeneralInfo.Text = "General Information";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(0, 32);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(934, 249);
            this.dgvMemberList.TabIndex = 0;
            this.dgvMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.Location = new System.Drawing.Point(898, 119);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 94);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 538);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbGeneralInfo);
            this.Controls.Add(this.gbDetailInfo);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.gbDetailInfo.ResumeLayout(false);
            this.gbDetailInfo.PerformLayout();
            this.gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox txtCompany;
        private TextBox txtCity;
        private DataGridView dgvMemberList;
        private Button btnBack;
        private TextBox txtCountry;
        private TextBox txtGmail;
        private TextBox txtMemberID;
    }
}