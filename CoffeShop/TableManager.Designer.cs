namespace CoffeShop
{
    partial class fTableManager
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBTotalPrice = new System.Windows.Forms.TextBox();
            this.cBSwitch = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.nUDSale = new System.Windows.Forms.NumericUpDown();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nUDFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cBFood = new System.Windows.Forms.ComboBox();
            this.cBCategory = new System.Windows.Forms.ComboBox();
            this.flPTable = new System.Windows.Forms.FlowLayoutPanel();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSale)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFoodCount)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBill);
            this.panel2.Location = new System.Drawing.Point(685, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 430);
            this.panel2.TabIndex = 2;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.Location = new System.Drawing.Point(4, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(548, 424);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 195;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBTotalPrice);
            this.panel3.Controls.Add(this.cBSwitch);
            this.panel3.Controls.Add(this.btnSwitch);
            this.panel3.Controls.Add(this.nUDSale);
            this.panel3.Controls.Add(this.btnSale);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(685, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 69);
            this.panel3.TabIndex = 3;
            // 
            // txtBTotalPrice
            // 
            this.txtBTotalPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBTotalPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBTotalPrice.Location = new System.Drawing.Point(397, 18);
            this.txtBTotalPrice.Multiline = true;
            this.txtBTotalPrice.Name = "txtBTotalPrice";
            this.txtBTotalPrice.ReadOnly = true;
            this.txtBTotalPrice.Size = new System.Drawing.Size(155, 34);
            this.txtBTotalPrice.TabIndex = 5;
            this.txtBTotalPrice.Text = "0";
            // 
            // cBSwitch
            // 
            this.cBSwitch.FormattingEnabled = true;
            this.cBSwitch.Location = new System.Drawing.Point(160, 39);
            this.cBSwitch.Name = "cBSwitch";
            this.cBSwitch.Size = new System.Drawing.Size(98, 24);
            this.cBSwitch.TabIndex = 4;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(160, 3);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(98, 32);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Chuyển bàn";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // nUDSale
            // 
            this.nUDSale.Location = new System.Drawing.Point(7, 41);
            this.nUDSale.Name = "nUDSale";
            this.nUDSale.Size = new System.Drawing.Size(84, 22);
            this.nUDSale.TabIndex = 2;
            this.nUDSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(7, 3);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(84, 32);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "Giảm giá";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.BtnSale_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(311, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(80, 62);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nUDFoodCount);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.cBFood);
            this.panel4.Controls.Add(this.cBCategory);
            this.panel4.Location = new System.Drawing.Point(689, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 60);
            this.panel4.TabIndex = 4;
            // 
            // nUDFoodCount
            // 
            this.nUDFoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDFoodCount.Location = new System.Drawing.Point(422, 19);
            this.nUDFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUDFoodCount.Name = "nUDFoodCount";
            this.nUDFoodCount.Size = new System.Drawing.Size(71, 27);
            this.nUDFoodCount.TabIndex = 3;
            this.nUDFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 53);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cBFood
            // 
            this.cBFood.FormattingEnabled = true;
            this.cBFood.Location = new System.Drawing.Point(3, 33);
            this.cBFood.Name = "cBFood";
            this.cBFood.Size = new System.Drawing.Size(299, 24);
            this.cBFood.TabIndex = 1;
            // 
            // cBCategory
            // 
            this.cBCategory.FormattingEnabled = true;
            this.cBCategory.Location = new System.Drawing.Point(2, 4);
            this.cBCategory.Name = "cBCategory";
            this.cBCategory.Size = new System.Drawing.Size(299, 24);
            this.cBCategory.TabIndex = 0;
            this.cBCategory.SelectedIndexChanged += new System.EventHandler(this.CBCategory_SelectedIndexChanged);
            // 
            // flPTable
            // 
            this.flPTable.AutoScroll = true;
            this.flPTable.Location = new System.Drawing.Point(13, 41);
            this.flPTable.Name = "flPTable";
            this.flPTable.Size = new System.Drawing.Size(666, 568);
            this.flPTable.TabIndex = 5;
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.AdminToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.ThôngTinCáNhânToolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1252, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 621);
            this.Controls.Add(this.flPTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fTableManager";
            this.Text = "Phần mềm quản lý quán Coffe";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSale)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUDFoodCount)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nUDFoodCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cBFood;
        private System.Windows.Forms.ComboBox cBCategory;
        private System.Windows.Forms.FlowLayoutPanel flPTable;
        private System.Windows.Forms.ComboBox cBSwitch;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.NumericUpDown nUDSale;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtBTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}