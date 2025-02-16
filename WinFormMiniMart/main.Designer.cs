namespace WinFormMiniMart
{
    partial class main
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
            menuStrip1 = new MenuStrip();
            จดการToolStripMenuItem = new ToolStripMenuItem();
            พนกงานToolStripMenuItem = new ToolStripMenuItem();
            สนคToolStripMenuItem = new ToolStripMenuItem();
            จดการToolStripMenuItem1 = new ToolStripMenuItem();
            คำนวนสนคาToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SpringGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { จดการToolStripMenuItem, คำนวนสนคาToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // จดการToolStripMenuItem
            // 
            จดการToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { พนกงานToolStripMenuItem, สนคToolStripMenuItem, จดการToolStripMenuItem1 });
            จดการToolStripMenuItem.Name = "จดการToolStripMenuItem";
            จดการToolStripMenuItem.Size = new Size(49, 20);
            จดการToolStripMenuItem.Text = "จัดการ";
            // 
            // พนกงานToolStripMenuItem
            // 
            พนกงานToolStripMenuItem.Name = "พนกงานToolStripMenuItem";
            พนกงานToolStripMenuItem.Size = new Size(162, 22);
            พนกงานToolStripMenuItem.Text = "จัดการสินค้า";
            พนกงานToolStripMenuItem.Click += พนกงานToolStripMenuItem_Click;
            // 
            // สนคToolStripMenuItem
            // 
            สนคToolStripMenuItem.Name = "สนคToolStripMenuItem";
            สนคToolStripMenuItem.Size = new Size(162, 22);
            สนคToolStripMenuItem.Text = "จัดการประเภทสินค้า";
            สนคToolStripMenuItem.Click += สนคToolStripMenuItem_Click;
            // 
            // จดการToolStripMenuItem1
            // 
            จดการToolStripMenuItem1.Name = "จดการToolStripMenuItem1";
            จดการToolStripMenuItem1.Size = new Size(162, 22);
            จดการToolStripMenuItem1.Text = "จัดการพนักงาน";
            จดการToolStripMenuItem1.Click += จดการToolStripMenuItem1_Click;
            // 
            // คำนวนสนคาToolStripMenuItem
            // 
            คำนวนสนคาToolStripMenuItem.Name = "คำนวนสนคาToolStripMenuItem";
            คำนวนสนคาToolStripMenuItem.Size = new Size(75, 20);
            คำนวนสนคาToolStripMenuItem.Text = "คำนวนสินค้า";
            คำนวนสนคาToolStripMenuItem.Click += คำนวนสนคาToolStripMenuItem_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "main";
            Text = "รวม";
            Load += main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem จดการToolStripMenuItem;
        private ToolStripMenuItem จดการToolStripMenuItem1;
        private ToolStripMenuItem พนกงานToolStripMenuItem;
        private ToolStripMenuItem สนคToolStripMenuItem;
        private ToolStripMenuItem คำนวนสนคาToolStripMenuItem;
    }
}