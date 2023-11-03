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
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbDetailInfo = new System.Windows.Forms.GroupBox();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cbMemberID = new System.Windows.Forms.ComboBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMoreDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.gbGeneralInfo = new System.Windows.Forms.GroupBox();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.gbDetailInfo.SuspendLayout();
            this.gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(366, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(275, 38);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Order Management";
            // 
            // gbDetailInfo
            // 
            this.gbDetailInfo.Controls.Add(this.dtpShippedDate);
            this.gbDetailInfo.Controls.Add(this.dtpRequiredDate);
            this.gbDetailInfo.Controls.Add(this.dtpOrderDate);
            this.gbDetailInfo.Controls.Add(this.cbMemberID);
            this.gbDetailInfo.Controls.Add(this.txtOrderID);
            this.gbDetailInfo.Controls.Add(this.txtFreight);
            this.gbDetailInfo.Controls.Add(this.btnUpdate);
            this.gbDetailInfo.Controls.Add(this.btnDelete);
            this.gbDetailInfo.Controls.Add(this.btnMoreDetail);
            this.gbDetailInfo.Controls.Add(this.btnAdd);
            this.gbDetailInfo.Controls.Add(this.lbRequiredDate);
            this.gbDetailInfo.Controls.Add(this.lbOrderDate);
            this.gbDetailInfo.Controls.Add(this.lbShippedDate);
            this.gbDetailInfo.Controls.Add(this.lbFreight);
            this.gbDetailInfo.Controls.Add(this.lbOrderID);
            this.gbDetailInfo.Controls.Add(this.lbMemberID);
            this.gbDetailInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDetailInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbDetailInfo.Location = new System.Drawing.Point(789, 46);
            this.gbDetailInfo.Name = "gbDetailInfo";
            this.gbDetailInfo.Size = new System.Drawing.Size(292, 402);
            this.gbDetailInfo.TabIndex = 8;
            this.gbDetailInfo.TabStop = false;
            this.gbDetailInfo.Text = "Detail Information";
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShippedDate.Location = new System.Drawing.Point(113, 283);
            this.dtpShippedDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpShippedDate.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(164, 27);
            this.dtpShippedDate.TabIndex = 25;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(113, 234);
            this.dtpRequiredDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpRequiredDate.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(164, 27);
            this.dtpRequiredDate.TabIndex = 24;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(113, 185);
            this.dtpOrderDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpOrderDate.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(164, 27);
            this.dtpOrderDate.TabIndex = 23;
            this.dtpOrderDate.Value = new System.DateTime(2022, 7, 9, 0, 0, 0, 0);
            // 
            // cbMemberID
            // 
            this.cbMemberID.FormattingEnabled = true;
            this.cbMemberID.Location = new System.Drawing.Point(113, 80);
            this.cbMemberID.Name = "cbMemberID";
            this.cbMemberID.Size = new System.Drawing.Size(164, 28);
            this.cbMemberID.TabIndex = 22;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(113, 30);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(164, 27);
            this.txtOrderID.TabIndex = 6;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(113, 131);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(164, 27);
            this.txtFreight.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Location = new System.Drawing.Point(215, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(113, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMoreDetail
            // 
            this.btnMoreDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMoreDetail.Location = new System.Drawing.Point(172, 316);
            this.btnMoreDetail.Name = "btnMoreDetail";
            this.btnMoreDetail.Size = new System.Drawing.Size(105, 28);
            this.btnMoreDetail.TabIndex = 12;
            this.btnMoreDetail.Text = "More Detail";
            this.btnMoreDetail.UseVisualStyleBackColor = true;
            this.btnMoreDetail.Click += new System.EventHandler(this.btnMoreDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Location = new System.Drawing.Point(8, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 42);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(6, 241);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(96, 20);
            this.lbRequiredDate.TabIndex = 5;
            this.lbRequiredDate.Text = "RequiredDate";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(6, 192);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(80, 20);
            this.lbOrderDate.TabIndex = 4;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(6, 290);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(94, 20);
            this.lbShippedDate.TabIndex = 3;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(6, 138);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(53, 20);
            this.lbFreight.TabIndex = 2;
            this.lbFreight.Text = "Freight";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(6, 41);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(64, 20);
            this.lbOrderID.TabIndex = 1;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(6, 88);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(80, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // gbGeneralInfo
            // 
            this.gbGeneralInfo.Controls.Add(this.dgvOrderList);
            this.gbGeneralInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbGeneralInfo.Location = new System.Drawing.Point(12, 50);
            this.gbGeneralInfo.Name = "gbGeneralInfo";
            this.gbGeneralInfo.Size = new System.Drawing.Size(770, 450);
            this.gbGeneralInfo.TabIndex = 14;
            this.gbGeneralInfo.TabStop = false;
            this.gbGeneralInfo.Text = "General Information";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(0, 32);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(764, 412);
            this.dgvOrderList.TabIndex = 0;
            this.dgvOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellClick);
            this.dgvOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.Location = new System.Drawing.Point(797, 454);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(269, 40);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 576);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(508, 576);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOrders
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);

            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbGeneralInfo);
            this.Controls.Add(this.gbDetailInfo);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Add";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.gbDetailInfo.ResumeLayout(false);
            this.gbDetailInfo.PerformLayout();
            this.gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private GroupBox gbDetailInfo;
        private TextBox txtOrderID;
        private Label lbRequiredDate;
        private Label lbOrderDate;
        private Label lbShippedDate;
        private Label lbFreight;
        private Label lbOrderID;
        private Label lbMemberID;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnMoreDetail;
        private GroupBox gbGeneralInfo;
        private DataGridView dgvOrderList;
        private TextBox txtFreight;
        private Button btnBack;
        private DateTimePicker dtpShippedDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpOrderDate;
//Tri

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private ComboBox cbMemberID;
//Tri
    }
}