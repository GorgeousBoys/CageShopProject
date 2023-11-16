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
            gbGeneralInfo = new GroupBox();
            dgvProductList = new DataGridView();
            gbDetailInfo = new GroupBox();
            txtCageStatus = new TextBox();
            label5 = new Label();
            label4 = new Label();
            rbDescription = new RichTextBox();
            txtBar = new TextBox();
            label3 = new Label();
            txtSize = new TextBox();
            label2 = new Label();
            txtMaterial = new TextBox();
            label1 = new Label();
            mtxtPrice = new MaskedTextBox();
            mtxtDIscountID = new MaskedTextBox();
            mtxtCategoryID = new MaskedTextBox();
            mtxtCageID = new MaskedTextBox();
            txtQuantity = new TextBox();
            txtCageName = new TextBox();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            lbUnitInStock = new Label();
            lbCageName = new Label();
            lbProductID = new Label();
            lbCategoryID = new Label();
            lbTitle = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            gbDetailInfo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gbGeneralInfo
            // 
            gbGeneralInfo.Controls.Add(dgvProductList);
            gbGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbGeneralInfo.Location = new Point(12, 81);
            gbGeneralInfo.Name = "gbGeneralInfo";
            gbGeneralInfo.Size = new Size(738, 422);
            gbGeneralInfo.TabIndex = 15;
            gbGeneralInfo.TabStop = false;
            gbGeneralInfo.Text = "General Information";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(6, 28);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new Size(698, 366);
            dgvProductList.TabIndex = 0;
            dgvProductList.CellClick += dgvProductList_CellClick;
            // 
            // gbDetailInfo
            // 
            gbDetailInfo.Controls.Add(txtCageStatus);
            gbDetailInfo.Controls.Add(label5);
            gbDetailInfo.Controls.Add(label4);
            gbDetailInfo.Controls.Add(rbDescription);
            gbDetailInfo.Controls.Add(txtBar);
            gbDetailInfo.Controls.Add(label3);
            gbDetailInfo.Controls.Add(txtSize);
            gbDetailInfo.Controls.Add(label2);
            gbDetailInfo.Controls.Add(txtMaterial);
            gbDetailInfo.Controls.Add(label1);
            gbDetailInfo.Controls.Add(mtxtPrice);
            gbDetailInfo.Controls.Add(mtxtDIscountID);
            gbDetailInfo.Controls.Add(mtxtCategoryID);
            gbDetailInfo.Controls.Add(mtxtCageID);
            gbDetailInfo.Controls.Add(txtQuantity);
            gbDetailInfo.Controls.Add(txtCageName);
            gbDetailInfo.Controls.Add(lbUnitPrice);
            gbDetailInfo.Controls.Add(lbWeight);
            gbDetailInfo.Controls.Add(lbUnitInStock);
            gbDetailInfo.Controls.Add(lbCageName);
            gbDetailInfo.Controls.Add(lbProductID);
            gbDetailInfo.Controls.Add(lbCategoryID);
            gbDetailInfo.FlatStyle = FlatStyle.Popup;
            gbDetailInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbDetailInfo.Location = new Point(756, 50);
            gbDetailInfo.Name = "gbDetailInfo";
            gbDetailInfo.Size = new Size(628, 453);
            gbDetailInfo.TabIndex = 9;
            gbDetailInfo.TabStop = false;
            gbDetailInfo.Text = "Detail Information";
            // 
            // txtCageStatus
            // 
            txtCageStatus.Location = new Point(428, 303);
            txtCageStatus.Name = "txtCageStatus";
            txtCageStatus.Size = new Size(125, 27);
            txtCageStatus.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 307);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 38;
            label5.Text = "CageStatus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 147);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 37;
            label4.Text = "Description";
            // 
            // rbDescription
            // 
            rbDescription.Location = new Point(413, 113);
            rbDescription.Name = "rbDescription";
            rbDescription.Size = new Size(195, 148);
            rbDescription.TabIndex = 36;
            rbDescription.Text = "";
            // 
            // txtBar
            // 
            txtBar.Location = new Point(407, 34);
            txtBar.Name = "txtBar";
            txtBar.Size = new Size(169, 27);
            txtBar.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 37);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 34;
            label3.Text = "Bar";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(114, 389);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 390);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 32;
            label2.Text = "Size";
            // 
            // txtMaterial
            // 
            txtMaterial.Location = new Point(114, 337);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(173, 27);
            txtMaterial.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 340);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 30;
            label1.Text = "Material";
            // 
            // mtxtPrice
            // 
            mtxtPrice.Location = new Point(113, 234);
            mtxtPrice.Mask = "000000000";
            mtxtPrice.Name = "mtxtPrice";
            mtxtPrice.Size = new Size(174, 27);
            mtxtPrice.TabIndex = 29;
            mtxtPrice.ValidatingType = typeof(int);
            // 
            // mtxtDIscountID
            // 
            mtxtDIscountID.Location = new Point(113, 283);
            mtxtDIscountID.Mask = "00000";
            mtxtDIscountID.Name = "mtxtDIscountID";
            mtxtDIscountID.Size = new Size(174, 27);
            mtxtDIscountID.TabIndex = 28;
            // 
            // mtxtCategoryID
            // 
            mtxtCategoryID.Location = new Point(113, 81);
            mtxtCategoryID.Mask = "00000";
            mtxtCategoryID.Name = "mtxtCategoryID";
            mtxtCategoryID.Size = new Size(174, 27);
            mtxtCategoryID.TabIndex = 27;
            mtxtCategoryID.ValidatingType = typeof(int);
            // 
            // mtxtCageID
            // 
            mtxtCageID.Location = new Point(113, 34);
            mtxtCageID.Mask = "00000";
            mtxtCageID.Name = "mtxtCageID";
            mtxtCageID.ReadOnly = true;
            mtxtCageID.Size = new Size(174, 27);
            mtxtCageID.TabIndex = 26;
            mtxtCageID.ValidatingType = typeof(int);
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(113, 185);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(174, 27);
            txtQuantity.TabIndex = 19;
            // 
            // txtCageName
            // 
            txtCageName.Location = new Point(113, 131);
            txtCageName.Name = "txtCageName";
            txtCageName.Size = new Size(174, 27);
            txtCageName.TabIndex = 18;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(6, 241);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(41, 20);
            lbUnitPrice.TabIndex = 5;
            lbUnitPrice.Text = "Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(6, 192);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(65, 20);
            lbWeight.TabIndex = 4;
            lbWeight.Text = "Quantity";
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(6, 290);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(81, 20);
            lbUnitInStock.TabIndex = 3;
            lbUnitInStock.Text = "DiscountID";
            // 
            // lbCageName
            // 
            lbCageName.AutoSize = true;
            lbCageName.Location = new Point(6, 138);
            lbCageName.Name = "lbCageName";
            lbCageName.Size = new Size(85, 20);
            lbCageName.TabIndex = 2;
            lbCageName.Text = "Cage Name";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(6, 41);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(57, 20);
            lbProductID.TabIndex = 1;
            lbProductID.Text = "CageID";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(6, 88);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(86, 20);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Category ID";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.FromArgb(116, 86, 120);
            lbTitle.Location = new Point(544, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(303, 38);
            lbTitle.TabIndex = 19;
            lbTitle.Text = "Product Management";
            lbTitle.Click += lbTitle_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(12, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 25);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.Location = new Point(78, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(672, 25);
            txtSearch.TabIndex = 27;
            txtSearch.Text = "you are looking for...\r\n";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(116, 86, 120);
            button2.Location = new Point(276, 65);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(113, 48);
            button2.TabIndex = 30;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(116, 86, 120);
            button1.Location = new Point(444, 65);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 48);
            button1.TabIndex = 31;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(116, 86, 120);
            button3.Location = new Point(628, 65);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(113, 48);
            button3.TabIndex = 32;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(116, 86, 120);
            button4.Location = new Point(814, 65);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(113, 48);
            button4.TabIndex = 33;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(116, 86, 120);
            button5.Location = new Point(977, 65);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(113, 48);
            button5.TabIndex = 34;
            button5.Text = "CLEAR";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(116, 86, 174);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(9, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 158);
            panel1.TabIndex = 35;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 672);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(gbDetailInfo);
            Controls.Add(lbTitle);
            Controls.Add(gbGeneralInfo);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmProducts_Load;
            gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            gbDetailInfo.ResumeLayout(false);
            gbDetailInfo.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbGeneralInfo;
        private DataGridView dgvProductList;
        private GroupBox gbDetailInfo;
        private TextBox txtCageName;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbUnitInStock;
        private Label lbCageName;
        private Label lbProductID;
        private Label lbCategoryID;
        private Label lbTitle;
        private Button btnSearch;
        private TextBox txtQuantity;
        private TextBox txtSearch;
        private MaskedTextBox mtxtDIscountID;
        private MaskedTextBox mtxtCategoryID;
        private MaskedTextBox mtxtCageID;
        private MaskedTextBox mtxtPrice;
        private Label label2;
        private TextBox txtMaterial;
        private Label label1;
        private TextBox txtCageStatus;
        private Label label5;
        private Label label4;
        private RichTextBox rbDescription;
        private TextBox txtBar;
        private Label label3;
        private TextBox txtSize;
        private Button button5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Panel panel1;
        //Tri
    }
}