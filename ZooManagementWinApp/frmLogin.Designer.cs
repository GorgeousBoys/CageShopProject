namespace ZooWinApp
{
    partial class frmLogin
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
            label5 = new Label();
            label4 = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            checkbxShowPas = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(91, 500);
            label5.Name = "label5";
            label5.Size = new Size(101, 17);
            label5.TabIndex = 23;
            label5.Text = "Create Account";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 462);
            label4.Name = "label4";
            label4.Size = new Size(150, 17);
            label4.TabIndex = 22;
            label4.Text = "Don't Have an Account";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(116, 86, 174);
            btnClear.Location = new Point(41, 408);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(247, 40);
            btnClear.TabIndex = 21;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(116, 86, 174);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(41, 349);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(247, 40);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkbxShowPas
            // 
            checkbxShowPas.AutoSize = true;
            checkbxShowPas.Cursor = Cursors.Hand;
            checkbxShowPas.FlatStyle = FlatStyle.Flat;
            checkbxShowPas.Location = new Point(159, 304);
            checkbxShowPas.Name = "checkbxShowPas";
            checkbxShowPas.Size = new Size(113, 21);
            checkbxShowPas.TabIndex = 19;
            checkbxShowPas.Text = "Show Pasword";
            checkbxShowPas.UseVisualStyleBackColor = true;
            checkbxShowPas.CheckedChanged += checkbxShowPas_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(41, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(247, 21);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 214);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(41, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 21);
            txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 143);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 554);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(checkbxShowPas);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 164, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Button btnClear;
        private Button btnLogin;
        private CheckBox checkbxShowPas;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
    }
}