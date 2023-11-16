namespace SalesWinApp
{
    partial class frmOrderDetail
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
            gbGeneralInfo = new GroupBox();
            dgvOrderDetailList = new DataGridView();
            btnExit = new Button();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = SystemColors.ControlText;
            lbTitle.Location = new Point(214, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(178, 38);
            lbTitle.TabIndex = 7;
            lbTitle.Text = "Order Detail";
            // 
            // gbGeneralInfo
            // 
            gbGeneralInfo.Controls.Add(dgvOrderDetailList);
            gbGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbGeneralInfo.Location = new Point(12, 50);
            gbGeneralInfo.Name = "gbGeneralInfo";
            gbGeneralInfo.Size = new Size(519, 221);
            gbGeneralInfo.TabIndex = 15;
            gbGeneralInfo.TabStop = false;
            gbGeneralInfo.Text = "General Information";
            gbGeneralInfo.Enter += gbGeneralInfo_Enter;
            // 
            // dgvOrderDetailList
            // 
            dgvOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailList.Location = new Point(6, 26);
            dgvOrderDetailList.Name = "dgvOrderDetailList";
            dgvOrderDetailList.ReadOnly = true;
            dgvOrderDetailList.RowHeadersWidth = 51;
            dgvOrderDetailList.RowTemplate.Height = 29;
            dgvOrderDetailList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetailList.Size = new Size(507, 189);
            dgvOrderDetailList.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(531, 209);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(52, 56);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 283);
            Controls.Add(btnExit);
            Controls.Add(gbGeneralInfo);
            Controls.Add(lbTitle);
            Name = "frmOrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmOrderDetail_Load;
            gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private GroupBox gbGeneralInfo;
        private DataGridView dgvOrderDetailList;
        private Button btnExit;
    }
}