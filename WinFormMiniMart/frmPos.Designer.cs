namespace WinFormMiniMart
{
    partial class frmPos
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
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            txtProductID = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lsvProduct = new ListView();
            txtTotal = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            lblNetPrice = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(88, 34);
            txtEmployeeID.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(110, 23);
            txtEmployeeID.TabIndex = 0;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = Color.White;
            txtEmployeeName.Location = new Point(379, 34);
            txtEmployeeName.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(110, 23);
            txtEmployeeName.TabIndex = 1;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(5, 42);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(110, 23);
            txtProductID.TabIndex = 2;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lsvProduct);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Location = new Point(10, 72);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(537, 256);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการสั่งซื้อ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(455, 25);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 15;
            label7.Text = "รวม";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 25);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 14;
            label6.Text = "จำนวน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 25);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 13;
            label5.Text = "ราคาขาย";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 24);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 12;
            label4.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 24);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "รหัสสินค้า";
            // 
            // lsvProduct
            // 
            lsvProduct.Location = new Point(5, 75);
            lsvProduct.Margin = new Padding(3, 2, 3, 2);
            lsvProduct.Name = "lsvProduct";
            lsvProduct.Size = new Size(527, 178);
            lsvProduct.TabIndex = 7;
            lsvProduct.UseCompatibleStateImageBehavior = false;
            lsvProduct.DoubleClick += lsvProduct_DoubleClick;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Location = new Point(455, 42);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(78, 23);
            txtTotal.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(361, 42);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(81, 23);
            txtQuantity.TabIndex = 5;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.White;
            txtUnitPrice.Location = new Point(256, 42);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.TextChanged += textBox3_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.White;
            txtProductName.Location = new Point(132, 42);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(110, 23);
            txtProductName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Location = new Point(569, 159);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 39);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "เพิ่ม";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 255, 128);
            btnClear.Location = new Point(569, 202);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 38);
            btnClear.TabIndex = 5;
            btnClear.Text = "ล้าง";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Enabled = false;
            btnSave.Location = new Point(569, 244);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 192, 0);
            btnCancel.Location = new Point(569, 284);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 41);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "ยกเลิกรายการ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNetPrice
            // 
            lblNetPrice.BackColor = Color.Red;
            lblNetPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPrice.Location = new Point(555, 21);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(133, 36);
            lblNetPrice.TabIndex = 8;
            lblNetPrice.Text = "0";
            lblNetPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 42);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 10;
            label2.Text = "ชื่อ-สกุล";
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNetPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPos";
            Text = "frmPos";
            Load += frmPos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private TextBox txtProductID;
        private GroupBox groupBox1;
        private TextBox txtTotal;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private ListView lsvProduct;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private Label lblNetPrice;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}