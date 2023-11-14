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
            msAction.SuspendLayout();
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
            msAction.Items.AddRange(new ToolStripItem[] { memberManagementToolStripMenuItem, productManagementToolStripMenuItem, orderManagementToolStripMenuItem, exitToolStripMenuItem });
            msAction.Location = new Point(0, 0);
            msAction.Name = "msAction";
            msAction.Size = new Size(800, 28);
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTitle);
            Controls.Add(msAction);
            IsMdiContainer = true;
            MainMenuStrip = msAction;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            msAction.ResumeLayout(false);
            msAction.PerformLayout();
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
    }
}