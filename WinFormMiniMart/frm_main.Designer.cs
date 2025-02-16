﻿namespace WinFormMiniMart
{
    partial class frm_main
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
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(67, 52);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 93);
            txtDescription.TabIndex = 12;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(385, 17);
            txtCategoryName.Margin = new Padding(3, 2, 3, 2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(287, 23);
            txtCategoryName.TabIndex = 11;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Enabled = false;
            txtCategoryID.Location = new Point(120, 14);
            txtCategoryID.Margin = new Padding(3, 2, 3, 2);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(134, 23);
            txtCategoryID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 52);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "รายละเอียด";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 17);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 8;
            label2.Text = "ชื่อประเภทสินค้า";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 7;
            label1.Text = "รหัสประเภทสินค้า";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Location = new Point(385, 74);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 44);
            btnSave.TabIndex = 13;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 255, 128);
            btnCancel.Location = new Point(533, 74);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 44);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frm_main
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(700, 161);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_main";
            Text = "เพิ่ม / ปรับปรุง ข้อมูลหมวดหมู่สินค้า";
            Load += frm_main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}