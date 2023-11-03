namespace SalesWinApp
{
    partial class frmProducts
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
            this.gbGeneralInfo = new System.Windows.Forms.GroupBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.gbDetailInfo = new System.Windows.Forms.GroupBox();
            this.mtxtUnitPrice = new System.Windows.Forms.MaskedTextBox();
            this.mtxtUnitInStock = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCategoryID = new System.Windows.Forms.MaskedTextBox();
            this.mtxtProductID = new System.Windows.Forms.MaskedTextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.gbDetailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeneralInfo
            // 
            this.gbGeneralInfo.Controls.Add(this.dgvProductList);
            this.gbGeneralInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbGeneralInfo.Location = new System.Drawing.Point(12, 81);
            this.gbGeneralInfo.Name = "gbGeneralInfo";
            this.gbGeneralInfo.Size = new System.Drawing.Size(738, 422);
            this.gbGeneralInfo.TabIndex = 15;
            this.gbGeneralInfo.TabStop = false;
            this.gbGeneralInfo.Text = "General Information";
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(6, 28);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 29;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(726, 388);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            // 
            // gbDetailInfo
            // 
            this.gbDetailInfo.Controls.Add(this.mtxtUnitPrice);
            this.gbDetailInfo.Controls.Add(this.mtxtUnitInStock);
            this.gbDetailInfo.Controls.Add(this.mtxtCategoryID);
            this.gbDetailInfo.Controls.Add(this.mtxtProductID);
            this.gbDetailInfo.Controls.Add(this.txtWeight);
            this.gbDetailInfo.Controls.Add(this.btnDelete);
            this.gbDetailInfo.Controls.Add(this.txtProductName);
            this.gbDetailInfo.Controls.Add(this.btnUpdate);
            this.gbDetailInfo.Controls.Add(this.btnAdd);
            this.gbDetailInfo.Controls.Add(this.lbUnitPrice);
            this.gbDetailInfo.Controls.Add(this.lbWeight);
            this.gbDetailInfo.Controls.Add(this.lbUnitInStock);
            this.gbDetailInfo.Controls.Add(this.lbProductName);
            this.gbDetailInfo.Controls.Add(this.lbProductID);
            this.gbDetailInfo.Controls.Add(this.lbCategoryID);
            this.gbDetailInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDetailInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbDetailInfo.Location = new System.Drawing.Point(756, 50);
            this.gbDetailInfo.Name = "gbDetailInfo";
            this.gbDetailInfo.Size = new System.Drawing.Size(300, 391);
            this.gbDetailInfo.TabIndex = 9;
            this.gbDetailInfo.TabStop = false;
            this.gbDetailInfo.Text = "Detail Information";
            // 
            // mtxtUnitPrice
            // 
            this.mtxtUnitPrice.Location = new System.Drawing.Point(113, 234);
            this.mtxtUnitPrice.Mask = "000000000";
            this.mtxtUnitPrice.Name = "mtxtUnitPrice";
            this.mtxtUnitPrice.Size = new System.Drawing.Size(174, 27);
            this.mtxtUnitPrice.TabIndex = 29;
            this.mtxtUnitPrice.ValidatingType = typeof(int);
            // 
            // mtxtUnitInStock
            // 
            this.mtxtUnitInStock.Location = new System.Drawing.Point(113, 283);
            this.mtxtUnitInStock.Mask = "00000";
            this.mtxtUnitInStock.Name = "mtxtUnitInStock";
            this.mtxtUnitInStock.Size = new System.Drawing.Size(174, 27);
            this.mtxtUnitInStock.TabIndex = 28;
            // 
            // mtxtCategoryID
            // 
            this.mtxtCategoryID.Location = new System.Drawing.Point(113, 81);
            this.mtxtCategoryID.Mask = "00000";
            this.mtxtCategoryID.Name = "mtxtCategoryID";
            this.mtxtCategoryID.Size = new System.Drawing.Size(174, 27);
            this.mtxtCategoryID.TabIndex = 27;
            this.mtxtCategoryID.ValidatingType = typeof(int);
            // 
            // mtxtProductID
            // 
            this.mtxtProductID.Location = new System.Drawing.Point(113, 34);
            this.mtxtProductID.Mask = "00000";
            this.mtxtProductID.Name = "mtxtProductID";
            this.mtxtProductID.ReadOnly = true;
            this.mtxtProductID.Size = new System.Drawing.Size(174, 27);
            this.mtxtProductID.TabIndex = 26;
            this.mtxtProductID.ValidatingType = typeof(int);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(113, 185);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(174, 27);
            this.txtWeight.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(225, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 48);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(113, 131);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(174, 27);
            this.txtProductName.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Location = new System.Drawing.Point(113, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 48);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Location = new System.Drawing.Point(6, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 48);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(6, 241);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(68, 20);
            this.lbUnitPrice.TabIndex = 5;
            this.lbUnitPrice.Text = "UnitPrice";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(6, 192);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(55, 20);
            this.lbWeight.TabIndex = 4;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(6, 290);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(90, 20);
            this.lbUnitInStock.TabIndex = 3;
            this.lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(6, 138);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(102, 20);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "Product Name";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(6, 41);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(74, 20);
            this.lbProductID.TabIndex = 1;
            this.lbProductID.Text = "ProductID";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(6, 88);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(86, 20);
            this.lbCategoryID.TabIndex = 0;
            this.lbCategoryID.Text = "Category ID";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(426, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(303, 38);
            this.lbTitle.TabIndex = 19;
            this.lbTitle.Text = "Product Management";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(12, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 25);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.Location = new System.Drawing.Point(762, 457);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(287, 46);
            this.btnBack.TabIndex = 26;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(78, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(672, 25);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Text = "you are looking for...\r\n";
            // 
            // btnPrice
            // 
            this.btnPrice.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrice.Location = new System.Drawing.Point(12, 509);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(60, 25);
            this.btnPrice.TabIndex = 28;
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt1.Location = new System.Drawing.Point(251, 509);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(125, 24);
            this.txt1.TabIndex = 29;
            this.txt1.Text = "Start with...";
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt2.Location = new System.Drawing.Point(382, 509);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(125, 24);
            this.txt2.TabIndex = 30;
            this.txt2.Text = "End with...";
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 509);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 28);
            this.comboBox1.TabIndex = 31;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 569);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbDetailInfo);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gbGeneralInfo);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            this.gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.gbDetailInfo.ResumeLayout(false);
            this.gbDetailInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbGeneralInfo;
        private DataGridView dgvProductList;
        private GroupBox gbDetailInfo;
        private TextBox txtProductName;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbUnitInStock;
        private Label lbProductName;
        private Label lbProductID;
        private Label lbCategoryID;
        private Label lbTitle;
        private Button btnSearch;
        private TextBox txtWeight;
        private Button btnBack;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSearch;
//Tri
        private Button btnPrice;
        private TextBox txt1;
        private TextBox txt2;
        private ComboBox comboBox1;
        private MaskedTextBox mtxtUnitInStock;
        private MaskedTextBox mtxtCategoryID;
        private MaskedTextBox mtxtProductID;
        private MaskedTextBox mtxtUnitPrice;
//Tri
    }
}