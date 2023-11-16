namespace SalesWinApp
{
    partial class frmMain
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
            msAction = new MenuStrip();
            memberManagementToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            orderManagementToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnViewMyOrders = new Button();
            btnAddToCart = new Button();
            btnViewCart = new Button();
            btnBuy = new Button();
            dgvCage = new DataGridView();
            cbMaterial = new ComboBox();
            button1 = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtBar = new TextBox();
            txtMin = new TextBox();
            txtMax = new TextBox();
            button2 = new Button();
            btnFilterBar = new Button();
            button3 = new Button();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            msAction.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCage).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = SystemColors.ControlText;
            lbTitle.Location = new Point(207, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(0, 38);
            lbTitle.TabIndex = 6;
            // 
            // msAction
            // 
            msAction.ImageScalingSize = new Size(20, 20);
            msAction.Items.AddRange(new ToolStripItem[] { memberManagementToolStripMenuItem, productManagementToolStripMenuItem, orderManagementToolStripMenuItem, exitToolStripMenuItem, logoutToolStripMenuItem });
            msAction.Location = new Point(0, 0);
            msAction.Name = "msAction";
            msAction.Padding = new Padding(6, 3, 0, 3);
            msAction.Size = new Size(957, 30);
            msAction.TabIndex = 8;
            msAction.Text = "HomeAction";
            // 
            // memberManagementToolStripMenuItem
            // 
            memberManagementToolStripMenuItem.Name = "memberManagementToolStripMenuItem";
            memberManagementToolStripMenuItem.Size = new Size(171, 24);
            memberManagementToolStripMenuItem.Text = "Member Management";
            memberManagementToolStripMenuItem.Click += memberManagementToolStripMenuItem_Click;
            // 
            // productManagementToolStripMenuItem
            // 
            productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            productManagementToolStripMenuItem.Size = new Size(166, 24);
            productManagementToolStripMenuItem.Text = "Product Management";
            productManagementToolStripMenuItem.Click += productManagementToolStripMenuItem_Click;
            // 
            // orderManagementToolStripMenuItem
            // 
            orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            orderManagementToolStripMenuItem.Size = new Size(153, 24);
            orderManagementToolStripMenuItem.Text = "Order Management";
            orderManagementToolStripMenuItem.Click += orderManagementToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(116, 86, 174);
            panel1.Controls.Add(btnViewMyOrders);
            panel1.Controls.Add(btnAddToCart);
            panel1.Controls.Add(btnViewCart);
            panel1.Controls.Add(btnBuy);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 449);
            panel1.TabIndex = 10;
            // 
            // btnViewMyOrders
            // 
            btnViewMyOrders.BackColor = SystemColors.ButtonHighlight;
            btnViewMyOrders.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewMyOrders.ForeColor = Color.FromArgb(116, 86, 120);
            btnViewMyOrders.Location = new Point(14, 236);
            btnViewMyOrders.Margin = new Padding(3, 4, 3, 4);
            btnViewMyOrders.Name = "btnViewMyOrders";
            btnViewMyOrders.Size = new Size(113, 31);
            btnViewMyOrders.TabIndex = 4;
            btnViewMyOrders.Text = "My Orders";
            btnViewMyOrders.UseVisualStyleBackColor = false;
            btnViewMyOrders.Click += btnViewMyOrders_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = SystemColors.ButtonHighlight;
            btnAddToCart.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddToCart.ForeColor = Color.FromArgb(116, 86, 120);
            btnAddToCart.Location = new Point(14, 296);
            btnAddToCart.Margin = new Padding(3, 4, 3, 4);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(113, 31);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.BackColor = SystemColors.ButtonHighlight;
            btnViewCart.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCart.ForeColor = Color.FromArgb(116, 86, 120);
            btnViewCart.Location = new Point(14, 360);
            btnViewCart.Margin = new Padding(3, 4, 3, 4);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(113, 31);
            btnViewCart.TabIndex = 1;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = false;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = SystemColors.ButtonHighlight;
            btnBuy.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuy.ForeColor = Color.FromArgb(116, 86, 120);
            btnBuy.Location = new Point(14, 167);
            btnBuy.Margin = new Padding(3, 4, 3, 4);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(113, 31);
            btnBuy.TabIndex = 0;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // dgvCage
            // 
            dgvCage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCage.Location = new Point(144, 180);
            dgvCage.Margin = new Padding(3, 4, 3, 4);
            dgvCage.Name = "dgvCage";
            dgvCage.RowHeadersWidth = 51;
            dgvCage.RowTemplate.Height = 25;
            dgvCage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCage.Size = new Size(711, 191);
            dgvCage.TabIndex = 11;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Items.AddRange(new object[] { "Wood", "Metal", "Steel", "Plastic" });
            cbMaterial.Location = new Point(171, 100);
            cbMaterial.Margin = new Padding(3, 4, 3, 4);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(110, 28);
            cbMaterial.TabIndex = 13;
            cbMaterial.Text = "Material";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(116, 86, 120);
            button1.Location = new Point(313, 97);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(173, 31);
            button1.TabIndex = 0;
            button1.Text = "Filter By Material";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(171, 53);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for Cage Description";
            txtSearch.Size = new Size(340, 27);
            txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(116, 86, 120);
            btnSearch.Location = new Point(543, 53);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 31);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBar
            // 
            txtBar.Location = new Point(171, 141);
            txtBar.Margin = new Padding(3, 4, 3, 4);
            txtBar.Name = "txtBar";
            txtBar.PlaceholderText = "Bar";
            txtBar.Size = new Size(110, 27);
            txtBar.TabIndex = 18;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(681, 106);
            txtMin.Margin = new Padding(3, 4, 3, 4);
            txtMin.Name = "txtMin";
            txtMin.PlaceholderText = "Min Price";
            txtMin.Size = new Size(116, 27);
            txtMin.TabIndex = 19;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(540, 106);
            txtMax.Margin = new Padding(3, 4, 3, 4);
            txtMax.Name = "txtMax";
            txtMax.PlaceholderText = "Max price";
            txtMax.Size = new Size(113, 27);
            txtMax.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(116, 86, 120);
            button2.Location = new Point(590, 141);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(163, 31);
            button2.TabIndex = 21;
            button2.Text = "Filter By Price";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnFilterBar
            // 
            btnFilterBar.BackColor = SystemColors.ButtonHighlight;
            btnFilterBar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilterBar.ForeColor = Color.FromArgb(116, 86, 120);
            btnFilterBar.Location = new Point(313, 141);
            btnFilterBar.Margin = new Padding(3, 4, 3, 4);
            btnFilterBar.Name = "btnFilterBar";
            btnFilterBar.Size = new Size(173, 31);
            btnFilterBar.TabIndex = 22;
            btnFilterBar.Text = "Filter By Bar";
            btnFilterBar.UseVisualStyleBackColor = false;
            btnFilterBar.Click += btnFilterBar_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(116, 86, 120);
            button3.Location = new Point(681, 53);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 24;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(172, 172, 230);
            ClientSize = new Size(957, 451);
            Controls.Add(button3);
            Controls.Add(btnFilterBar);
            Controls.Add(button2);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(txtBar);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(cbMaterial);
            Controls.Add(msAction);
            Controls.Add(panel1);
            Controls.Add(lbTitle);
            Controls.Add(dgvCage);
            IsMdiContainer = true;
            MainMenuStrip = msAction;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            msAction.ResumeLayout(false);
            msAction.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private MenuStrip msAction;
        private ToolStripMenuItem memberManagementToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem productManagementToolStripMenuItem;
        private ToolStripMenuItem orderManagementToolStripMenuItem;
        private Panel panel1;
        private Button btnViewCart;
        private Button btnBuy;
        private DataGridView dgvCage;
        private Button btnAddToCart;
        private ComboBox cbMaterial;
        private Button button1;
        private Button btnViewMyOrders;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtBar;
        private TextBox txtMin;
        private TextBox txtMax;
        private Button button2;
        private Button btnFilterBar;
        private Button button3;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}