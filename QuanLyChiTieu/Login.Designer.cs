namespace QuanLyChiTieu
{
    partial class Login
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
            btnCancel = new Button();
            btnLogin = new Button();
            txbPass = new TextBox();
            txbUser = new TextBox();
            lbPass = new Label();
            lbUser = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Location = new Point(312, 188);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Location = new Point(216, 188);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 22);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(216, 114);
            txbPass.Margin = new Padding(3, 2, 3, 2);
            txbPass.Name = "txbPass";
            txbPass.PasswordChar = '*';
            txbPass.Size = new Size(179, 23);
            txbPass.TabIndex = 9;
            // 
            // txbUser
            // 
            txbUser.Location = new Point(216, 76);
            txbUser.Margin = new Padding(3, 2, 3, 2);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(179, 23);
            txbUser.TabIndex = 7;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(138, 114);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(57, 15);
            lbPass.TabIndex = 8;
            lbPass.Text = "Password";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(128, 78);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(65, 15);
            lbUser.TabIndex = 6;
            lbUser.Text = "User Name";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 320);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txbPass);
            Controls.Add(txbUser);
            Controls.Add(lbPass);
            Controls.Add(lbUser);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnLogin;
        private TextBox txbPass;
        private TextBox txbUser;
        private Label lbPass;
        private Label lbUser;
    }
}