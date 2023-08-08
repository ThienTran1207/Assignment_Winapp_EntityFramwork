namespace QuanLyChiTieu
{
    partial class dashboard
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
            label1 = new Label();
            Tong = new Label();
            label2 = new Label();
            label3 = new Label();
            txtThu = new TextBox();
            txtChi = new TextBox();
            txtDu = new TextBox();
            outcomelbl = new Label();
            dashlbl = new Label();
            icomelbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(198, 63);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 1;
            label1.Text = "THONG KE";
            // 
            // Tong
            // 
            Tong.AutoSize = true;
            Tong.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Tong.ForeColor = Color.Black;
            Tong.Location = new Point(63, 160);
            Tong.Name = "Tong";
            Tong.Size = new Size(93, 28);
            Tong.TabIndex = 2;
            Tong.Text = "Tong thu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(63, 268);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 3;
            label2.Text = "Tong chi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(72, 387);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 4;
            label3.Text = "So du:";
            // 
            // txtThu
            // 
            txtThu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtThu.Location = new Point(72, 211);
            txtThu.Name = "txtThu";
            txtThu.Size = new Size(415, 34);
            txtThu.TabIndex = 5;
            // 
            // txtChi
            // 
            txtChi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtChi.Location = new Point(72, 335);
            txtChi.Name = "txtChi";
            txtChi.Size = new Size(415, 34);
            txtChi.TabIndex = 6;
            // 
            // txtDu
            // 
            txtDu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDu.Location = new Point(72, 438);
            txtDu.Name = "txtDu";
            txtDu.Size = new Size(415, 34);
            txtDu.TabIndex = 7;
            // 
            // outcomelbl
            // 
            outcomelbl.AutoSize = true;
            outcomelbl.Location = new Point(198, 22);
            outcomelbl.Name = "outcomelbl";
            outcomelbl.Size = new Size(57, 15);
            outcomelbl.TabIndex = 10;
            outcomelbl.Text = "Outcome";
            outcomelbl.Click += outcomelbl_Click;
            // 
            // dashlbl
            // 
            dashlbl.AutoSize = true;
            dashlbl.Location = new Point(33, 22);
            dashlbl.Name = "dashlbl";
            dashlbl.Size = new Size(64, 15);
            dashlbl.TabIndex = 8;
            dashlbl.Text = "Dashboard";
            dashlbl.Click += dashlbl_Click;
            // 
            // icomelbl
            // 
            icomelbl.AutoSize = true;
            icomelbl.Location = new Point(125, 22);
            icomelbl.Name = "icomelbl";
            icomelbl.Size = new Size(47, 15);
            icomelbl.TabIndex = 9;
            icomelbl.Text = "Income";
            icomelbl.Click += icomelbl_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 577);
            Controls.Add(outcomelbl);
            Controls.Add(icomelbl);
            Controls.Add(dashlbl);
            Controls.Add(txtDu);
            Controls.Add(txtChi);
            Controls.Add(txtThu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Tong);
            Controls.Add(label1);
            Name = "dashboard";
            Text = "dashboard";
            FormClosed += dashboard_FormClosed;
            Load += dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Tong;
        private Label label2;
        private Label label3;
        private TextBox txtThu;
        private TextBox txtChi;
        private TextBox txtDu;
        private Label outcomelbl;
        private Label dashlbl;
        private Label icomelbl;
    }
}