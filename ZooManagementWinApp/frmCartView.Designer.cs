namespace ZooWinApp
{
    partial class frmCartView
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
            dgvCart = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(27, 23);
            dgvCart.Name = "dgvCart";
            dgvCart.RowTemplate.Height = 25;
            dgvCart.Size = new Size(433, 399);
            dgvCart.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(487, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(487, 153);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmCartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvCart);
            Name = "frmCartView";
            Text = "My Cart";
            Load += frmCartView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCart;
        private Button button1;
        private Button button2;
    }
}