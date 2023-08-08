namespace QuanLyChiTieu
{
    partial class income
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
            dataGridView1 = new DataGridView();
            outcomelbl = new Label();
            icomelbl = new Label();
            dashlbl = new Label();
            label6 = new Label();
            Delete = new Button();
            Edit = new Button();
            cbcategory = new ComboBox();
            Add = new Button();
            dateUse = new DateTimePicker();
            txtdesc = new TextBox();
            txtmoney = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtid = new TextBox();
            label7 = new Label();
            txbTongThu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(164, 71);
            label1.Name = "label1";
            label1.Size = new Size(280, 37);
            label1.TabIndex = 2;
            label1.Text = "QUAN LY THU NHAP";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(581, 359);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // outcomelbl
            // 
            outcomelbl.AutoSize = true;
            outcomelbl.Location = new Point(189, 21);
            outcomelbl.Name = "outcomelbl";
            outcomelbl.Size = new Size(57, 15);
            outcomelbl.TabIndex = 13;
            outcomelbl.Text = "Outcome";
            outcomelbl.Click += outcomelbl_Click;
            // 
            // icomelbl
            // 
            icomelbl.AutoSize = true;
            icomelbl.Location = new Point(116, 21);
            icomelbl.Name = "icomelbl";
            icomelbl.Size = new Size(47, 15);
            icomelbl.TabIndex = 12;
            icomelbl.Text = "Income";
            icomelbl.Click += icomelbl_Click;
            // 
            // dashlbl
            // 
            dashlbl.AutoSize = true;
            dashlbl.Location = new Point(24, 21);
            dashlbl.Name = "dashlbl";
            dashlbl.Size = new Size(64, 15);
            dashlbl.TabIndex = 11;
            dashlbl.Text = "Dashboard";
            dashlbl.Click += dashlbl_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(610, 133);
            label6.Name = "label6";
            label6.Size = new Size(29, 28);
            label6.TabIndex = 50;
            label6.Text = "Id";
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.Location = new Point(958, 466);
            Delete.Name = "Delete";
            Delete.Size = new Size(79, 23);
            Delete.TabIndex = 49;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.FromArgb(128, 255, 128);
            Edit.Location = new Point(709, 466);
            Edit.Name = "Edit";
            Edit.Size = new Size(67, 23);
            Edit.TabIndex = 48;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // cbcategory
            // 
            cbcategory.FormattingEnabled = true;
            cbcategory.Location = new Point(709, 198);
            cbcategory.Name = "cbcategory";
            cbcategory.Size = new Size(295, 23);
            cbcategory.TabIndex = 47;
            // 
            // Add
            // 
            Add.BackColor = Color.Cyan;
            Add.Location = new Point(840, 466);
            Add.Name = "Add";
            Add.Size = new Size(64, 23);
            Add.TabIndex = 46;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // dateUse
            // 
            dateUse.Location = new Point(709, 313);
            dateUse.Name = "dateUse";
            dateUse.Size = new Size(295, 23);
            dateUse.TabIndex = 45;
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(728, 371);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(350, 23);
            txtdesc.TabIndex = 44;
            // 
            // txtmoney
            // 
            txtmoney.Location = new Point(709, 259);
            txtmoney.Name = "txtmoney";
            txtmoney.Size = new Size(295, 23);
            txtmoney.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(610, 371);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 42;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(610, 308);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 41;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(610, 251);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 40;
            label3.Text = "Money";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(610, 190);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 39;
            label2.Text = "Category";
            // 
            // txtid
            // 
            txtid.Location = new Point(709, 141);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(295, 23);
            txtid.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 515);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 52;
            label7.Text = "Tong thu: ";
            // 
            // txbTongThu
            // 
            txbTongThu.Location = new Point(102, 512);
            txbTongThu.Name = "txbTongThu";
            txbTongThu.Size = new Size(181, 23);
            txbTongThu.TabIndex = 53;
            // 
            // income
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 630);
            Controls.Add(txbTongThu);
            Controls.Add(label7);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(cbcategory);
            Controls.Add(Add);
            Controls.Add(dateUse);
            Controls.Add(txtdesc);
            Controls.Add(txtmoney);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(outcomelbl);
            Controls.Add(icomelbl);
            Controls.Add(dashlbl);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "income";
            Text = "income";
            FormClosed += income_FormClosed;
            Load += income_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label outcomelbl;
        private Label icomelbl;
        private Label dashlbl;
        private Label label6;
        private Button Delete;
        private Button Edit;
        private ComboBox cbcategory;
        private Button Add;
        private DateTimePicker dateUse;
        private TextBox txtdesc;
        private TextBox txtmoney;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtid;
        private Label label7;
        private TextBox txbTongThu;
    }
}