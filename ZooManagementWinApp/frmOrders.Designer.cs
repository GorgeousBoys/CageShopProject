namespace SalesWinApp
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            lbTitle = new Label();
            gbDetailInfo = new GroupBox();
            txtStatus = new TextBox();
            txtAddress = new TextBox();
            txtOrderPrice = new TextBox();
            txtOrderPhone = new TextBox();
            txtOrderName = new TextBox();
            txtUserID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpOrderDate = new DateTimePicker();
            lbOrderDate = new Label();
            btnRefesh = new Button();
            btnUpdate = new Button();
            gbGeneralInfo = new GroupBox();
            dgvOrderList = new DataGridView();
            btnBack = new Button();
            btnDelete = new Button();
            gbDetailInfo.SuspendLayout();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = SystemColors.Control;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.FromArgb(116, 86, 120);
            lbTitle.Location = new Point(428, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(275, 38);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Order Management";
            // 
            // gbDetailInfo
            // 
            gbDetailInfo.BackColor = Color.MediumOrchid;
            gbDetailInfo.Controls.Add(txtStatus);
            gbDetailInfo.Controls.Add(txtAddress);
            gbDetailInfo.Controls.Add(txtOrderPrice);
            gbDetailInfo.Controls.Add(txtOrderPhone);
            gbDetailInfo.Controls.Add(txtOrderName);
            gbDetailInfo.Controls.Add(txtUserID);
            gbDetailInfo.Controls.Add(label6);
            gbDetailInfo.Controls.Add(label5);
            gbDetailInfo.Controls.Add(label4);
            gbDetailInfo.Controls.Add(label3);
            gbDetailInfo.Controls.Add(label2);
            gbDetailInfo.Controls.Add(label1);
            gbDetailInfo.Controls.Add(dtpOrderDate);
            gbDetailInfo.Controls.Add(lbOrderDate);
            gbDetailInfo.FlatStyle = FlatStyle.Popup;
            gbDetailInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbDetailInfo.Location = new Point(715, 50);
            gbDetailInfo.Name = "gbDetailInfo";
            gbDetailInfo.Size = new Size(366, 450);
            gbDetailInfo.TabIndex = 8;
            gbDetailInfo.TabStop = false;
            gbDetailInfo.Text = "Detail Information";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(119, 374);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(174, 27);
            txtStatus.TabIndex = 35;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(119, 317);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(174, 27);
            txtAddress.TabIndex = 34;
            // 
            // txtOrderPrice
            // 
            txtOrderPrice.Location = new Point(119, 199);
            txtOrderPrice.Name = "txtOrderPrice";
            txtOrderPrice.Size = new Size(174, 27);
            txtOrderPrice.TabIndex = 33;
            // 
            // txtOrderPhone
            // 
            txtOrderPhone.Location = new Point(119, 144);
            txtOrderPhone.Name = "txtOrderPhone";
            txtOrderPhone.Size = new Size(174, 27);
            txtOrderPhone.TabIndex = 32;
            // 
            // txtOrderName
            // 
            txtOrderName.Location = new Point(119, 92);
            txtOrderName.Name = "txtOrderName";
            txtOrderName.Size = new Size(174, 27);
            txtOrderName.TabIndex = 31;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(119, 34);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(174, 27);
            txtUserID.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 147);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 29;
            label6.Text = "OrderPhone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 95);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 28;
            label5.Text = "OrderName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 320);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 27;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 202);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 26;
            label3.Text = "OrderPrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 381);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 25;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 24;
            label1.Text = "UserID";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(119, 255);
            dtpOrderDate.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dtpOrderDate.MinDate = new DateTime(1996, 1, 1, 0, 0, 0, 0);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(174, 27);
            dtpOrderDate.TabIndex = 23;
            dtpOrderDate.Value = new DateTime(2022, 7, 9, 0, 0, 0, 0);
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(18, 255);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(80, 20);
            lbOrderDate.TabIndex = 4;
            lbOrderDate.Text = "Order Date";
            lbOrderDate.Click += lbOrderDate_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.BackColor = SystemColors.ButtonHighlight;
            btnRefesh.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefesh.ForeColor = Color.FromArgb(116, 86, 120);
            btnRefesh.Location = new Point(872, 522);
            btnRefesh.Margin = new Padding(3, 4, 3, 4);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(113, 31);
            btnRefesh.TabIndex = 45;
            btnRefesh.Text = "REFESH";
            btnRefesh.UseVisualStyleBackColor = false;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonHighlight;
            btnUpdate.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(116, 86, 120);
            btnUpdate.Location = new Point(715, 522);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 31);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // gbGeneralInfo
            // 
            gbGeneralInfo.BackColor = Color.MediumOrchid;
            gbGeneralInfo.Controls.Add(dgvOrderList);
            gbGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbGeneralInfo.Location = new Point(12, 50);
            gbGeneralInfo.Name = "gbGeneralInfo";
            gbGeneralInfo.Size = new Size(697, 450);
            gbGeneralInfo.TabIndex = 14;
            gbGeneralInfo.TabStop = false;
            gbGeneralInfo.Text = "General Information";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(6, 32);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new Size(685, 412);
            dgvOrderList.TabIndex = 0;
            dgvOrderList.CellMouseDoubleClick += dgvOrderList_CellMouseDoubleClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(116, 86, 120);
            btnBack.Location = new Point(872, 580);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 31);
            btnBack.TabIndex = 46;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonHighlight;
            btnDelete.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(116, 86, 120);
            btnDelete.Location = new Point(715, 580);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 31);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1093, 671);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(gbGeneralInfo);
            Controls.Add(gbDetailInfo);
            Controls.Add(btnRefesh);
            Controls.Add(lbTitle);
            Controls.Add(btnUpdate);
            Name = "frmOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "Add";
            Load += frmOrders_Load;
            gbDetailInfo.ResumeLayout(false);
            gbDetailInfo.PerformLayout();
            gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private GroupBox gbDetailInfo;
        private Label lbOrderDate;
        private GroupBox gbGeneralInfo;
        private DataGridView dgvOrderList;
        private DateTimePicker dtpOrderDate;
        private Label label1;
        public Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUserID;
        private TextBox txtOrderPhone;
        private TextBox txtOrderName;
        private TextBox txtOrderPrice;
        private TextBox txtAddress;
        private TextBox txtStatus;
        private Button btnUpdate;
        private Button btnRefesh;
        private Button btnBack;
        private Button btnDelete;
        //Tri
    }
}